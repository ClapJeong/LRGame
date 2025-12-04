using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.GameScene.Stage.SuccessPanel
{
  public class CenterButtonPresenter : IUIPresenter
  {
    public class Model
    {
      public UIInputActionType inputActionType;
      public IUIInputActionManager uiInputActionManager;
      public UnityAction onSubmit;

      public Model(UIInputActionType inputActionType, IUIInputActionManager uiInputActionManager, UnityAction onSubmit)
      {
        this.inputActionType = inputActionType;
        this.uiInputActionManager = uiInputActionManager;
        this.onSubmit = onSubmit;
      }
    }

    private readonly Model model;
    private readonly CenterButtonViewContainer viewContainer;

    private SubscribeHandle subscribeHandle;

    public CenterButtonPresenter(Model model, CenterButtonViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      viewContainer.backgroundImageView.SetAlpha(0.4f);
      CreateSubscribeHandle();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      viewContainer.backgroundImageView.SetAlpha(1.0f);
      viewContainer.fillScaleView.SetLocalScale(Vector3.zero);
      subscribeHandle.Subscribe();
      return UniTask.CompletedTask;
    }

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      viewContainer.backgroundImageView.SetAlpha(0.4f);
      viewContainer.progressSubmitView.Cancel(model.inputActionType.ParseToDirection());
      subscribeHandle.Unsubscribe();
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

    private void CreateSubscribeHandle()
    {
      subscribeHandle = new(
        onSubscribe: () =>
        {
          model.uiInputActionManager.SubscribePerformedEvent(model.inputActionType, OnInputPerformed);
          model.uiInputActionManager.SubscribeCanceledEvent(model.inputActionType, OnInputCanceled);

          var direction = model.inputActionType.ParseToDirection();
          viewContainer.progressSubmitView.SubscribeOnProgress(direction, value =>
          {
            viewContainer.fillScaleView.SetLocalScale(Vector3.one * value);
          });
          viewContainer.progressSubmitView.SubscribeOnCanceled(direction, () =>
          {
            viewContainer.fillScaleView.SetLocalScale(Vector3.zero);
          });
          viewContainer.progressSubmitView.SubscribeOnComplete(direction, () =>
          {
            model.onSubmit?.Invoke();
          });
        },
        onUnsubscribe: () =>
        {
          model.uiInputActionManager.UnsubscribePerformedEvent(model.inputActionType, OnInputPerformed);
          model.uiInputActionManager.UnsubscribeCanceledEvent(model.inputActionType, OnInputCanceled);

          viewContainer.progressSubmitView.UnsubscribeAll();
        });
    }

    private void OnInputPerformed()
    {
      viewContainer.progressSubmitView.Perform(model.inputActionType.ParseToDirection());
    }

    private void OnInputCanceled()
    {
      viewContainer.progressSubmitView.Cancel(model.inputActionType.ParseToDirection());
    }
  }
}