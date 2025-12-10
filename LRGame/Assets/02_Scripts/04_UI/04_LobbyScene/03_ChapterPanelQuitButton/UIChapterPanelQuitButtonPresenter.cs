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
      public UIInputDirectionType inputDirectionType;
      public IUIInputActionManager uiInputActionManager;
      public UnityAction onQuit;

      public Model(UIInputDirectionType inputDirectionType, IUIInputActionManager uiInputActionManager, UnityAction onQuit)
      {
        this.inputDirectionType = inputDirectionType;
        this.uiInputActionManager = uiInputActionManager;
        this.onQuit = onQuit;
      }
    }

    private readonly Model model;
    private readonly UIChapterPanelQuitButtonView view;

    private readonly SubscribeHandle subscribeHandle;

    public UIChapterPanelQuitButtonPresenter(Model model, UIChapterPanelQuitButtonView view)
    {
      this.model = model;
      this.view = view;

      subscribeHandle = new SubscribeHandle( 
        ()=>
        {
          SubscribeInputAction();
          SubscribeSubmit();
        },
        ()=>
        {
          UnsubscribeInputAction();
          UnsubscribeSubmit();
        });
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
      subscribeHandle.Unsubscribe();
      await view.HideAsync(isImmediately, token);
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    #region Subscribes
    private void SubscribeSubmit()
    {
      var direction = model.inputDirectionType.ParseToDirection();

      view.quitProgressSubmitView.ResetAllProgress();
      view.quitProgressSubmitView.SubscribeOnProgress(direction, view.fillImageView.SetFillAmount);
      view.quitProgressSubmitView.SubscribeOnCanceled(direction, () => view.fillImageView.SetFillAmount(0.0f));
      view.quitProgressSubmitView.SubscribeOnComplete(direction, () => model.onQuit?.Invoke());
    }

    private void UnsubscribeSubmit()
    {
      view.quitProgressSubmitView.Cancel(model.inputDirectionType.ParseToDirection());
      view.quitProgressSubmitView.UnsubscribeAll();

      view.fillImageView.SetFillAmount(0.0f);
    }

    private void SubscribeInputAction()
    {     
      model.uiInputActionManager.SubscribePerformedEvent(model.inputDirectionType, OnInputLeftPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(model.inputDirectionType, OnInputLeftCanceled);
    }

    private void UnsubscribeInputAction()
    {     
      model.uiInputActionManager.UnsubscribePerformedEvent(model.inputDirectionType, OnInputLeftPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(model.inputDirectionType, OnInputLeftCanceled);
    }

    private void OnInputLeftPerformed()
      => view.quitProgressSubmitView.Perform(model.inputDirectionType.ParseToDirection());

    private void OnInputLeftCanceled()
      => view.quitProgressSubmitView.Cancel(model.inputDirectionType.ParseToDirection());
    #endregion
  }
}