using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.Rendering.DebugUI;

namespace LR.UI.GameScene.Stage.PausePanel
{
  public class ResumeButtonPresenter : IUIPresenter
  {
    public class Model
    {
      public UIInputActionType inputActionType;
      public UnityAction onSubmit;
      public IUIInputActionManager uiInputActionManager;

      public Model(UnityAction onSubmit, IUIInputActionManager uiInputActionManager)
      {
        this.onSubmit = onSubmit;
        this.uiInputActionManager = uiInputActionManager;
      }
    }

    private readonly Model model;
    private readonly ResumeButtonViewContainer viewContainer;

    private SubscribeHandle subscribeHandle;

    public ResumeButtonPresenter(Model model, ResumeButtonViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      subscribeHandle = new SubscribeHandle(
        onSubscribe: () =>
        {
          model.uiInputActionManager.SubscribePerformedEvent(model.inputActionType, OnInputActionPerform);
          model.uiInputActionManager.SubscribeCanceledEvent(model.inputActionType, OnInputActionCancel);

          var direction = model.inputActionType.ParseToDirection();
          viewContainer.progressSubmitView.SubscribeOnProgress(direction, value =>
          {
            viewContainer.imageView.SetFillAmount(value);
          });
          viewContainer.progressSubmitView.SubscribeOnCanceled(direction, () =>
          {
            viewContainer.imageView.SetFillAmount(0.0f);
          });
          viewContainer.progressSubmitView.SubscribeOnComplete(direction, () =>
          {
            model.onSubmit?.Invoke();
            subscribeHandle.Unsubscribe();
          });
        },
        onUnsubscribe: () =>
        {
          model.uiInputActionManager.UnsubscribePerformedEvent(model.inputActionType, OnInputActionPerform);
          model.uiInputActionManager.UnsubscribeCanceledEvent(model.inputActionType, OnInputActionCancel);

          viewContainer.progressSubmitView.UnsubscribeAll();
        });
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }


    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Unsubscribe();
      return UniTask.CompletedTask;
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Subscribe();
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public UIVisibleState GetVisibleState()
    {
      throw new NotImplementedException();
    }    

    private void OnInputActionPerform()
      => viewContainer.progressSubmitView.Perform(Direction.Space);

    private void OnInputActionCancel()
      => viewContainer.progressSubmitView.Cancel(Direction.Space);
  }
}