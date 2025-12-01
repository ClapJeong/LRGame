using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.Lobby
{
  public class UIChapterPanelQuitButtonPresenter : IUIPresenter
  {
    public class Model
    {
      public UIInputActionType inputActionType;
      public IUIInputActionManager uiInputActionManager;
      public UnityAction onQuit;

      public Model(UIInputActionType inputActionType, IUIInputActionManager uiInputActionManager, UnityAction onQuit)
      {
        this.inputActionType = inputActionType;
        this.uiInputActionManager = uiInputActionManager;
        this.onQuit = onQuit;
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
      var direction = model.inputActionType.ParseToDirection();

      viewContainer.quitProgressSubmitView.ResetAllProgress();
      viewContainer.quitProgressSubmitView.SubscribeOnProgress(direction, value => viewContainer.quitImageView.SetFillAmount(value));
      viewContainer.quitProgressSubmitView.SubscribeOnCanceled(direction, () => viewContainer.quitImageView.SetFillAmount(0.0f));
      viewContainer.quitProgressSubmitView.SubscribeOnComplete(direction, () => model.onQuit?.Invoke());
    }

    private void UnsubscribeSubmit()
    {
      viewContainer.quitProgressSubmitView.UnsubscribeAll();
    }

    private void SubscribeInputAction()
    {     
      model.uiInputActionManager.SubscribePerformedEvent(model.inputActionType, OnInputLeftPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(model.inputActionType, OnInputLeftCanceled);
    }

    private void UnsubscribeInputAction()
    {
      var direction = model.inputActionType.ParseToDirection();

      model.uiInputActionManager.UnsubscribePerformedEvent(model.inputActionType, OnInputLeftPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(model.inputActionType, OnInputLeftCanceled);
    }

    private void OnInputLeftPerformed()
      => viewContainer.quitProgressSubmitView.Perform(model.inputActionType.ParseToDirection());

    private void OnInputLeftCanceled()
      => viewContainer.quitProgressSubmitView.Cancel(model.inputActionType.ParseToDirection());
    #endregion
  }
}