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
    private readonly ResumeButtonViewContainer viewContainer;

    private SubscribeHandle subscribeHandle;

    public ResumeButtonPresenter(Model model, ResumeButtonViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      viewContainer.fillScaleView.SetLocalScale(Vector3.zero);
      viewContainer.gameObjectView.SetActive(false);
      CreateSubscribeHandle();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }


    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      viewContainer.gameObjectView.SetActive(false);
      viewContainer.progressSubmitView.Cancel(model.inputDirectionType.ParseToDirection());
      subscribeHandle.Unsubscribe();
      return UniTask.CompletedTask;
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      viewContainer.gameObjectView.SetActive(true);
      viewContainer.fillScaleView.SetLocalScale(Vector3.zero);
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

    private void CreateSubscribeHandle()
    {
      subscribeHandle = new SubscribeHandle(
        onSubscribe: () =>
        {
          model.uiInputActionManager.SubscribePerformedEvent(model.inputDirectionType, OnInputActionPerform);
          model.uiInputActionManager.SubscribeCanceledEvent(model.inputDirectionType, OnInputActionCancel);

          var direction = model.inputDirectionType.ParseToDirection();
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
            subscribeHandle.Unsubscribe();
          });
        },
        onUnsubscribe: () =>
        {
          model.uiInputActionManager.UnsubscribePerformedEvent(model.inputDirectionType, OnInputActionPerform);
          model.uiInputActionManager.UnsubscribeCanceledEvent(model.inputDirectionType, OnInputActionCancel);

          viewContainer.progressSubmitView.UnsubscribeAll();
        });
    }
  }
}