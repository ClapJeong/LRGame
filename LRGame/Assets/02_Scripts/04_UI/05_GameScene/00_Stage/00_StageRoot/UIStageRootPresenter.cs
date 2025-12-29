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
      public IDialogueSubscriber dialogueSubscriber;
      public IStageStateHandler stageStateHandler;
      public IStageEventSubscriber stageEventSubscriber;
      public IResourceManager resourceManager;
      public IGameDataService gameDataService;
      public UIManager uiManager;
      public ISceneProvider sceneProvider;
      public IUIInputActionManager uiInputActionManager;

      public Model(
        IDialogueSubscriber dialogueSubscriber,
        IStageStateHandler stageStateHandler,
        IStageEventSubscriber stageEventSubscriber,
        IResourceManager resourceManager, 
        IGameDataService gameDataService, 
        UIManager uiManager, 
        ISceneProvider sceneProvider, 
        IUIInputActionManager uiInputActionManager)
      {
        this.dialogueSubscriber = dialogueSubscriber;
        this.stageStateHandler = stageStateHandler;
        this.stageEventSubscriber = stageEventSubscriber;
        this.resourceManager = resourceManager;
        this.gameDataService = gameDataService;
        this.uiManager = uiManager;
        this.sceneProvider = sceneProvider;
        this.uiInputActionManager = uiInputActionManager;
      }
    }

    private static readonly UIInputDirectionType PauseEnterDirection = UIInputDirectionType.Space;

    private readonly Model model;
    private readonly UIStageRootView view;

    private UIStageBeginPresenter beginPresenter;
    private UIStageFailPresenter failPresenter;
    private UIStageSuccessPresenter successPresenter;
    private UIStagePausePresenter pausePresenter;

    public UIStageRootPresenter(Model model, UIStageRootView view)
    {
      this.model = model;
      this.view = view;

      CreateBeginPresenter();
      CreateFailPresenter();
      CreateSuccessPresenter();
      CreatePausePresenter();

      beginPresenter.DeactivateAsync().Forget();
      failPresenter.DeactivateAsync().Forget();
      successPresenter.DeactivateAsync().Forget();
      pausePresenter.DeactivateAsync().Forget();

      model.stageEventSubscriber.SubscribeOnEvent(IStageEventSubscriber.StageEventType.AllExhausted, OnStageFailed);

      model.dialogueSubscriber.SubscribeEvent(IDialogueSubscriber.EventType.OnComplete, OnBeforeDialgoueComplete);      
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if (view)
        view.DestroySelf();

      UnsubscribePauseInput();
    }

    public UIVisibleState GetVisibleState()
      => UIVisibleState.Showen;

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await view.HideAsync(isImmediately, token);
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await view.ShowAsync(isImmediately, token);
    }

    private void OnBeforeDialgoueComplete()
    {
      beginPresenter.ActivateAsync().Forget();
      SubscribePauseInput();

      model.dialogueSubscriber.UnsubscribeEvent(IDialogueSubscriber.EventType.OnComplete, OnBeforeDialgoueComplete);
      model.dialogueSubscriber.SubscribeEvent(IDialogueSubscriber.EventType.OnPlay, OnAfterDialogueBegin);
    }

    private void OnAfterDialogueBegin()
    {
      model.dialogueSubscriber.UnsubscribeEvent(IDialogueSubscriber.EventType.OnPlay, OnAfterDialogueBegin);
      model.dialogueSubscriber.SubscribeEvent(IDialogueSubscriber.EventType.OnComplete, OnAfterDialogueComplete);
    }

    private void OnAfterDialogueComplete()
    {
      model.dialogueSubscriber.UnsubscribeEvent(IDialogueSubscriber.EventType.OnComplete, OnAfterDialogueComplete);
      successPresenter.ActivateAsync().Forget();
    }

    private void CreateBeginPresenter()
    {
      var model = new UIStageBeginPresenter.Model(        
        uiInputActionManager: this.model.uiInputActionManager,
        stageService: this.model.stageStateHandler);
      var beginView = view.beginViewContainer;
      beginPresenter = new UIStageBeginPresenter(model, beginView);
      beginPresenter.AttachOnDestroy(view.gameObject);
    }

    private void CreateFailPresenter()
    {
      var model = new UIStageFailPresenter.Model(
        uiInputActionManager: this.model.uiInputActionManager,
        indicatorService: this.model.uiManager,
        stageService: this.model.stageStateHandler,
        sceneProvider: this.model.sceneProvider);
      var failView = view.failViewContainer;
      failPresenter = new UIStageFailPresenter(model, failView);
      failPresenter.AttachOnDestroy(view.gameObject);
    }

    private void CreateSuccessPresenter()
    {
      var model = new UIStageSuccessPresenter.Model(
        gameDataService: this.model.gameDataService,
        uiInputActionManager: this.model.uiInputActionManager,
        indicatorService: this.model.uiManager,
        stageService: this.model.stageStateHandler,
        sceneProvider: this.model.sceneProvider);
      var view = this.view.successViewContainer;
      successPresenter = new UIStageSuccessPresenter(model, view);
      successPresenter.AttachOnDestroy(this.view.gameObject);
    }

    private void CreatePausePresenter()
    {
      var model = new UIStagePausePresenter.Model(
        uiInputActionManager: this.model.uiInputActionManager,
        indicatorService: this.model.uiManager,
        sceneProvider: this.model.sceneProvider,
        stageService: this.model.stageStateHandler);
      var view = this.view.pauseViewContainer;
      pausePresenter = new UIStagePausePresenter(model, view);
      pausePresenter.AttachOnDestroy(this.view.gameObject);
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
      if (model.stageStateHandler.GetState() != IStageStateHandler.State.Playing)
        return;

      pausePresenter.ActivateAsync().Forget();
    }

    #region Callbacks
    private void OnStageFailed()
    {
      failPresenter.ActivateAsync().Forget();
    }
    #endregion
  }
}