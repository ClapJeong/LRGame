using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using LR.Stage.StageDataContainer;
using LR.Stage.TriggerTile;
using LR.Table.Dialogue;
using LR.UI.GameScene.Stage;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using LR.Stage.Player.Enum;

public class StageManager : 
  IStageStateHandler,
  IStageStateProvider,
  IStageResultHandler,
  IStageEventSubscriber,
  IPlayerGetter,
  IStageCreator,
  IDialogueDataProvider
{
  public class Model
  {
    public GameObject localManager;
    public TableContainer table;
    public IGameDataService gameDataService;
    public IResourceManager resourceManager;
    public ISceneProvider sceneProvider;
    public ICameraService cameraService;
    public Transform defaultEffectRoot;
    public InputActionFactory inputActionFactory;
    public IInputProgressService inputProgressService;
    public IInputQTEService inputQTEService;
    public IChatCardService chatCardService;
    public IUIPresenterContainer uiPresenterContainer;

    public Model(GameObject localManager, TableContainer table, IGameDataService gameDataService, IResourceManager resourceManager, ISceneProvider sceneProvider, ICameraService cameraService, Transform defaultEffectRoot, InputActionFactory inputActionFactory, IInputProgressService inputProgressService, IInputQTEService inputQTEService, IChatCardService chatCardService, IUIPresenterContainer uiPresenterContainer)
    {
      this.localManager = localManager;
      this.table = table;
      this.gameDataService = gameDataService;
      this.resourceManager = resourceManager;
      this.sceneProvider = sceneProvider;
      this.cameraService = cameraService;
      this.defaultEffectRoot = defaultEffectRoot;
      this.inputActionFactory = inputActionFactory;
      this.inputProgressService = inputProgressService;
      this.inputQTEService = inputQTEService;
      this.chatCardService = chatCardService;
      this.uiPresenterContainer = uiPresenterContainer;
    }
  }

  private readonly Model model;

  private readonly SignalService signalService;
  private readonly EffectService effectService;
  private readonly PlayerService playerSetupService;
  private readonly TriggerTileService triggerTileService;
  private readonly InteractiveObjectService interactiveObjectService;
  private readonly ChatCardEventService chatCardEventService;

  private readonly Dictionary<IStageEventSubscriber.StageEventType, UnityEvent> stageEvents = new();  

  private StageEnum.State stageState = StageEnum.State.Ready;
  private bool isLeftExhausted = false;
  private bool isRightExhausted = false;
  private bool isLeftClear = false;
  private bool isRightClear = false;

  private DialogueData beforeDialogueData;
  private DialogueData afterDialogueData;

  public StageManager(Model model)
  {
    this.model = model;

    signalService = new();
    effectService = new(
      model.resourceManager, 
      model.table.AddressableKeySO, 
      model.table.EffectTableSO,
      model.defaultEffectRoot);
    playerSetupService = new PlayerService(
      stageService: this,
      stageResultHandler: this,
      model.inputActionFactory,
      model.inputQTEService,
      model.inputProgressService);
    triggerTileService = new TriggerTileService();
    interactiveObjectService = new();
    chatCardEventService = new(
      model.localManager,
      model.chatCardService,
      this,
      this,
      triggerTileService,
      signalService);

    SubscribeOnEvent(IStageEventSubscriber.StageEventType.AllExhausted, () =>
    {
      model.inputProgressService.Stop();
      model.inputQTEService.Stop();
    });
  }

  #region IStageCreator
  public async UniTask CreateAsync(int index, bool isEnableImmediately = false)
  {
    var key = model.table.AddressableKeySO.Path.Stage + string.Format(model.table.AddressableKeySO.StageName.StageNameFormat, index);
    try
    {
      var stageDataContainer = await model.resourceManager.CreateAssetAsync<StageDataContainer>(key);

      var handles = await model.resourceManager.LoadAssetsAsync(model.table.AddressableKeySO.Label.Dialogue);
      CacheDialogueDatas(handles, stageDataContainer);
      SetupCamera(stageDataContainer);
      var playerSetupTask = SetupPlayersAsync(stageDataContainer);
      var triggerSetupTask = SetupTriggersAsync(stageDataContainer);
      var baseInteractiveObjectSetupTask = SetupBaseInteractiveObjectsAsync(stageDataContainer);
      await UniTask.WhenAll(playerSetupTask, triggerSetupTask, baseInteractiveObjectSetupTask);
      SetupSignalListeners(stageDataContainer);
      SetupChatCardEventService(stageDataContainer);
    }
    catch
    {
      model.gameDataService.SetSelectedStage(-1, -1);
      model.sceneProvider.LoadSceneAsync(SceneType.Lobby).Forget();
    }
  }
  #endregion

  #region IStageService
  public async UniTask RestartAsync()
  {
    var restartPresenter = model.uiPresenterContainer.GetFirst<UIRestartPresenter>();
    await restartPresenter.ActivateAsync();

    playerSetupService.RestartAll();
    triggerTileService.RestartAll();
    interactiveObjectService.RestartAll();
    signalService.ResetAllSignal();
    chatCardEventService.Reset();

    isLeftExhausted = false;
    isRightExhausted = false;
    isLeftClear = false;
    isRightClear = false;

    await restartPresenter.DeactivateAsync();

    SetState(StageEnum.State.Playing);
  }

  public void Complete()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.Complete);

    IStageObjectControlService<IPlayerPresenter> playerController = playerSetupService;
    IStageObjectControlService<ITriggerTilePresenter> triggerTileController = triggerTileService;
    playerController.EnableAll(false);
    triggerTileController.EnableAll(false);
    interactiveObjectService.EnableAll(false);

    model.gameDataService.GetSelectedStage(out var chapter, out var stage);
    model.gameDataService.SetClearData(chapter, stage);
    model.gameDataService.SaveDataAsync().Forget();

    SetState(StageEnum.State.Success);
  }

  public void Begin()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.Begin);

    playerSetupService.EnableAll(true);
    triggerTileService.EnableAll(true);
    interactiveObjectService.EnableAll(true);
    SetState(StageEnum.State.Playing);
  }

  public void Pause()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.Pause);

    playerSetupService.EnableAll(false);
    SetState(StageEnum.State.Pause);
  }

  public void Resume()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.Resume);

    playerSetupService.EnableAll(true);
    
    SetState(StageEnum.State.Playing);
  }

  public void SetState(StageEnum.State state)
    => stageState = state;
  #endregion

  #region IStageStateProvider
  public StageEnum.State GetState()
    => stageState;
  #endregion

  #region IStageResultHandler
  public void LeftExhausted()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.LeftExhausted);

    isLeftExhausted = true;

    if (isLeftExhausted && isRightExhausted)
    {
      stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.AllExhausted);
      SetState(StageEnum.State.Fail);
    }      
  }

  public void LeftRevived()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.LeftRevived);

    isLeftExhausted = false;
  }

  public void RightExhaused()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.RightExhausted);

    isRightExhausted = true;

    if (isLeftExhausted && isRightExhausted)
    {
      stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.AllExhausted);
      SetState(StageEnum.State.Fail);
    }      
  }

  public void RightRevived()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.RightExhausted);

    isRightExhausted = false;
  }

  public void LeftClearEnter()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.LeftClearEnter);

    isLeftClear = true;
    if (isLeftClear && isRightClear)
      Complete();
  }

  public void LeftClearExit()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.LeftClearExit);

    isLeftClear = false;
  }

  public void RightClearEnter()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.RightClearEnter);

    isRightClear = true;
    if (isLeftClear && isRightClear)
      Complete();
  }

  public void RightClearExit()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.RightClearExit);

    isRightClear = false;
  }

  #endregion

  #region IStageEventSubscriber
  public void SubscribeOnEvent(IStageEventSubscriber.StageEventType type, UnityAction action)
  {
    stageEvents.AddEvent(type, action);
  }

  public void UnsubscribeOnEvent(IStageEventSubscriber.StageEventType type, UnityAction action)
  {
    stageEvents.RemoveEvent(type, action);
  }
  #endregion

  #region IPlayerGetter
  public IPlayerPresenter GetPlayer(PlayerType playerType)
    => playerSetupService.GetPlayer(playerType);

  public bool IsAllPlayerExist()
    => playerSetupService.IsAllPlayerExist();
  #endregion

  #region IEffectRootGetter
  public Transform GetDefaultEffectRoot()
    => model.defaultEffectRoot;

  #endregion

  private void SetupCamera(StageDataContainer stageData)
  {
    model.cameraService.SetSize(stageData.cameraSize);
  }

  private async UniTask SetupPlayersAsync(StageDataContainer stageData, bool isEnableImmediately = false)
  {
    var leftPosition = stageData.leftPlayerBeginTransform.position;
    var rightPosition = stageData.rightPlayerBeginTransform.position;
    await playerSetupService.SetupAsync(new PlayerService.SetupData(leftPosition,rightPosition),isEnableImmediately);
  }

  private async UniTask SetupTriggersAsync(StageDataContainer stageData, bool isEnableImmediately = false)
  {
    var model = new TriggerTileService.Model(
      effectService,
      stageResultHandler: this,
      playerGetter: this,
      existViews: stageData.TriggerTiles,
      this.model.table,
      this.model.inputProgressService,
      this.model.inputQTEService,
      signalService);
    await triggerTileService.SetupAsync(model,isEnableImmediately);
  }

  private async UniTask SetupBaseInteractiveObjectsAsync(StageDataContainer stageData)
  {
    var model = new InteractiveObjectService.Model(
      stageData.InteractiveObject,
      this);
    await interactiveObjectService.SetupAsync(model);
  }

  private void SetupSignalListeners(StageDataContainer stageData)
  {
    foreach (var signalListener in stageData.SignalListeners)
    {
      signalService.SubscribeActivate(signalListener.RequireKey, signalListener.OnActivate);
      signalService.SubscribeDeactivate(signalListener.RequireKey, signalListener.OnDeactivate);
    }
  }

  private void SetupChatCardEventService(StageDataContainer stageDataContainer)
  {
    chatCardEventService.SetupChatCardEvents(
        playerSetupService.GetPlayer(PlayerType.Left),
        playerSetupService.GetPlayer(PlayerType.Right),
        stageDataContainer.chatCardEvents);
  }

  #region IDialogueDataProvider
  private void CacheDialogueDatas(
    List<AsyncOperationHandle> handles, 
    StageDataContainer stageDataContainer)
  {
    foreach (var handle in handles)
    {
      var data = handle.Result as TextAsset;
      var index = int.Parse(data.name.Split('_')[0]);
      if (index == stageDataContainer.beforeDialogueIndex)
        beforeDialogueData = JsonUtility.FromJson<DialogueData>(data.text);
      else if (index == stageDataContainer.afterDialogueIndex)
        afterDialogueData = JsonUtility.FromJson<DialogueData>(data.text);
    }
  }

  public bool TryGetBeforeDialogueData(out DialogueData beforeDialogueData)
  {
    beforeDialogueData = this.beforeDialogueData;    
    return beforeDialogueData != null;
  }

  public bool TryGetAfterDialogueData(out DialogueData afterDialogueData)
  {
    afterDialogueData = this.afterDialogueData;
    return afterDialogueData != null;
  }
  #endregion
}
