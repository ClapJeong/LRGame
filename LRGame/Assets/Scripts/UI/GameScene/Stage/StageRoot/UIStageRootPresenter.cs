using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStageRootPresenter : IUIPresenter
  {
    public class Model
    {
      public IStageService stageService;
      public IResourceManager resourceManager;
      public IGameDataService gameDataService;
      public UIManager uiManager;
      public ISceneProvider sceneProvider;
      public IUIInputActionManager uiInputActionManager;

      public Model(IStageService stageService, IResourceManager resourceManager, IGameDataService gameDataService, UIManager uiManager, ISceneProvider sceneProvider, IUIInputActionManager uiInputActionManager)
      {
        this.stageService = stageService;
        this.resourceManager = resourceManager;
        this.gameDataService = gameDataService;
        this.uiManager = uiManager;
        this.sceneProvider = sceneProvider;
        this.uiInputActionManager = uiInputActionManager;
      }
    }

    private static readonly UIInputDirectionType PauseEnterDirection = UIInputDirectionType.Space;

    private readonly Model model;
    private readonly UIStageRootViewContainer viewContainer;

    private UIStageBeginPresenter beginPresenter;
    private UIStageFailPresenter failPresenter;
    private UIStageSuccessPresenter successPresenter;
    private UIStagePausePresenter pausePresenter;

    public UIStageRootPresenter(Model model, UIStageRootViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      CreateBeginPresenter();
      CreateFailPresenter();
      CreateSuccessPresenter();
      CreatePausePresenter();

      beginPresenter.ShowAsync(true).Forget();

      model.stageService.SubscribeOnEvent(IStageService.StageEventType.Complete,OnStageSuccess);
      model.stageService.SubscribeOnEvent(IStageService.StageEventType.LeftFailed, OnStageFailed);
      model.stageService.SubscribeOnEvent(IStageService.StageEventType.RightFailed, OnStageFailed);

      SubscribePauseInput();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if (viewContainer)
        viewContainer.gameObjectView.DestroyGameObject();

      UnsubscribePauseInput();
    }

    public UIVisibleState GetVisibleState()
      => UIVisibleState.Showed;

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
      => throw new NotImplementedException();

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    private void CreateBeginPresenter()
    {
      var model = new UIStageBeginPresenter.Model(        
        uiInputActionManager: this.model.uiInputActionManager,
        stageService: this.model.stageService);
      var beginView = viewContainer.beginViewContainer;
      beginPresenter = new UIStageBeginPresenter(model, beginView);
      beginPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void CreateFailPresenter()
    {
      var model = new UIStageFailPresenter.Model(
        uiInputActionManager: this.model.uiInputActionManager,
        indicatorService: this.model.uiManager,
        stageService: this.model.stageService,
        sceneProvider: this.model.sceneProvider);
      var failView = viewContainer.failViewContainer;
      failPresenter = new UIStageFailPresenter(model, failView);
      failPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void CreateSuccessPresenter()
    {
      var model = new UIStageSuccessPresenter.Model(
        gameDataService: this.model.gameDataService,
        uiInputActionManager: this.model.uiInputActionManager,
        indicatorService: this.model.uiManager,
        stageService: this.model.stageService,
        sceneProvider: this.model.sceneProvider);
      var view = viewContainer.successViewContainer;
      successPresenter = new UIStageSuccessPresenter(model, view);
      successPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void CreatePausePresenter()
    {
      var model = new UIStagePausePresenter.Model(
        uiInputActionManager: this.model.uiInputActionManager,
        indicatorService: this.model.uiManager,
        sceneProvider: this.model.sceneProvider,
        stageService: this.model.stageService);
      var view = viewContainer.pauseViewContainer;
      pausePresenter = new UIStagePausePresenter(model, view);
      pausePresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void SubscribePauseInput()
    {
      model.uiInputActionManager.SubscribePerformedEvent(PauseEnterDirection, OnPauseInputPerformed);
    }

    private void UnsubscribePauseInput()
    {
      model.uiInputActionManager.UnsubscribePerformedEvent(PauseEnterDirection, OnPauseInputPerformed);
    }

    private void OnPauseInputPerformed()
    {
      if (model.stageService.GetState() != IStageService.State.Playing)
        return;

      pausePresenter.ShowAsync().Forget();
    }

    #region Callbacks
    private void OnStageFailed()
    {
      failPresenter.ShowAsync().Forget();
    }

    private void OnStageSuccess()
    {
      successPresenter.ShowAsync().Forget();
    }
    #endregion
  }
}