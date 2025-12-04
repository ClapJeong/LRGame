using Cysharp.Threading.Tasks;
using LR.UI.GameScene.Stage.PausePanel;
using System;
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
      public IStageController stageController;

      public Model(IUIInputActionManager uiInputActionManager, IUIIndicatorService indicatorService, ISceneProvider sceneProvider, IStageController stageController)
      {
        this.uiInputActionManager = uiInputActionManager;
        this.indicatorService = indicatorService;
        this.sceneProvider = sceneProvider;
        this.stageController = stageController;
      }
    }

    private readonly Model model;
    private readonly UIStagePauseViewContainer viewContainer;

    private ResumeButtonPresenter resumePresenter;
    private BaseButtonPresenter restartPresenter;
    private BaseButtonPresenter quitPresenter;

    private UIVisibleState visibleState = UIVisibleState.None;
    private SelectingState currentState;
    private SubscribeHandle subscribeHandle;

    public UIStagePausePresenter(Model model, UIStagePauseViewContainer viewContainer)
    {
      this.viewContainer = viewContainer;
      this.model = model;

      visibleState = UIVisibleState.Hided;

      CreateSubscribeHandle();
      CreateResumePresenter();
      CreateQuitPresenter();
      CreateRestartPresenter();      
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }

    public async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await model.indicatorService.GetNewAsync(viewContainer.IndicatorRoot, viewContainer.quitButtonViewContainer.baseRectView);
      SetState(SelectingState.Quit);
      subscribeHandle.Subscribe();
      viewContainer.gameObjectView.SetActive(true);
      visibleState = UIVisibleState.Showed;
      await UniTask.CompletedTask;
    }

    public async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      SetState(SelectingState.None);
      subscribeHandle.Unsubscribe();
      viewContainer.gameObjectView.SetActive(false);
      visibleState = UIVisibleState.Hided;
      await UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
      => this.visibleState = visibleState;

    public UIVisibleState GetVisibleState()
      => visibleState;

    private void CreateSubscribeHandle()
    {
      subscribeHandle = new SubscribeHandle(
        onSubscribe: () =>
        {
          SubscribeInputActions();
        },
        onUnsubscribe: () =>
        {
          UnsubscribeInputActions();
          model.indicatorService.ReleaseTopIndicator();
        });
    }

    private void SetState(SelectingState selectingType)
    {
      var prevState = currentState;
      switch (prevState)
      {
        case SelectingState.None:break;

        case SelectingState.Resume:
          resumePresenter.HideAsync().Forget();
          break;

        case SelectingState.Restart:
          restartPresenter.HideAsync().Forget();
          break;

        case SelectingState.Quit:
          quitPresenter.HideAsync().Forget();
          break;
      }

      currentState = selectingType;
      switch (currentState)
      {
        case SelectingState.None: break;

        case SelectingState.Resume:
          resumePresenter.ShowAsync().Forget();
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.resumeButtonViewContainer.rectView).Forget();
          break;

        case SelectingState.Restart:
          resumePresenter.ShowAsync().Forget();
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.restartButtonViewContainer.baseRectView).Forget();
          break;

        case SelectingState.Quit:
          quitPresenter.ShowAsync().Forget();
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.quitButtonViewContainer.baseRectView).Forget();
          break;
      }
    }

    private void CreateResumePresenter()
    {
      var model = new ResumeButtonPresenter.Model(
        onSubmit: () =>
        {
          this.model.sceneProvider.LoadSceneAsync(SceneType.Lobby).Forget();
        },
        uiInputActionManager: this.model.uiInputActionManager);
      var view = viewContainer.resumeButtonViewContainer;
      resumePresenter = new ResumeButtonPresenter(model, view);
      resumePresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void CreateRestartPresenter()
    {
      var model = new BaseButtonPresenter.Model(
        minInputActionType: UIInputActionType.RightRight,
        maxInputActionType: UIInputActionType.RightLeft,
        onSubmit: () =>
        {
          this.model.stageController.RestartAsync().Forget();
        },
        uiInputActionManager: this.model.uiInputActionManager);
      var view = viewContainer.restartButtonViewContainer;
      restartPresenter = new BaseButtonPresenter(model, view);
      restartPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void CreateQuitPresenter() 
    {
      var model = new BaseButtonPresenter.Model(
        minInputActionType: UIInputActionType.RightDown,
        maxInputActionType: UIInputActionType.RightUP,
        onSubmit: () =>
        {
          HideAsync().Forget();
        },
        uiInputActionManager: this.model.uiInputActionManager);
      var view = viewContainer.restartButtonViewContainer;
      quitPresenter = new BaseButtonPresenter(model, view);
      quitPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    #region Subscribes
    private void SubscribeInputActions()
    {
      model.uiInputActionManager.SubscribePerformedEvent(UIInputActionType.LeftUP, OnUpDownPerformed);
      model.uiInputActionManager.SubscribePerformedEvent(UIInputActionType.LeftDown, OnUpDownPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(UIInputActionType.LeftUP, OnUpdownCanceled);
      model.uiInputActionManager.SubscribeCanceledEvent(UIInputActionType.LeftDown, OnUpdownCanceled);

      model.uiInputActionManager.SubscribePerformedEvent(UIInputActionType.LeftRight, OnLeftRightPerformed);
      model.uiInputActionManager.SubscribePerformedEvent(UIInputActionType.LeftLeft, OnLeftRightPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(UIInputActionType.LeftRight, OnLeftRightCanceled);
      model.uiInputActionManager.SubscribeCanceledEvent(UIInputActionType.LeftLeft, OnLeftRightCanceled);
    }

    private void UnsubscribeInputActions()
    {
      model.uiInputActionManager.UnsubscribePerformedEvent(UIInputActionType.LeftUP, OnUpDownPerformed);
      model.uiInputActionManager.UnsubscribePerformedEvent(UIInputActionType.LeftDown, OnUpDownPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(UIInputActionType.LeftUP, OnUpdownCanceled);
      model.uiInputActionManager.UnsubscribeCanceledEvent(UIInputActionType.LeftDown, OnUpdownCanceled);

      model.uiInputActionManager.UnsubscribePerformedEvent(UIInputActionType.LeftRight, OnLeftRightPerformed);
      model.uiInputActionManager.UnsubscribePerformedEvent(UIInputActionType.LeftLeft, OnLeftRightPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(UIInputActionType.LeftRight, OnLeftRightCanceled);
      model.uiInputActionManager.UnsubscribeCanceledEvent(UIInputActionType.LeftLeft, OnLeftRightCanceled);
    }

    private void OnUpDownPerformed()
    {
      if (currentState != SelectingState.Resume)
        return;

      SetState(SelectingState.Quit);
    }

    private void OnUpdownCanceled()
    {
      if (currentState != SelectingState.Restart)
        return;

      SetState(SelectingState.Resume);
    }

    private void OnLeftRightPerformed()
    {
      if (currentState != SelectingState.Resume)
        return;

      SetState(SelectingState.Restart);
    }

    private void OnLeftRightCanceled()
    {
      if (currentState != SelectingState.Quit)
        return;

      SetState(SelectingState.Resume);
    }

    #endregion
  }
}