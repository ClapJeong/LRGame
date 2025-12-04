using Cysharp.Threading.Tasks;
using System.Threading;
using System;
using UnityEngine.Events;
using UnityEngine;

namespace LR.UI.GameScene.Stage.SuccessPanel
{
  public class BaseButtonPresenter: IUIPresenter
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
    private readonly BaseButtonViewContainer viewContainer;

    private SubscribeHandle subscribeHandle;

    public BaseButtonPresenter(Model model, BaseButtonViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      CreateSubscribeHandle();

      viewContainer.backgroundImageView.SetAlpha(0.4f);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Subscribe();
      viewContainer.backgroundImageView.SetAlpha(1.0f);
      return UniTask.CompletedTask;
    }

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      viewContainer.progressSubmitView.Cancel(model.inputActionType.ParseToDirection());
      viewContainer.backgroundImageView.SetAlpha(0.4f);
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
          viewContainer.progressSubmitView.SubscribeOnProgress(direction, viewContainer.fillImageView.SetFillAmount);
          viewContainer.progressSubmitView.SubscribeOnCanceled(direction, () => viewContainer.fillImageView.SetFillAmount(0.0f));
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