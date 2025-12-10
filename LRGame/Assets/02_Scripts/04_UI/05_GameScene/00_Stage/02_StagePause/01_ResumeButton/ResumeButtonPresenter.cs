using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.GameScene.Stage.PausePanel
{
  public class ResumeButtonPresenter : IUIPresenter
  {
    public class Model
    {
      public UIInputDirectionType inputDirectionType;
      public UnityAction onSubmit;
      public IUIInputActionManager uiInputActionManager;

      public Model(UIInputDirectionType inputDirectionType, UnityAction onSubmit, IUIInputActionManager uiInputActionManager)
      {
        this.inputDirectionType = inputDirectionType;
        this.onSubmit = onSubmit;
        this.uiInputActionManager = uiInputActionManager;
      }
    }

    private readonly Model model;
    private readonly ResumeButtonView view;

    private SubscribeHandle subscribeHandle;

    public ResumeButtonPresenter(Model model, ResumeButtonView view)
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


    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      view.progressSubmitView.Cancel(model.inputDirectionType.ParseToDirection());
      subscribeHandle.Unsubscribe();
      await view.HideAsync(isImmediately, token);
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {     
      subscribeHandle.Subscribe();
      await view.ShowAsync(isImmediately, token);
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    private void OnInputActionPerform()
      => view.progressSubmitView.Perform(Direction.Space);

    private void OnInputActionCancel()
      => view.progressSubmitView.Cancel(Direction.Space);

    private void CreateSubscribeHandle()
    {
      subscribeHandle = new SubscribeHandle(
        onSubscribe: () =>
        {
          model.uiInputActionManager.SubscribePerformedEvent(model.inputDirectionType, OnInputActionPerform);
          model.uiInputActionManager.SubscribeCanceledEvent(model.inputDirectionType, OnInputActionCancel);

          var direction = model.inputDirectionType.ParseToDirection();
          view.progressSubmitView.SubscribeOnProgress(direction, OnSubmitProgress);
          view.progressSubmitView.SubscribeOnCanceled(direction, OnSubmitCancel);
          view.progressSubmitView.SubscribeOnComplete(direction, OnSubmitComplete);
        },
        onUnsubscribe: () =>
        {
          model.uiInputActionManager.UnsubscribePerformedEvent(model.inputDirectionType, OnInputActionPerform);
          model.uiInputActionManager.UnsubscribeCanceledEvent(model.inputDirectionType, OnInputActionCancel);

          view.progressSubmitView.UnsubscribeAll();
        });
    }

    private void OnSubmitProgress(float value)
      => view.fillScaleView.SetLocalScale(Vector3.one * value);

    private void OnSubmitCancel()
      => view.fillScaleView.SetLocalScale(Vector3.zero);

    private void OnSubmitComplete()
    {
      model.onSubmit?.Invoke();
      subscribeHandle.Unsubscribe();
    }
  }
}