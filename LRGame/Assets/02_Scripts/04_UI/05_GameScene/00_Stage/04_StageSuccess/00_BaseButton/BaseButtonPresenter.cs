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
      public UIInputDirectionType inputDirectionType;
      public IUIInputActionManager uiInputActionManager;
      public UnityAction onSubmit;

      public Model(UIInputDirectionType inputDirectionType, IUIInputActionManager uiInputActionManager, UnityAction onSubmit)
      {
        this.inputDirectionType = inputDirectionType;
        this.uiInputActionManager = uiInputActionManager;
        this.onSubmit = onSubmit;
      }
    }

    private readonly Model model;
    private readonly BaseButtonView view;

    private SubscribeHandle subscribeHandle;

    public BaseButtonPresenter(Model model, BaseButtonView view)
    {
      this.model = model;
      this.view = view;

      CreateSubscribeHandle();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Subscribe();
      await view.ShowAsync(isImmediately, token);
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      view.progressSubmitView.Cancel(model.inputDirectionType.ParseToDirection());      
      subscribeHandle.Unsubscribe();      
      await view.HideAsync(isImmediately, token);
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    private void CreateSubscribeHandle()
    {
      subscribeHandle = new(
        onSubscribe: () =>
        {
          model.uiInputActionManager.SubscribePerformedEvent(model.inputDirectionType, OnInputPerformed);
          model.uiInputActionManager.SubscribeCanceledEvent(model.inputDirectionType, OnInputCanceled);

          var direction = model.inputDirectionType.ParseToDirection();
          view.progressSubmitView.SubscribeOnProgress(direction, view.fillImageView.SetFillAmount);
          view.progressSubmitView.SubscribeOnCanceled(direction, () => view.fillImageView.SetFillAmount(0.0f));
          view.progressSubmitView.SubscribeOnComplete(direction, () =>
          {
            model.onSubmit?.Invoke();
          });
        },
        onUnsubscribe: () =>
        {
          model.uiInputActionManager.UnsubscribePerformedEvent(model.inputDirectionType, OnInputPerformed);
          model.uiInputActionManager.UnsubscribeCanceledEvent(model.inputDirectionType, OnInputCanceled);

          view.progressSubmitView.UnsubscribeAll();
        });
    }

    private void OnInputPerformed()
    {
      view.progressSubmitView.Perform(model.inputDirectionType.ParseToDirection());
    }

    private void OnInputCanceled()
    {
      view.progressSubmitView.Cancel(model.inputDirectionType.ParseToDirection());
    }
  }
}