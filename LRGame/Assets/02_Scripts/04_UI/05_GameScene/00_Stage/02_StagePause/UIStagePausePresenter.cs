using Cysharp.Threading.Tasks;
using LR.UI.GameScene.Stage.PausePanel;
using LR.UI.Indicator;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
namespace LR.UI.GameScene.Stage
{
  public class UIStagePausePresenter : IUIPresenter
  {
    private enum SelectingState
    {
      None,
      Resume,
      Restart,
      Quit,
    }

    public class Model
    {
      public IUIInputActionManager uiInputActionManager;
      public IUIIndicatorService indicatorService;
      public ISceneProvider sceneProvider;
      public IStageStateHandler stageService;

      public Model(IUIInputActionManager uiInputActionManager, IUIIndicatorService indicatorService, ISceneProvider sceneProvider, IStageStateHandler stageService)
      {
        this.uiInputActionManager = uiInputActionManager;
        this.indicatorService = indicatorService;
        this.sceneProvider = sceneProvider;
        this.stageService = stageService;
      }
    }

    private static readonly List<UIInputDirectionType> QuitButtonEnterDirectionTypes = new()
    {
      UIInputDirectionType.LeftUp,
      UIInputDirectionType.LeftDown,
    };

    private static readonly List<UIInputDirectionType> RestartButtonEnterDirectionTypes = new()
    {
      UIInputDirectionType.LeftRight,
      UIInputDirectionType.LeftLeft,
    };

    private static readonly UIInputDirectionType RestartMinDirection = UIInputDirectionType.RightRight;
    private static readonly UIInputDirectionType RestartMaxDirection = UIInputDirectionType.RightLeft;

    private static readonly UIInputDirectionType QuitMinDirection = UIInputDirectionType.RightUP;
    private static readonly UIInputDirectionType QuitMaxDirection = UIInputDirectionType.RightDown;

    private readonly Model model;
    private readonly UIStagePauseView view;    

    private ResumeButtonPresenter resumePresenter;
    private BaseButtonPresenter restartPresenter;
    private BaseButtonPresenter quitPresenter;

    private SelectingState currentState;
    private SubscribeHandle subscribeHandle;
    private IUIIndicatorPresenter currentIndicator;

    public UIStagePausePresenter(Model model, UIStagePauseView view)
    {
      this.view = view;
      this.model = model;

      CreateSubscribeHandle();

      CreateResumePresenter();
      CreateQuitPresenter();
      CreateRestartPresenter();

      resumePresenter.DeactivateAsync().Forget();
      restartPresenter.DeactivateAsync().Forget();
      quitPresenter.DeactivateAsync().Forget();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if (currentIndicator != null)
        ReleaseIndicator();

      subscribeHandle.Dispose();
      if (view)
        view.DestroySelf();
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await GetNewIndicatorAsync();
      model.stageService.Pause();      
      subscribeHandle.Subscribe();
      SetState(SelectingState.Resume);
      await view.ShowAsync(isImmediately, token);
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      if(currentIndicator != null)
        ReleaseIndicator();
      SetState(SelectingState.None);
      subscribeHandle.Unsubscribe();      
      await view.HideAsync(isImmediately, token);
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    private void CreateSubscribeHandle()
    {
      subscribeHandle = new SubscribeHandle(SubscribeInputActions, UnsubscribeInputActions);
    }

    private void SetState(SelectingState selectingType)
    {
      var prevState = currentState;
      switch (prevState)
      {
        case SelectingState.None:break;

        case SelectingState.Resume:
          resumePresenter.DeactivateAsync().Forget();
          break;

        case SelectingState.Restart:
          restartPresenter.DeactivateAsync().Forget();
          break;

        case SelectingState.Quit:
          quitPresenter.DeactivateAsync().Forget();
          break;
      }

      if (model.indicatorService.TryGetTopIndicator(out var topIndicator) == false)
        return;
      
      currentState = selectingType;
      switch (currentState)
      {
        case SelectingState.None:
          {
            topIndicator.SetLeftGuide(null);
            topIndicator.SetRightGuide();
          }
          break;

        case SelectingState.Resume:
          {
            resumePresenter.ActivateAsync().Forget();
            
            var leftGuide = new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>();
            foreach (var directionType in QuitButtonEnterDirectionTypes)
              leftGuide.Add(directionType.ParseToDirection(), IUIIndicatorPresenter.LeftGuideType.Movable);
            foreach (var directionType in RestartButtonEnterDirectionTypes)
              leftGuide.Add(directionType.ParseToDirection(), IUIIndicatorPresenter.LeftGuideType.Movable);

            topIndicator.MoveAsync(view.resumeButtonViewContainer.rectView)
              .ContinueWith(() =>
              {
                topIndicator.SetLeftGuide(leftGuide);
                topIndicator.SetRightGuide(Direction.Space);
              }).Forget();
          }          
          break;

        case SelectingState.Restart:
          {
            restartPresenter.ActivateAsync().Forget();
            var leftGuide = new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>();
            foreach (var directionType in RestartButtonEnterDirectionTypes)
              leftGuide.Add(directionType.ParseToDirection().ParseOpposite(), IUIIndicatorPresenter.LeftGuideType.Clamped);

            topIndicator.MoveAsync(view.restartButtonViewContainer.baseRectView)
              .ContinueWith(() =>
              {
                topIndicator.SetLeftGuide(leftGuide);
                topIndicator.SetRightGuide(RestartMinDirection.ParseToDirection(), RestartMaxDirection.ParseToDirection());
              })
              .Forget();            
          }
          break;

        case SelectingState.Quit:
          {
            quitPresenter.ActivateAsync().Forget();
            var leftGuide = new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>();
            foreach (var directionType in QuitButtonEnterDirectionTypes)
              leftGuide.Add(directionType.ParseToDirection().ParseOpposite(), IUIIndicatorPresenter.LeftGuideType.Clamped);

            topIndicator.MoveAsync(view.quitButtonViewContainer.baseRectView)
              .ContinueWith(() =>
              {
                topIndicator.SetLeftGuide(leftGuide);
                topIndicator.SetRightGuide(QuitMinDirection.ParseToDirection(), QuitMaxDirection.ParseToDirection());
              })
              .Forget();            
          }          
          break;
      }
    }

    private void CreateResumePresenter()
    {
      var model = new ResumeButtonPresenter.Model(
        inputDirectionType: UIInputDirectionType.Space,
        onSubmit: () =>
        {
          this.model.stageService.Resume();
          DeactivateAsync().Forget();          
        },
        uiInputActionManager: this.model.uiInputActionManager);
      var view = this.view.resumeButtonViewContainer;
      resumePresenter = new ResumeButtonPresenter(model, view);
      resumePresenter.AttachOnDestroy(this.view.gameObject);
    }

    private void CreateRestartPresenter()
    {
      var model = new BaseButtonPresenter.Model(
        mininputDirectionType: RestartMinDirection,
        maxinputDirectionType: RestartMaxDirection,
        onSubmit: () =>
        {
          this.model.stageService.RestartAsync().Forget();
          DeactivateAsync().Forget();
        },
        uiInputActionManager: this.model.uiInputActionManager);
      var view = this.view.restartButtonViewContainer;
      restartPresenter = new BaseButtonPresenter(model, view);
      restartPresenter.AttachOnDestroy(this.view.gameObject);
    }

    private void CreateQuitPresenter() 
    {
      var model = new BaseButtonPresenter.Model(
        mininputDirectionType: QuitMinDirection,
        maxinputDirectionType: QuitMaxDirection,
        onSubmit: () =>
        {
          Dispose();
          this.model.sceneProvider.LoadSceneAsync(SceneType.Lobby).Forget();
        },
        uiInputActionManager: this.model.uiInputActionManager);
      var view = this.view.quitButtonViewContainer;
      quitPresenter = new BaseButtonPresenter(model, view);
      quitPresenter.AttachOnDestroy(this.view.gameObject);
    }

    private async UniTask GetNewIndicatorAsync()
    {
      currentIndicator = await model.indicatorService.GetNewAsync(view.IndicatorRoot, view.resumeButtonViewContainer.rectView);
    }

    private void ReleaseIndicator()
    {      
      model.indicatorService.ReleaseTopIndicator();
      currentIndicator = null;
    }

    #region Subscribes
    private void SubscribeInputActions()
    {
      model.uiInputActionManager.SubscribePerformedEvent(QuitButtonEnterDirectionTypes, OnQuitButtonEnter);
      model.uiInputActionManager.SubscribeCanceledEvent(QuitButtonEnterDirectionTypes, OnQuitButtonExit);

      model.uiInputActionManager.SubscribePerformedEvent(RestartButtonEnterDirectionTypes, OnRestartEnter);
      model.uiInputActionManager.SubscribeCanceledEvent(RestartButtonEnterDirectionTypes, OnRestartExit);
    }

    private void UnsubscribeInputActions()
    {
      model.uiInputActionManager.UnsubscribePerformedEvent(QuitButtonEnterDirectionTypes, OnQuitButtonEnter);
      model.uiInputActionManager.UnsubscribeCanceledEvent(QuitButtonEnterDirectionTypes, OnQuitButtonExit);    

      model.uiInputActionManager.UnsubscribePerformedEvent(RestartButtonEnterDirectionTypes, OnRestartEnter);
      model.uiInputActionManager.UnsubscribeCanceledEvent(RestartButtonEnterDirectionTypes, OnRestartExit);
    }

    private void OnQuitButtonEnter()
    {
      if (currentState != SelectingState.Resume)
        return;

      SetState(SelectingState.Quit);
    }

    private void OnQuitButtonExit()
    {
      if (currentState != SelectingState.Quit)
        return;

      SetState(SelectingState.Resume);
    }

    private void OnRestartEnter()
    {
      if (currentState != SelectingState.Resume)
        return;

      SetState(SelectingState.Restart);
    }

    private void OnRestartExit()
    {
      if (currentState != SelectingState.Restart)
        return;

      SetState(SelectingState.Resume);
    }
    #endregion
  }
}