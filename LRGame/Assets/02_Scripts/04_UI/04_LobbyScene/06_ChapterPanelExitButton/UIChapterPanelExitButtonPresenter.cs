using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using LR.UI.Enum;

namespace LR.UI.Lobby
{
  public class UIChapterPanelExitButtonPresenter : IUIPresenter
  {
    public class Model
    {      
      public IUIIndicatorPresenter indicator;
      public IUISelectedGameObjectService selectedGameObjectService;
      public Direction exitInputDirection;
      public UnityAction onExit;

      public Model(IUIIndicatorPresenter indicator, IUISelectedGameObjectService selectedGameObjectService, Direction exitInputDirection, UnityAction onExit)
      {
        this.indicator = indicator;
        this.selectedGameObjectService = selectedGameObjectService;
        this.exitInputDirection = exitInputDirection;
        this.onExit = onExit;
      }
    }

    private readonly Model model;
    private readonly UIChapterPanelExitButtonView view;

    private readonly SubscribeHandle subscribeHandle;

    public UIChapterPanelExitButtonPresenter(Model model, UIChapterPanelExitButtonView view)
    {
      this.model = model;
      this.view = view;

      view.FillImage.fillAmount = 0.0f;

      view.ProgressSubmitView.Subscribe(
  model.exitInputDirection,
  onPerformed: null,
  onCanceled: null,
  onProgress: view.FillImage.SetFillAmount,
  onComplete: model.onExit);

      subscribeHandle = new(
        onSubscribe: () =>
        {
          model.selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelect);
        },
        onUnsubscribe: () =>
        {
          model.selectedGameObjectService.UnsubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelect);
        });
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      subscribeHandle.Subscribe();
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

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

    private void OnSelect(GameObject gameObject)
    {
      if(gameObject == view.gameObject)
      {
        model.indicator.SetLeftInputGuide(Direction.Up, IUIIndicatorPresenter.LeftInputGuideType.Movable);
        model.indicator.SetRightInputGuide(model.exitInputDirection);
      }
    }
  }
}
