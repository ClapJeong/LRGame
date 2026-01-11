using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace LR.UI.Lobby
{
  public class UIMainPanelPresenter : IUIPresenter
  {
    public class Model
    {
      public IUISelectedGameObjectService selectedGameObjectService;
      public IUIDepthService depthService;
      public IUIIndicatorPresenter indicator;
      public UnityAction onOptionButton;
      public UnityAction onLocalizeButton;
      public UnityAction onStageButton;
      public UnityAction onQuitButton;

      public Model(IUISelectedGameObjectService selectedGameObjectService, IUIDepthService depthService, IUIIndicatorPresenter indicator, UnityAction onOptionButton, UnityAction onLocalizeButton, UnityAction onStageButton, UnityAction onQuitButton)
      {
        this.selectedGameObjectService = selectedGameObjectService;
        this.depthService = depthService;
        this.indicator = indicator;
        this.onOptionButton = onOptionButton;
        this.onLocalizeButton = onLocalizeButton;
        this.onStageButton = onStageButton;
        this.onQuitButton = onQuitButton;
      }
    }

    private readonly Model model;
    private readonly UIMainPanelView view;

    private readonly SubscribeHandle subscribeHandle;

    public UIMainPanelPresenter(Model model, UIMainPanelView view)
    {
      this.model = model;
      this.view = view;

      view.OptionButtonSet.ProgressSubmit.Subscribe(
        Direction.Up,
        null,
        null,
        view.OptionButtonSet.FillImage.SetFillAmount,
        OnOptionButtonSubmit);

      view.LocalizeButtonSet.ProgressSubmit.Subscribe(
        Direction.Up,
        null,
        null,
        view.LocalizeButtonSet.FillImage.SetFillAmount,
        OnLocalizeButtonSubmit);

      view.StageButtonSet.ProgressSubmit.Subscribe(
        Direction.Down,
        null,
        null,
        view.StageButtonSet.FillImage.SetFillAmount,
        OnStageSubmit);

      view.QuitProgressSubmit.Subscribe(
        Direction.Down,
        null,
        null,
        view.QuitRectFillImage.SetScale,
        OnOptionButtonSubmit);

      subscribeHandle = new(
        () =>
        {
          SubscribeSelectedGameObjectService();
          SubscribeCurrentDepth();
        },
        () =>
        {
          UnsubscribeSelectedGameObjectService();
          UnsubscribeCurrentDepth();
        });

      view.ShowAsync(true).Forget();
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      subscribeHandle.Subscribe();
      model.depthService.SelectTopObject();
      model.selectedGameObjectService.SetSelectedObject(view.StageButtonSet.RectTransform.gameObject);
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

    private void OnOptionButtonSubmit()
    {
      model.onOptionButton?.Invoke();
    }

    private void OnLocalizeButtonSubmit()
    {
      model.onLocalizeButton?.Invoke();
    }

    private void OnStageSubmit()
    {
      model.onStageButton?.Invoke();
    }

    private void OnOptionQuitSubmit()
    {
      model.onQuitButton?.Invoke();
#if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
#endif
      Application.Quit();
    }

    private void SubscribeSelectedGameObjectService()
    {
      model.selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, UpdateIndicatorGuide);
      model.selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, SetIndicatorTarget);
    }

    private void UnsubscribeSelectedGameObjectService()
    {
      model.selectedGameObjectService.UnsubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, UpdateIndicatorGuide);
      model.selectedGameObjectService.UnsubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, SetIndicatorTarget);
    }

    private void SubscribeCurrentDepth()
    {
      model.depthService.RaiseDepth(view.StageButtonSet.RectTransform.gameObject);
    }

    private void UnsubscribeCurrentDepth() 
    {
      model.depthService.LowerDepth();
    }

    private void SetIndicatorTarget(GameObject gameObject)
    {
      if (gameObject != null)
        model.indicator.MoveAsync(gameObject.GetComponent<RectTransform>());
    }

    private void UpdateIndicatorGuide(GameObject gameObject)
    {
      model.indicator.SetLeftInputGuide(gameObject.GetComponent<Selectable>().navigation);
      var selectedRectTransform = gameObject.GetComponent<RectTransform>();
      if (selectedRectTransform == view.OptionButtonSet.RectTransform)
        model.indicator.SetRightInputGuide(Direction.Up);
      else if (selectedRectTransform == view.LocalizeButtonSet.RectTransform)
        model.indicator.SetRightInputGuide(Direction.Up);
      else if (selectedRectTransform == view.StageButtonSet.RectTransform)
        model.indicator.SetRightInputGuide(Direction.Down);
      else if (selectedRectTransform == view.QuitRect)
        model.indicator.SetRightInputGuide(Direction.Down);
    }
  }
}
