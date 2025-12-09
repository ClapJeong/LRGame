using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.GameScene.Stage.PausePanel
{
  public class BaseButtonPresenter : IUIPresenter
  {
    public class Model
    {
      public UIInputDirectionType mininputDirectionType;
      public UIInputDirectionType maxinputDirectionType;
      public UnityAction onSubmit;
      public IUIInputActionManager uiInputActionManager;

      public Model(UIInputDirectionType mininputDirectionType, UIInputDirectionType maxinputDirectionType, UnityAction onSubmit, IUIInputActionManager uiInputActionManager)
      {
        this.mininputDirectionType = mininputDirectionType;
        this.maxinputDirectionType = maxinputDirectionType;
        this.onSubmit = onSubmit;
        this.uiInputActionManager = uiInputActionManager;
      }
    }

    private readonly Model model;
    private readonly BaseButtonViewContainer viewContainer;

    private SubscribeHandle subscribeHandle;
    private float maxProgress = 0.0f;
    private float minProgress = 0.0f;

    public BaseButtonPresenter(Model model, BaseButtonViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      viewContainer.gameObjectView.SetActive(false);

      subscribeHandle = new SubscribeHandle(
        onSubscribe: () =>
        {
          model.uiInputActionManager.SubscribePerformedEvent(model.maxinputDirectionType, OnMaxInputActionPerformed);
          model.uiInputActionManager.SubscribeCanceledEvent(model.maxinputDirectionType, OnMaxInputActionCanceled);
          model.uiInputActionManager.SubscribePerformedEvent(model.mininputDirectionType, OnMinInputActionPerformed);
          model.uiInputActionManager.SubscribeCanceledEvent(model.mininputDirectionType, OnMinInputActionCanceled);

          viewContainer.maxProgressSubmitView.SubscribeOnProgress(model.maxinputDirectionType.ParseToDirection(), value =>
          {
            if (isProgressComplete())
              return;

            viewContainer.maxImageView.SetFillAmount(value);
            maxProgress = value;

            if (isProgressComplete())
            {
              model.onSubmit?.Invoke();
              subscribeHandle.Unsubscribe();
            }
          });
          viewContainer.maxProgressSubmitView.SubscribeOnCanceled(model.maxinputDirectionType.ParseToDirection(), () =>
          {
            if (isProgressComplete())
              return;

            viewContainer.maxImageView.SetFillAmount(0.0f);
            maxProgress = 0.0f;
          });

          viewContainer.minProgressSubmitView.SubscribeOnProgress(model.mininputDirectionType.ParseToDirection(), value =>
          {
            if (isProgressComplete())
              return;

            viewContainer.minImageView.SetFillAmount(value);
            minProgress = value;

            if (isProgressComplete())
            {
              model.onSubmit?.Invoke();
              subscribeHandle.Unsubscribe();
            }
          });
          viewContainer.minProgressSubmitView.SubscribeOnCanceled(model.mininputDirectionType.ParseToDirection(), () =>
          {
            if (isProgressComplete())
              return;

            viewContainer.minImageView.SetFillAmount(0.0f);
            minProgress = 0.0f;
          });
        },
        onUnsubscribe: () =>
        {
          model.uiInputActionManager.UnsubscribePerformedEvent(model.maxinputDirectionType, OnMaxInputActionPerformed);
          model.uiInputActionManager.UnsubscribeCanceledEvent(model.maxinputDirectionType, OnMaxInputActionCanceled);
          model.uiInputActionManager.UnsubscribePerformedEvent(model.mininputDirectionType, OnMinInputActionPerformed);
          model.uiInputActionManager.UnsubscribeCanceledEvent(model.mininputDirectionType, OnMaxInputActionPerformed);

          viewContainer.maxProgressSubmitView.UnsubscribeAll();
          viewContainer.minProgressSubmitView.UnsubscribeAll();
        });
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      minProgress = 0.0f;
      maxProgress = 0.0f;
      viewContainer.gameObjectView.SetActive(true);
      subscribeHandle.Subscribe();
      return UniTask.CompletedTask;
    }

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      viewContainer.minProgressSubmitView.Cancel(model.mininputDirectionType.ParseToDirection());
      viewContainer.maxProgressSubmitView.Cancel(model.maxinputDirectionType.ParseToDirection());
      viewContainer.gameObjectView.SetActive(false);
      subscribeHandle.Unsubscribe();
      return UniTask.CompletedTask;
    }

    public UIVisibleState GetVisibleState()
    {
      throw new NotImplementedException();
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    private bool isProgressComplete()
      => minProgress + maxProgress > 1.0f;

    private void OnMaxInputActionPerformed()
      => viewContainer.maxProgressSubmitView.Perform(model.maxinputDirectionType.ParseToDirection());

    private void OnMaxInputActionCanceled()
      => viewContainer.maxProgressSubmitView.Cancel(model.maxinputDirectionType.ParseToDirection());

    private void OnMinInputActionPerformed()
      => viewContainer.minProgressSubmitView.Perform(model.mininputDirectionType.ParseToDirection());

    private void OnMinInputActionCanceled()
      => viewContainer.minProgressSubmitView.Cancel(model.mininputDirectionType.ParseToDirection());
  }
}