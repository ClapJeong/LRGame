using Cysharp.Threading.Tasks;
using LR.UI.GameScene.Stage.SuccessPanel;
using LR.UI.Indicator;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStageSuccessPresenter : IUIPresenter
  {
    private enum ButtonState
    {
      Restart,
      Quit,
      Next,
    }

    public class Model
    {
      public IGameDataService gameDataService;
      public IUIInputActionManager uiInputActionManager;
      public IUIIndicatorService indicatorService;
      public IStageStateHandler stageService;
      public ISceneProvider sceneProvider;

      public Model(IGameDataService gameDataService, IUIInputActionManager uiInputActionManager, IUIIndicatorService indicatorService, IStageStateHandler stageService, ISceneProvider sceneProvider)
      {
        this.gameDataService = gameDataService;
        this.uiInputActionManager = uiInputActionManager;
        this.indicatorService = indicatorService;
        this.stageService = stageService;
        this.sceneProvider = sceneProvider;
      }
    }

    private static readonly UIInputDirectionType QuitEnterDirection = UIInputDirectionType.LeftLeft;
    private static readonly UIInputDirectionType NextEnterDirection = UIInputDirectionType.LeftRight;

    private static readonly UIInputDirectionType QuitPressDirection = UIInputDirectionType.RightLeft;
    private static readonly UIInputDirectionType NextPressDirection = UIInputDirectionType.RightRight;
    private static readonly UIInputDirectionType RestartPressDirection = UIInputDirectionType.Space;

    private readonly Model model;
    private readonly UIStageSuccessView view;

    private BaseButtonPresenter quitButtonPresenter;
    private CenterButtonPresenter restartButtonPresenter;
    private BaseButtonPresenter nextButtonPresenter;

    private ButtonState currentState;
    private SubscribeHandle subscribeHandle;
    private IUIIndicatorPresenter currentIndicator;

    public UIStageSuccessPresenter(Model model, UIStageSuccessView view)
    {
      this.model = model;
      this.view = view;

      CreateQuitPresenter();
      CreateRestartPresenter();
      CreateNextPresenter();

      quitButtonPresenter.DeactivateAsync().Forget();
      restartButtonPresenter.DeactivateAsync().Forget();
      nextButtonPresenter.DeactivateAsync().Forget();

      CreateSubscribeHandle();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if (currentIndicator != null)
        ReleaseIndicator();

      subscribeHandle.Dispose();
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      if(currentIndicator != null)
      ReleaseIndicator();
      subscribeHandle.Unsubscribe();
      await view.HideAsync(isImmediately, token);
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await GetNewIndicatorAsync();
      subscribeHandle.Subscribe();
      SetState(ButtonState.Restart);
      await view.ShowAsync(isImmediately, token);
    }

    private async UniTask GetNewIndicatorAsync()
    {
      currentIndicator = await model.indicatorService.GetNewAsync(view.indicatorRoot, view.restartView.RectTransform);
    }

    private void ReleaseIndicator()
    {
      model.indicatorService.ReleaseTopIndicator();
      currentIndicator = null;
    }

    private void SetState(ButtonState state)
    {
      var prevState = currentState;
      switch (prevState)
      {
        case ButtonState.Restart:
          restartButtonPresenter.DeactivateAsync().Forget();
          break;

        case ButtonState.Quit:
          quitButtonPresenter.DeactivateAsync().Forget();
          break;

        case ButtonState.Next:
          nextButtonPresenter.DeactivateAsync().Forget();
          break;
      }

      var topIndicator = model.indicatorService.GetTopIndicator();
      currentState = state;
      switch (currentState)
      {
        case ButtonState.Restart:
          {
            restartButtonPresenter.ActivateAsync().Forget();
            topIndicator.MoveAsync(view.restartView.RectTransform).Forget();
            topIndicator.SetLeftInputGuide(new Dictionary<Direction, IUIIndicatorPresenter.LeftInputGuideType>
            {
              { QuitEnterDirection.ParseToDirection(), Indicator.IUIIndicatorPresenter.LeftInputGuideType.Movable },
              { NextEnterDirection.ParseToDirection(), Indicator.IUIIndicatorPresenter.LeftInputGuideType.Movable },
            });
            topIndicator.SetRightInputGuide(RestartPressDirection.ParseToDirection());
          }
          break;

        case ButtonState.Quit:
          {
            quitButtonPresenter.ActivateAsync().Forget();
            topIndicator.MoveAsync(view.quitView.RectTransform).Forget();
            topIndicator.SetLeftInputGuide(new Dictionary<Direction, IUIIndicatorPresenter.LeftInputGuideType>
            {
              { QuitEnterDirection.ParseToDirection().ParseOpposite(), Indicator.IUIIndicatorPresenter.LeftInputGuideType.Clamped },
            });
            topIndicator.SetRightInputGuide(QuitPressDirection.ParseToDirection());
          }
          break;

        case ButtonState.Next:
          {
            nextButtonPresenter.ActivateAsync().Forget();
            topIndicator.MoveAsync(view.nextView.RectTransform).Forget();
            topIndicator.SetLeftInputGuide(new Dictionary<Direction, IUIIndicatorPresenter.LeftInputGuideType>
            {
              { NextEnterDirection.ParseToDirection().ParseOpposite(), Indicator.IUIIndicatorPresenter.LeftInputGuideType.Clamped },
            });
            topIndicator.SetRightInputGuide(NextPressDirection.ParseToDirection());
          }
          break;
      }
    }

    private void CreateQuitPresenter()
    {
      var model = new BaseButtonPresenter.Model(
        inputDirectionType: QuitPressDirection,
        uiInputActionManager: this.model.uiInputActionManager,
        onSubmit: () =>
        {
          Dispose();
          this.model.sceneProvider.LoadSceneAsync(SceneType.Lobby).Forget();
        });
      var view = this.view.quitView;
      quitButtonPresenter = new BaseButtonPresenter(model, view);
      quitButtonPresenter.AttachOnDestroy(this.view.gameObject);
    }

    private void CreateRestartPresenter()
    {
      var model = new CenterButtonPresenter.Model(
        inputDirectionType: RestartPressDirection,
        uiInputActionManager: this.model.uiInputActionManager,
        onSubmit: () =>
        {
          this.model.stageService.RestartAsync().Forget();
          DeactivateAsync().Forget();
        });
      var view = this.view.restartView;
      restartButtonPresenter = new CenterButtonPresenter(model, view);
      restartButtonPresenter.AttachOnDestroy(this.view.gameObject);
    }

    private void CreateNextPresenter()
    {
      var model = new BaseButtonPresenter.Model(
        inputDirectionType: NextPressDirection,
        uiInputActionManager: this.model.uiInputActionManager,
        onSubmit: () =>
        {
          this.model.gameDataService.GetSelectedStage(out var chapter, out var stage);
          stage++;
          if(stage == 4)
          {
            chapter++;
            stage = 0;
          }
          this.model.gameDataService.SetSelectedStage(chapter, stage);

          this.model.sceneProvider.ReloadCurrentSceneAsync().Forget();
        });
      var view = this.view.nextView;
      nextButtonPresenter = new BaseButtonPresenter(model, view);
      nextButtonPresenter.AttachOnDestroy(this.view.gameObject);
    }

    #region Subscribes
    private void CreateSubscribeHandle()
    {
      subscribeHandle = new(
        onSubscribe: () =>
        {
          model.uiInputActionManager.SubscribePerformedEvent(QuitEnterDirection, OnQuitButtonEnter);
          model.uiInputActionManager.SubscribeCanceledEvent(QuitEnterDirection, OnQuitButtonExit);

          model.uiInputActionManager.SubscribePerformedEvent(NextEnterDirection, OnNextButtonEnter);
          model.uiInputActionManager.SubscribeCanceledEvent(NextEnterDirection, OnNextButtonExit);
        },
        onUnsubscribe: () =>
        {         
          model.uiInputActionManager.UnsubscribePerformedEvent(QuitEnterDirection, OnQuitButtonEnter);
          model.uiInputActionManager.UnsubscribeCanceledEvent(QuitEnterDirection, OnQuitButtonExit);

          model.uiInputActionManager.UnsubscribePerformedEvent(NextEnterDirection, OnNextButtonEnter);
          model.uiInputActionManager.UnsubscribeCanceledEvent(NextEnterDirection, OnNextButtonExit);

          quitButtonPresenter.DeactivateAsync().Forget();
          restartButtonPresenter.DeactivateAsync().Forget();
          nextButtonPresenter.DeactivateAsync().Forget();
        });
    }

    private void OnQuitButtonEnter()
    {
      if (IsState(ButtonState.Restart) == false)
        return;

      SetState(ButtonState.Quit);
    }

    private void OnQuitButtonExit()
    {
      if (IsState(ButtonState.Quit) == false)
        return;

      SetState(ButtonState.Restart);
    }

    private void OnNextButtonEnter()
    {
      if (IsState(ButtonState.Restart) == false ||
          IsNextStageExist() == false)
        return;

      SetState(ButtonState.Next);
    }

    private void OnNextButtonExit()
    {
      if (IsState(ButtonState.Next) == false ||
                IsNextStageExist() == false)
        return;

      SetState(ButtonState.Restart);
    }
    #endregion

    private bool IsState(ButtonState state)
      => currentState == state;

    private bool IsNextStageExist()
    {
      model.gameDataService.GetSelectedStage(out var chapter, out var stage);
      
      stage++;
      if(stage == 4)
      {
        chapter++;
        stage = 0;
      }

      return model.gameDataService.IsStageExist(chapter, stage);
    }
  }
}