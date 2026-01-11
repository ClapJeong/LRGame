using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace LR.UI.Lobby
{
  public class UIOptionPanelPresenter : IUIPresenter
  {
    public class Model
    {
      public UISO uiSO;
      public IUIIndicatorPresenter indicator;
      public IUIDepthService depthService;
      public IUISelectedGameObjectService selectedGameObjectService;
      public IUIInputActionManager uiInputActionManager;
      public UnityAction onExit;

      public Model(UISO uiSO, IUIIndicatorPresenter indicator, IUIDepthService depthService, IUISelectedGameObjectService selectedGameObjectService, IUIInputActionManager uiInputActionManager, UnityAction onExit)
      {
        this.uiSO = uiSO;
        this.indicator = indicator;
        this.depthService = depthService;
        this.selectedGameObjectService = selectedGameObjectService;
        this.uiInputActionManager = uiInputActionManager;
        this.onExit = onExit;
      }
    }

    private readonly Model model;
    private readonly UIOptionPanelView view;

    private readonly SubscribeHandle subscribeHandle;

    public UIOptionPanelPresenter(Model model, UIOptionPanelView view)
    {
      this.model = model;
      this.view = view;

      view.ExitProgressSubmit.Subscribe(
        Direction.Down,
        null,
        null,
        view.ExitFillImage.SetFillAmount,
        model.onExit);

      subscribeHandle = new(
        () =>
        {
          model.selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObject);
          model.uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.RightLeft, OnLeftPerformed);
          model.uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.RightRight, OnRightPerformed);

          model.depthService.RaiseDepth(view.MasterSlider.gameObject);
        },
        () =>
        {
          model.selectedGameObjectService.UnsubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObject);
          model.uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.RightLeft, OnLeftPerformed);
          model.uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.RightRight, OnRightPerformed);

          model.depthService.LowerDepth();
        });
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
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

    private void OnSelectedGameObject(GameObject gameObject)
    {
      if(gameObject.TryGetComponent<RectTransform>(out var rectTransform))
        model.indicator.MoveAsync(rectTransform).Forget();

      if (gameObject.TryGetComponent<Selectable>(out var selectable))
        model.indicator.SetLeftInputGuide(selectable.navigation);

      if (gameObject == view.MasterSlider.gameObject ||
          gameObject == view.BGMSlider.gameObject ||
          gameObject == view.SFXSlider.gameObject)
        model.indicator.SetRightInputGuide(Direction.Left, Direction.Right);
      else if(gameObject == view.ExitSelectable.gameObject)
        model.indicator.SetRightInputGuide(Direction.Down);
    }

    private void OnLeftPerformed()
    {
      var currenSelectedGameObject = EventSystem.current.currentSelectedGameObject;
      if (currenSelectedGameObject == view.MasterSlider.gameObject)
        view.MasterSlider.value -= model.uiSO.SliderAmount;
      else if(currenSelectedGameObject == view.BGMSlider.gameObject)
        view.BGMSlider.value -= model.uiSO.SliderAmount;
      else if(currenSelectedGameObject == view.SFXSlider.gameObject)
        view.SFXSlider.value -= model.uiSO.SliderAmount;
    }

    private void OnRightPerformed()
    {
      var currenSelectedGameObject = EventSystem.current.currentSelectedGameObject;
      if (currenSelectedGameObject == view.MasterSlider.gameObject)
        view.MasterSlider.value += model.uiSO.SliderAmount;
      else if (currenSelectedGameObject == view.BGMSlider.gameObject)
        view.BGMSlider.value += model.uiSO.SliderAmount;
      else if (currenSelectedGameObject == view.SFXSlider.gameObject)
        view.SFXSlider.value += model.uiSO.SliderAmount;
    }

  }
}
