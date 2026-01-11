using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using LR.UI.Lobby;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

namespace LR.UI.Lobby
{
  public class UILocalizePanelPresenter : IUIPresenter
  {
    public class Model
    {
      public IUIIndicatorPresenter indicator;
      public IUISelectedGameObjectService selectedGameObjectService;
      public IUIDepthService depthService;
      public UnityAction onExit;

      public Model(IUIIndicatorPresenter indicator, IUISelectedGameObjectService selectedGameObjectService, IUIDepthService depthService, UnityAction onExit)
      {
        this.indicator = indicator;
        this.selectedGameObjectService = selectedGameObjectService;
        this.depthService = depthService;
        this.onExit = onExit;
      }
    }

    private readonly Model model;
    private readonly UILocalizePanelView view;

    private readonly SubscribeHandle subscribeHandle;

    public UILocalizePanelPresenter(Model model, UILocalizePanelView view)
    {
      this.model = model;
      this.view = view;

      foreach(var buttonSet in view.ButtonSets)
        SubscribeLocaleButtonSet(buttonSet);

      view.ExitProgressSubmit.Subscribe(
        Direction.Down,
        null,
        null,
        view.ExitFillImage.SetFillAmount,
        model.onExit);

      subscribeHandle = new(
        () =>
        {
          model.selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);
          model.depthService.RaiseDepth(view.ButtonSets.First().RectTransform.gameObject);          
        },
        () =>
        {
          model.selectedGameObjectService.UnsubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);
          model.depthService.LowerDepth();          
        });
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      foreach (var buttonSet in view.ButtonSets)
        buttonSet.FillImage.fillAmount = LocalizationSettings.SelectedLocale == buttonSet.Locale ? 1.0f : 0.0f;
      subscribeHandle.Subscribe();
      model.depthService.SelectTopObject();
      await view.ShowAsync(isImmedieately, token);
    }

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      subscribeHandle.Unsubscribe();
      await view.HideAsync(isImmedieately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
      if (view)
        view.DestroySelf();
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    private void SubscribeLocaleButtonSet(UILocalizePanelView.ButtonSet buttonSet)
    {
      buttonSet.ProgressSubmitView.Subscribe(
        Direction.Up,
        onPerformed: null,
        onCanceled: null,
        onProgress: buttonSet.FillImage.SetFillAmount,
        onComplete: () => LocalizationSettings.SelectedLocale = buttonSet.Locale);
    }

    private void OnSelectedGameObjectEnter(GameObject gameObject)
    {
      model.indicator.MoveAsync(gameObject.GetComponent<RectTransform>());

      if (gameObject.TryGetComponent<Selectable>(out var selectable))
        model.indicator.SetLeftInputGuide(selectable.navigation);

      if (gameObject == view.ExitRectTransform.gameObject)
        model.indicator.SetRightInputGuide(Direction.Down);
      else
        model.indicator.SetRightInputGuide(Direction.Up);
    }
  }
}
