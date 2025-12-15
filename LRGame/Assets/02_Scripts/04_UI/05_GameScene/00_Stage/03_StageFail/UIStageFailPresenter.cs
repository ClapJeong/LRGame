using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

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
      public IStageStateHandler stageService;
      public ISceneProvider sceneProvider;

      public Model(IUIInputActionManager uiInputActionManager, IUIIndicatorService indicatorService, IStageStateHandler stageService, ISceneProvider sceneProvider)
      {
        this.uiInputActionManager = uiInputActionManager;
        this.indicatorService = indicatorService;
        this.stageService = stageService;
        this.sceneProvider = sceneProvider;
      }
    }

    private static readonly UIInputDirectionType QuitEnterInputType = UIInputDirectionType.LeftLeft;
    private static readonly UIInputDirectionType QuitPressInputType = UIInputDirectionType.RightLeft;
    private static readonly UIInputDirectionType RestartEnterInputType = UIInputDirectionType.LeftRight;
    private static readonly UIInputDirectionType RestartPressInputType = UIInputDirectionType.RightRight;

    private readonly Model model;
    private readonly UIStageFailView view;    

    private SubscribeHandle subscribeHandle;
    private ButtonState currentButtonState;
    private IUIIndicatorPresenter currentIndicator;

    public UIStageFailPresenter(Model model, UIStageFailView view)
    {
      this.model = model;
      this.view = view;

      CreateSubscribeHandle();
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await GetNewIndicatorAsync();
      subscribeHandle.Subscribe();
      SetState(ButtonState.None);      
      await view.ShowAsync(isImmediately, token);
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      if (currentIndicator != null)
        ReleaseIndicator();
      subscribeHandle.Unsubscribe();
      await view.HideAsync(isImmediately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    public void Dispose()
    {
      if (currentIndicator != null)
        ReleaseIndicator();

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
            view.quitBackgroundImageView.SetAlpha(0.4f);
            view.quitProgressSubmitView.Cancel(QuitPressInputType.ParseToDirection());
          }          
          break;

        case ButtonState.Restart:
          {
            view.restartBackgroundImageView.SetAlpha(0.4f);
            view.restartProgressSubmitView.Cancel(RestartPressInputType.ParseToDirection());
          }          
          break;
      }

      currentButtonState = state;
      var topIndicator = model.indicatorService.GetTopIndicator();
      switch (currentButtonState)
      {
        case ButtonState.None:
          {
            topIndicator.MoveAsync(view.noneRectView).Forget();
            topIndicator.SetLeftGuide(new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>
            {
              { QuitEnterInputType.ParseToDirection(), Indicator.IUIIndicatorPresenter.LeftGuideType.Movable },
              { RestartEnterInputType.ParseToDirection(), Indicator.IUIIndicatorPresenter.LeftGuideType.Movable }
            });
            topIndicator.SetRightGuide();
          }          
          break;

        case ButtonState.Quit:
          {
            view.quitBackgroundImageView.SetAlpha(1.0f);
            topIndicator.MoveAsync(view.quitRectView).Forget();
            topIndicator.SetLeftGuide(new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>
            {
              { QuitEnterInputType.ParseToDirection().ParseOpposite(), Indicator.IUIIndicatorPresenter.LeftGuideType.Clamped },
            });
            topIndicator.SetRightGuide(QuitEnterInputType.ParseToDirection());
          }          
          break;

        case ButtonState.Restart:
          {
            view.restartBackgroundImageView.SetAlpha(1.0f);
            topIndicator.MoveAsync(view.restartRectView).Forget();
            topIndicator.SetLeftGuide(new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>
            {
              { RestartEnterInputType.ParseToDirection().ParseOpposite(), Indicator.IUIIndicatorPresenter.LeftGuideType.Clamped },
            });
            topIndicator.SetRightGuide(RestartPressInputType.ParseToDirection());
          }          
          break;
      }
    }

    private bool IsCurrentState(ButtonState state)
      => currentButtonState == state;
    #endregion

    private async UniTask GetNewIndicatorAsync()
    {
      currentIndicator = await model.indicatorService.GetNewAsync(view.indicatorRoot, view.noneRectView);
    }

    private void ReleaseIndicator()
    {
      model.indicatorService.ReleaseTopIndicator();
      currentIndicator = null;
    }

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

      view.quitProgressSubmitView.Cancel(QuitPressInputType.ParseToDirection());
      SetState(ButtonState.None);
    }

    private void OnQuitButtonPerformed()
    {
      if (IsCurrentState(ButtonState.Quit) == false)
        return;

      view.quitProgressSubmitView.Perform(QuitPressInputType.ParseToDirection());
    }

    private void OnQuitButtonCanceled()
    {
      if (IsCurrentState(ButtonState.Quit) == false)
        return;

      view.quitProgressSubmitView.Cancel(QuitPressInputType.ParseToDirection());
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

      view.restartProgressSubmitView.Cancel(RestartPressInputType.ParseToDirection());
      SetState(ButtonState.None);
    }

    private void OnRestartPerformed()
    {
      if (IsCurrentState(ButtonState.Restart) == false)
        return;

      view.restartProgressSubmitView.Perform(RestartPressInputType.ParseToDirection());
    }

    private void OnRestartCanceled()
    {
      if (IsCurrentState(ButtonState.Restart) == false)
        return;

      view.restartProgressSubmitView.Cancel(RestartPressInputType.ParseToDirection());
    }
    #endregion

    #region ProgressSubmits
    private void SubscribeSubmits()
    {
      var quitPressDirection = QuitPressInputType.ParseToDirection();
      view.quitProgressSubmitView.SubscribeOnProgress(quitPressDirection, view.quitFillImageView.SetFillAmount);
      view.quitProgressSubmitView.SubscribeOnCanceled(quitPressDirection, () => view.quitFillImageView.SetFillAmount(0.0f));
      view.quitProgressSubmitView.SubscribeOnComplete(quitPressDirection, () =>
      {
        Dispose();
        model.sceneProvider.LoadSceneAsync(SceneType.Lobby);
      });

      var restartDirection = RestartPressInputType.ParseToDirection();
      view.restartProgressSubmitView.SubscribeOnProgress(restartDirection, view.restartFillImageView.SetFillAmount);
      view.restartProgressSubmitView.SubscribeOnCanceled(restartDirection, () => view.restartFillImageView.SetFillAmount(0.0f));
      view.restartProgressSubmitView.SubscribeOnComplete(restartDirection, () =>
      {
        DeactivateAsync().Forget();
        model.stageService.RestartAsync().Forget();
      });
    }

    private void UnsubscribeSubmits()
    {
      view.quitProgressSubmitView.UnsubscribeAll();
      view.restartProgressSubmitView.UnsubscribeAll();
    }
    #endregion
  }
}