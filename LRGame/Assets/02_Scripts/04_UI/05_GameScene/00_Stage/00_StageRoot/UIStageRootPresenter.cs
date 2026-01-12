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
      public bool isPlayDialogue;
      public IDialogueStateSubscriber dialogueSubscriber;
      public IStageStateHandler stageStateHandler;
      public IStageStateProvider stageStateProvider;
      public IStageEventSubscriber stageEventSubscriber;
      public IResourceManager resourceManager;
      public IGameDataService gameDataService;
      public UIManager uiManager;
      public ISceneProvider sceneProvider;
      public IUIInputActionManager uiInputActionManager;

      public Model(
        bool isPlayDialogue,
        IDialogueStateSubscriber dialogueSubscriber,
        IStageStateHandler stageStateHandler,
        IStageStateProvider stageStateProvider,
        IStageEventSubscriber stageEventSubscriber,
        IResourceManager resourceManager, 
        IGameDataService gameDataService, 
        UIManager uiManager, 
        ISceneProvider sceneProvider, 
        IUIInputActionManager uiInputActionManager)
      {
        this.isPlayDialogue = isPlayDialogue;
        this.dialogueSubscriber = dialogueSubscriber;
        this.stageStateHandler = stageStateHandler;
        this.stageStateProvider = stageStateProvider;
        this.stageEventSubscriber = stageEventSubscriber;
        this.resourceManager = resourceManager;
        this.gameDataService = gameDataService;
        this.uiManager = uiManager;
        this.sceneProvider = sceneProvider;
        this.uiInputActionManager = uiInputActionManager;
      }
    }

    private static readonly UIInputDirection PauseEnterDirection = UIInputDirection.Space;

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

      beginPresenter.DeactivateAsync(true).Forget();
      failPresenter.DeactivateAsync(true).Forget();
      successPresenter.DeactivateAsync(true).Forget();
      pausePresenter.DeactivateAsync(true).Forget();

      model.stageEventSubscriber.SubscribeOnEvent(IStageEventSubscriber.StageEventType.AllExhausted, OnStageFailed);

      if (model.isPlayDialogue)
        model.dialogueSubscriber.SubscribeEvent(IDialogueStateSubscriber.EventType.OnComplete, OnBeforeDialgoueComplete);
      else
        model.stageEventSubscriber.SubscribeOnEvent(IStageEventSubscriber.StageEventType.Complete, () => successPresenter.ActivateAsync().Forget());
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
      await beginPresenter.ActivateAsync(isImmediately, token);
      SubscribePauseInput();
    }

    private void OnBeforeDialgoueComplete()
    {
      ActivateAsync().Forget();

      model.dialogueSubscriber.UnsubscribeEvent(IDialogueStateSubscriber.EventType.OnComplete, OnBeforeDialgoueComplete);
      model.dialogueSubscriber.SubscribeEvent(IDialogueStateSubscriber.EventType.OnPlay, OnAfterDialogueBegin);
    }

    private void OnAfterDialogueBegin()
    {
      model.dialogueSubscriber.UnsubscribeEvent(IDialogueStateSubscriber.EventType.OnPlay, OnAfterDialogueBegin);
      model.dialogueSubscriber.SubscribeEvent(IDialogueStateSubscriber.EventType.OnComplete, OnAfterDialogueComplete);
    }

    private void OnAfterDialogueComplete()
    {
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
        indicatorService: this.model.uiManager.GetIUIIndicatorService(),
        stageService: this.model.stageStateHandler,
        sceneProvider: this.model.sceneProvider,
        selectedGameObjectService: this.model.uiManager.GetIUISelectedGameObjectService(),
        depthService: this.model.uiManager.GetIUIDepthService());
      var failView = view.failViewContainer;
      failPresenter = new UIStageFailPresenter(model, failView);
      failPresenter.AttachOnDestroy(view.gameObject);
    }

    private void CreateSuccessPresenter()
    {
      var model = new UIStageSuccessPresenter.Model(
        gameDataService: this.model.gameDataService,
        indicatorService: this.model.uiManager.GetIUIIndicatorService(),
        sceneProvider: this.model.sceneProvider, 
        stageService: this.model.stageStateHandler,
        selectedGameObjectService: this.model.uiManager.GetIUISelectedGameObjectService(),
        depthService: this.model.uiManager.GetIUIDepthService());
      var view = this.view.successViewContainer;
      successPresenter = new UIStageSuccessPresenter(model, view);
      successPresenter.AttachOnDestroy(this.view.gameObject);
    }

    private void CreatePausePresenter()
    {
      var model = new UIStagePausePresenter.Model(
        indicatorService: this.model.uiManager.GetIUIIndicatorService(),
        sceneProvider: this.model.sceneProvider,
        stageService: this.model.stageStateHandler,
        selectedGameObjectService: this.model.uiManager.GetIUISelectedGameObjectService(),
        depthService: this.model.uiManager.GetIUIDepthService());
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
      if (model.stageStateProvider.GetState() != StageEnum.State.Playing)
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