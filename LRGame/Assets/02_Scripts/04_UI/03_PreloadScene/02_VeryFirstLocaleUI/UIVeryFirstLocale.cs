using Cysharp.Threading.Tasks;
using DG.Tweening;
using LR.UI.Indicator;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

namespace LR.UI.Preloading
{
  public class UIVeryFirstLocale : MonoBehaviour
  {
    [System.Serializable]
    public class ButtonSet
    {
      [field: SerializeField] public Locale Locale { get; private set; }
      [field: SerializeField] public UIProgressSubmitViewFillSet ProgressSubmitFillSet { get; private set; }
    }
    public class Model
    {
      public LocaleService localeService;
      public IUIIndicatorService indicatorService;
      public IUISelectedGameObjectService selectedGameObjectService;
      public IUIDepthService depthService;
      public IUIInputManager uiInputManager;
      public UnityAction onConfirm;

      public Model(LocaleService localeService,
        IUIIndicatorService indicatorService, 
        IUISelectedGameObjectService selectedGameObjectService, 
        IUIDepthService depthService, 
        IUIInputManager uiInputManager, 
        UnityAction onConfirm)
      {
        this.localeService = localeService;
        this.indicatorService = indicatorService;
        this.selectedGameObjectService = selectedGameObjectService;
        this.depthService = depthService;
        this.uiInputManager = uiInputManager;
        this.onConfirm = onConfirm;
      }
    }

    [SerializeField] private List<ButtonSet> buttonSets;
    [SerializeField] private Transform indicatorRoot;
    [SerializeField] private CanvasGroup canvasGroup;

    private Model model;

    private IUIIndicatorPresenter indicator;

    public async UniTask InitializeAsync(Model model)
    {
      this.model = model;

      await LocaleAutoSetter.SetLocaleBySystemLanguageAsync();

      model.selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);

      foreach (var buttonSet in buttonSets)
      {
        buttonSet.ProgressSubmitFillSet.FillImage.fillAmount = 0.0f;

        buttonSet.ProgressSubmitFillSet.Subscribe(
                  direction: buttonSet.ProgressSubmitFillSet.InputDirection,
                  onPerformed: null,
                  onCanceled: null,
                  onProgress: buttonSet.ProgressSubmitFillSet.FillImage.SetFillAmount,
                  onComplete: () =>
                  {
                    model.localeService.SetLocale(buttonSet.Locale);
                    model.localeService.SaveLocale();
                  });

        if (LocalizationSettings.SelectedLocale == buttonSet.Locale)
        {
          indicator = await model.indicatorService.GetNewAsync(indicatorRoot, buttonSet.ProgressSubmitFillSet.RectTransform);
          indicator.SetRightInputGuide(Direction.Up);
          model.depthService.RaiseDepth(buttonSet.ProgressSubmitFillSet.RectTransform.gameObject);
        }
      }        

      model.uiInputManager.SubscribePerformedEvent(Enum.InputDirection.Space, model.onConfirm);
    }

    public async UniTask DestroyAsync(IResourceManager resourceManager)
    {
      model.uiInputManager.UnsubscribePerformedEvent(Enum.InputDirection.Space, model.onConfirm);
      model.selectedGameObjectService.UnsubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);
      model.indicatorService.ReleaseTopIndicator();      

      await DOTween
        .Sequence()
        .Append(canvasGroup.DOFade(0.0f, 1.0f))
        .AppendInterval(0.5f)
        .OnComplete(() =>
        {
          resourceManager.ReleaseInstance(gameObject);
        })
        .ToUniTask(TweenCancelBehaviour.Complete);
    }

    private void OnSelectedGameObjectEnter(GameObject gameObject)
    {
      if (gameObject.TryGetComponent<RectTransform>(out var rectTransform))
        indicator.MoveAsync(rectTransform);

      if (gameObject.TryGetComponent<Selectable>(out var selectable))
        indicator.SetLeftInputGuide(selectable.navigation);        
    }
  }
}
