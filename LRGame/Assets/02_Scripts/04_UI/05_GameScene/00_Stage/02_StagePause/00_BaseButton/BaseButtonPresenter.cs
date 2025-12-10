using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
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
    private readonly BaseButtonView view;

    private SubscribeHandle subscribeHandle;

    private readonly ReactiveProperty<float> maxProgress = new(0.0f);
    private readonly ReactiveProperty<float> minProgress = new(0.0f);

    public BaseButtonPresenter(Model model, BaseButtonView view)
    {
      this.model = model;
      this.view = view;

      minProgress.Subscribe(view.minImageView.SetFillAmount);
      maxProgress.Subscribe(view.maxImageView.SetFillAmount);

      subscribeHandle = new SubscribeHandle(
        onSubscribe: () =>
        {
          model.uiInputActionManager.SubscribePerformedEvent(model.maxinputDirectionType, OnMaxInputActionPerformed);
          model.uiInputActionManager.SubscribeCanceledEvent(model.maxinputDirectionType, OnMaxInputActionCanceled);
          model.uiInputActionManager.SubscribePerformedEvent(model.mininputDirectionType, OnMinInputActionPerformed);
          model.uiInputActionManager.SubscribeCanceledEvent(model.mininputDirectionType, OnMinInputActionCanceled);

          view.maxProgressSubmitView.SubscribeOnProgress(model.maxinputDirectionType.ParseToDirection(), OnMaxSubscribeProgress);
          view.maxProgressSubmitView.SubscribeOnCanceled(model.maxinputDirectionType.ParseToDirection(), OnMaxSubscribeCancel);

          view.minProgressSubmitView.SubscribeOnProgress(model.mininputDirectionType.ParseToDirection(), OnMinSubscribeProgress);
          view.minProgressSubmitView.SubscribeOnCanceled(model.mininputDirectionType.ParseToDirection(), OnMinSubscribeCancel);
        },
        onUnsubscribe: () =>
        {
          model.uiInputActionManager.UnsubscribePerformedEvent(model.maxinputDirectionType, OnMaxInputActionPerformed);
          model.uiInputActionManager.UnsubscribeCanceledEvent(model.maxinputDirectionType, OnMaxInputActionCanceled);
          model.uiInputActionManager.UnsubscribePerformedEvent(model.mininputDirectionType, OnMinInputActionPerformed);
          model.uiInputActionManager.UnsubscribeCanceledEvent(model.mininputDirectionType, OnMaxInputActionPerformed);

          view.maxProgressSubmitView.UnsubscribeAll();

          view.minProgressSubmitView.UnsubscribeAll();
        });
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
      if (view)
        view.DestroySelf();
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      minProgress.Value = 0.0f;
      maxProgress.Value = 0.0f;
      subscribeHandle.Subscribe();
      await view.ShowAsync(isImmediately, token);
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      view.minProgressSubmitView.Cancel(model.mininputDirectionType.ParseToDirection());
      view.maxProgressSubmitView.Cancel(model.maxinputDirectionType.ParseToDirection());
      subscribeHandle.Unsubscribe();
      await view.HideAsync(isImmediately, token);
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    private bool IsProgressComplete()
      => minProgress.Value + maxProgress.Value > 1.0f;

    private void OnMaxInputActionPerformed()
      => view.maxProgressSubmitView.Perform(model.maxinputDirectionType.ParseToDirection());

    private void OnMaxInputActionCanceled()
      => view.maxProgressSubmitView.Cancel(model.maxinputDirectionType.ParseToDirection());

    private void OnMinInputActionPerformed()
      => view.minProgressSubmitView.Perform(model.mininputDirectionType.ParseToDirection());

    private void OnMinInputActionCanceled()
      => view.minProgressSubmitView.Cancel(model.mininputDirectionType.ParseToDirection());

    private void OnMaxSubscribeProgress(float value)
    {
      if (IsProgressComplete())
        return;

      maxProgress.Value = value;

      if (IsProgressComplete())
      {
        model.onSubmit?.Invoke();
        subscribeHandle.Unsubscribe();
      }
    }

    private void OnMaxSubscribeCancel()
    {
      if (IsProgressComplete())
        return;

      maxProgress.Value = 0.0f;
    }

    private void OnMinSubscribeProgress(float value)
    {
      if (IsProgressComplete())
        return;

      minProgress.Value = value;

      if (IsProgressComplete())
      {
        model.onSubmit?.Invoke();
        subscribeHandle.Unsubscribe();
      }
    }

    private void OnMinSubscribeCancel()
    {
      if (IsProgressComplete())
        return;

      minProgress.Value = 0.0f;
    }
  }
}