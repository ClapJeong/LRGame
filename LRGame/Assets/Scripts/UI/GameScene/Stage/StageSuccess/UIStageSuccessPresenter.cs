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
      public IStageService stageService;
      public ISceneProvider sceneProvider;

      public Model(IGameDataService gameDataService, IUIInputActionManager uiInputActionManager, IUIIndicatorService indicatorService, IStageService stageService, ISceneProvider sceneProvider)
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
    private readonly UIStageSuccessViewContainer viewContainer;

    private BaseButtonPresenter quitButtonPresenter;
    private CenterButtonPresenter restartButtonPresenter;
    private BaseButtonPresenter nextButtonPresenter;

    private ButtonState currentState;
    private UIVisibleState visibleState;
    private SubscribeHandle subscribeHandle;

    public UIStageSuccessPresenter(Model model, UIStageSuccessViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      CreateQuitPresenter();
      CreateRestartPresenter();
      CreateNextPresenter();
      CreateSubscribeHandle();

      viewContainer.gameObjectView.SetActive(false);
      visibleState = UIVisibleState.Hided;
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }

    public UIVisibleState GetVisibleState()
      =>visibleState;

    public async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Unsubscribe();
      viewContainer.gameObjectView.SetActive(false);
      visibleState = UIVisibleState.Hided;
      await UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await model.indicatorService.GetNewAsync(viewContainer.indicatorRoot, viewContainer.restartViewContainer.rectView);
      subscribeHandle.Subscribe();
      viewContainer.gameObjectView.SetActive(true);
      SetState(ButtonState.Restart);
      visibleState = UIVisibleState.Showed;
    }

    private void SetState(ButtonState state)
    {
      var prevState = currentState;
      switch (prevState)
      {
        case ButtonState.Restart:
          restartButtonPresenter.HideAsync().Forget();
          break;

        case ButtonState.Quit:
          quitButtonPresenter.HideAsync().Forget();
          break;

        case ButtonState.Next:
          nextButtonPresenter.HideAsync().Forget();
          break;
      }

      var topIndicator = model.indicatorService.GetTopIndicator();
      currentState = state;
      switch (currentState)
      {
        case ButtonState.Restart:
          {
            restartButtonPresenter.ShowAsync().Forget();
            topIndicator.MoveAsync(viewContainer.restartViewContainer.rectView).Forget();
            topIndicator.SetLeftGuide(new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>
            {
              { QuitEnterDirection.ParseToDirection(), Indicator.IUIIndicatorPresenter.LeftGuideType.Movable },
              { NextEnterDirection.ParseToDirection(), Indicator.IUIIndicatorPresenter.LeftGuideType.Movable },
            });
            topIndicator.SetRightGuide(RestartPressDirection.ParseToDirection());
          }
          break;

        case ButtonState.Quit:
          {
            quitButtonPresenter.ShowAsync().Forget();
            topIndicator.MoveAsync(viewContainer.quitViewContainer.rectView).Forget();
            topIndicator.SetLeftGuide(new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>
            {
              { QuitEnterDirection.ParseToDirection().ParseOpposite(), Indicator.IUIIndicatorPresenter.LeftGuideType.Clamped },
            });
            topIndicator.SetRightGuide(QuitPressDirection.ParseToDirection());
          }
          break;

        case ButtonState.Next:
          {
            nextButtonPresenter.ShowAsync().Forget();
            topIndicator.MoveAsync(viewContainer.nextViewContainer.rectView).Forget();
            topIndicator.SetLeftGuide(new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>
            {
              { NextEnterDirection.ParseToDirection().ParseOpposite(), Indicator.IUIIndicatorPresenter.LeftGuideType.Clamped },
            });
            topIndicator.SetRightGuide(NextPressDirection.ParseToDirection());
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
      var view = viewContainer.quitViewContainer;
      quitButtonPresenter = new BaseButtonPresenter(model, view);
      quitButtonPresenter.AttachOnDestroy(viewContainer.gameObject);
      quitButtonPresenter.HideAsync().Forget();
    }

    private void CreateRestartPresenter()
    {
      var model = new CenterButtonPresenter.Model(
        inputDirectionType: RestartPressDirection,
        uiInputActionManager: this.model.uiInputActionManager,
        onSubmit: () =>
        {
          this.model.stageService.RestartAsync().Forget();
          HideAsync().Forget();
        });
      var view = viewContainer.restartViewContainer;
      restartButtonPresenter = new CenterButtonPresenter(model, view);
      restartButtonPresenter.AttachOnDestroy(viewContainer.gameObject);
      restartButtonPresenter.HideAsync().Forget();
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
      var view = viewContainer.nextViewContainer;
      nextButtonPresenter = new BaseButtonPresenter(model, view);
      nextButtonPresenter.AttachOnDestroy(viewContainer.gameObject);
      nextButtonPresenter.HideAsync().Forget();
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
          model.indicatorService.ReleaseTopIndicator();

          model.uiInputActionManager.UnsubscribePerformedEvent(QuitEnterDirection, OnQuitButtonEnter);
          model.uiInputActionManager.UnsubscribeCanceledEvent(QuitEnterDirection, OnQuitButtonExit);

          model.uiInputActionManager.UnsubscribePerformedEvent(NextEnterDirection, OnNextButtonEnter);
          model.uiInputActionManager.UnsubscribeCanceledEvent(NextEnterDirection, OnNextButtonExit);

          quitButtonPresenter.HideAsync().Forget();
          restartButtonPresenter.HideAsync().Forget();
          nextButtonPresenter.HideAsync().Forget();
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