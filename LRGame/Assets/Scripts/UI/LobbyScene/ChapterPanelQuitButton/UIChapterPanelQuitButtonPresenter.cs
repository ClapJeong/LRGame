using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIChapterPanelQuitButtonPresenter : IUIPresenter
  {
    public class Model
    {
      public UIInputActionType inputActionType;

      public Model(UIInputActionType inputActionType)
      {
        this.inputActionType = inputActionType;
      }
    }

    private readonly Model model;
    private readonly UIChapterPanelQuitButtonViewContainer viewContainer;

    public UIChapterPanelQuitButtonPresenter(Model model, UIChapterPanelQuitButtonViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      
    }

    public UIVisibleState GetVisibleState()
    {
      return UIVisibleState.None;
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      SubscribeSubmit();
      SubscribeInputAction();
      return UniTask.CompletedTask;
    }

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      UnsubscribeSubmit();
      UnsubscribeInputAction();
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    #region Subscribes
    private void SubscribeSubmit()
    {
      viewContainer.quitProgressSubmitView.ResetAllProgress();
      viewContainer.quitProgressSubmitView.SubscribeOnProgress(Direction.Space, value => viewContainer.quitImageView.SetFillAmount(value));
      viewContainer.quitProgressSubmitView.SubscribeOnComplete(Direction.Space, () =>
      {
        viewContainer.quitProgressSubmitView.UnsubscribeAll();
        HideAsync().Forget();
      });
    }

    private void UnsubscribeSubmit()
    {
      viewContainer.quitProgressSubmitView.UnsubscribeAll();
    }

    private void SubscribeInputAction()
    {
      IUIInputActionManager inputActionManager = GlobalManager.instance.UIInputManager;
      inputActionManager.SubscribePerformedEvent(UIInputActionType.RightLeft, OnInputLeftPerformed);
      inputActionManager.SubscribeCanceledEvent(UIInputActionType.RightLeft, OnInputLeftCanceled);
    }

    private void UnsubscribeInputAction()
    {
      IUIInputActionManager inputActionManager = GlobalManager.instance.UIInputManager;
      inputActionManager.UnsubscribePerformedEvent(UIInputActionType.RightLeft, OnInputLeftPerformed);
      inputActionManager.UnsubscribeCanceledEvent(UIInputActionType.RightLeft, OnInputLeftCanceled);
    }

    private void OnInputLeftPerformed()
      => viewContainer.quitProgressSubmitView.Perform(model.inputActionType.ParseToDirection());

    private void OnInputLeftCanceled()
      => viewContainer.quitProgressSubmitView.Cancel(model.inputActionType.ParseToDirection());
    #endregion
  }
}