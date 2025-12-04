using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.GameScene.Stage
{
  public class UIStageFailPresenter : IUIPresenter
  {
    private enum ButtonState
    {
      None,
      Quit,
      Restart,
    }
    public class Model
    {
      public IUIInputActionManager uiInputActionManager;
      public IUIIndicatorService indicatorService;
      public IStageService stageService;
      public ISceneProvider sceneProvider;

      public Model(IUIInputActionManager uiInputActionManager, IUIIndicatorService indicatorService, IStageService stageService, ISceneProvider sceneProvider)
      {
        this.uiInputActionManager = uiInputActionManager;
        this.indicatorService = indicatorService;
        this.stageService = stageService;
        this.sceneProvider = sceneProvider;
      }
    }

    private static readonly UIInputActionType QuitEnterInputType = UIInputActionType.LeftLeft;
    private static readonly UIInputActionType QuitPressInputType = UIInputActionType.RightLeft;
    private static readonly UIInputActionType RestartEnterInputType = UIInputActionType.LeftRight;
    private static readonly UIInputActionType RestartPressInputType = UIInputActionType.RightRight;

    private readonly Model model;
    private readonly UIStageFailViewContainer viewContainer;    

    private UIVisibleState visibleState;
    private SubscribeHandle subscribeHandle;
    private ButtonState currentButtonState;

    public UIStageFailPresenter(Model model, UIStageFailViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      viewContainer.gameObjectView.SetActive(false);
      visibleState = UIVisibleState.Hided;
      CreateSubscribeHandle();
    }

    public async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      viewContainer.quitBackgroundImageView.SetAlpha(0.4f);
      viewContainer.restartBackgroundImageView.SetAlpha(0.4f);
      await model.indicatorService.GetNewAsync(viewContainer.indicatorRoot, viewContainer.noneRectView);
      subscribeHandle.Subscribe();
      visibleState = UIVisibleState.Showed;
      viewContainer.gameObjectView.SetActive(true);
      await UniTask.CompletedTask;
    }

    public async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Unsubscribe();
      viewContainer.gameObjectView.SetActive(false);
      visibleState = UIVisibleState.Hided;
      await UniTask.CompletedTask;
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public UIVisibleState GetVisibleState()
      => visibleState;

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }

    #region State
    private void SetState(ButtonState state)
    {
      var prevState = currentButtonState;
      switch (prevState)
      {
        case ButtonState.None:
          break;

        case ButtonState.Quit:
          {
            viewContainer.quitBackgroundImageView.SetAlpha(0.4f);
            viewContainer.quitProgressSubmitView.Cancel(QuitPressInputType.ParseToDirection());
          }          
          break;

        case ButtonState.Restart:
          {
            viewContainer.restartBackgroundImageView.SetAlpha(0.4f);
            viewContainer.restartProgressSubmitView.Cancel(RestartPressInputType.ParseToDirection());
          }          
          break;
      }

      currentButtonState = state;
      switch (currentButtonState)
      {
        case ButtonState.None:
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.noneRectView).Forget();
          break;

        case ButtonState.Quit:
          {
            viewContainer.quitBackgroundImageView.SetAlpha(1.0f);
            model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.quitRectView).Forget();
          }          
          break;

        case ButtonState.Restart:
          {
            viewContainer.restartBackgroundImageView.SetAlpha(1.0f);
            model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.restartRectView).Forget();
          }          
          break;
      }
    }

    private bool IsCurrentState(ButtonState state)
      => currentButtonState == state;
    #endregion

    private void CreateSubscribeHandle()
    {
      subscribeHandle = new(
        onSubscribe: () =>
        {
          SubscribeInputActions();
          SubscribeSubmits();
        },
        onUnsubscribe: () =>
        {
          UnsubscribeInputActions();
          UnsubscribeSubmits();
        });
    }

    #region InputActions
    private void SubscribeInputActions()
    {
      model.uiInputActionManager.SubscribePerformedEvent(QuitEnterInputType, OnQuitButtonEnter);
      model.uiInputActionManager.SubscribeCanceledEvent(QuitEnterInputType, OnQuitButtonExit);

      model.uiInputActionManager.SubscribePerformedEvent(QuitPressInputType, OnQuitButtonPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(QuitPressInputType, OnQuitButtonCanceled);

      model.uiInputActionManager.SubscribePerformedEvent(RestartEnterInputType, OnRestartEnter);
      model.uiInputActionManager.SubscribeCanceledEvent(RestartEnterInputType, OnRestartExit);

      model.uiInputActionManager.SubscribePerformedEvent(RestartPressInputType, OnRestartPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(RestartPressInputType, OnRestartCanceled);
    }

    private void UnsubscribeInputActions()
    {
      model.uiInputActionManager.UnsubscribePerformedEvent(QuitEnterInputType, OnQuitButtonEnter);
      model.uiInputActionManager.UnsubscribeCanceledEvent(QuitEnterInputType, OnQuitButtonExit);

      model.uiInputActionManager.UnsubscribePerformedEvent(QuitPressInputType, OnQuitButtonPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(QuitPressInputType, OnQuitButtonCanceled);

      model.uiInputActionManager.UnsubscribePerformedEvent(RestartEnterInputType, OnRestartEnter);
      model.uiInputActionManager.UnsubscribeCanceledEvent(RestartEnterInputType, OnRestartExit);

      model.uiInputActionManager.UnsubscribePerformedEvent(RestartPressInputType, OnRestartPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(RestartPressInputType, OnRestartCanceled);
    }

    private void OnQuitButtonEnter()
    {
      if (IsCurrentState(ButtonState.None) == false)
        return;

      SetState(ButtonState.Quit);
    }

    private void OnQuitButtonExit()
    {
      if (IsCurrentState(ButtonState.Quit) == false)
        return;

      viewContainer.quitProgressSubmitView.Cancel(QuitPressInputType.ParseToDirection());
      SetState(ButtonState.None);
    }

    private void OnQuitButtonPerformed()
    {
      if (IsCurrentState(ButtonState.Quit) == false)
        return;

      viewContainer.quitProgressSubmitView.Perform(QuitPressInputType.ParseToDirection());
    }

    private void OnQuitButtonCanceled()
    {
      if (IsCurrentState(ButtonState.Quit) == false)
        return;

      viewContainer.quitProgressSubmitView.Cancel(QuitPressInputType.ParseToDirection());
    }

    private void OnRestartEnter()
    {
      if (IsCurrentState(ButtonState.None) == false)
        return;

      SetState(ButtonState.Restart);
    }

    private void OnRestartExit()
    {
      if (IsCurrentState(ButtonState.Restart) == false)
        return;

      viewContainer.restartProgressSubmitView.Cancel(RestartPressInputType.ParseToDirection());
      SetState(ButtonState.None);
    }

    private void OnRestartPerformed()
    {
      if (IsCurrentState(ButtonState.Restart) == false)
        return;

      viewContainer.restartProgressSubmitView.Perform(RestartPressInputType.ParseToDirection());
    }

    private void OnRestartCanceled()
    {
      if (IsCurrentState(ButtonState.Restart) == false)
        return;
      viewContainer.restartProgressSubmitView.Cancel(RestartPressInputType.ParseToDirection());
    }
    #endregion

    #region ProgressSubmits
    private void SubscribeSubmits()
    {
      var quitPressDirection = QuitPressInputType.ParseToDirection();
      viewContainer.quitProgressSubmitView.SubscribeOnProgress(quitPressDirection, viewContainer.quitFillImageView.SetFillAmount);
      viewContainer.quitProgressSubmitView.SubscribeOnCanceled(quitPressDirection, () => viewContainer.quitFillImageView.SetFillAmount(0.0f));
      viewContainer.quitProgressSubmitView.SubscribeOnComplete(quitPressDirection, () =>
      {
        model.sceneProvider.LoadSceneAsync(SceneType.Lobby);
      });

      var restartDirection = RestartPressInputType.ParseToDirection();
      viewContainer.restartProgressSubmitView.SubscribeOnProgress(restartDirection, viewContainer.restartFillImageView.SetFillAmount);
      viewContainer.restartProgressSubmitView.SubscribeOnCanceled(restartDirection, () => viewContainer.restartFillImageView.SetFillAmount(0.0f));
      viewContainer.restartProgressSubmitView.SubscribeOnComplete(restartDirection, () =>
      {
        HideAsync().Forget();
        model.stageService.RestartAsync().Forget();
      });
    }

    private void UnsubscribeSubmits()
    {
      viewContainer.quitProgressSubmitView.UnsubscribeAll();
      viewContainer.restartProgressSubmitView.UnsubscribeAll();
    }
    #endregion
  }
}