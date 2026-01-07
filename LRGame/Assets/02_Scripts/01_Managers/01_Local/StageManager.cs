using Cysharp.Threading.Tasks;
using LR.Stage;
using LR.Stage.Player;
using LR.Stage.TriggerTile;
using LR.Table.Dialogue;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

public class StageManager : 
  IStageStateHandler, 
  IStageResultHandler,
  IStageEventSubscriber,
  IPlayerGetter,
  IStageCreator,
  IDialogueDataProvider
{
  public class Model
  {
    public TableContainer table;
    public IGameDataService gameDataService;
    public IResourceManager resourceManager;
    public ISceneProvider sceneProvider;
    public ICameraService cameraService;
    public Transform defaultEffectRoot;
    public InputActionFactory inputActionFactory;
    public IInputProgressService inputProgressService;
    public IInputQTEService inputQTEService;

    public Model(TableContainer table, IGameDataService gameDataService, IResourceManager resourceManager, ISceneProvider sceneProvider, ICameraService cameraService, Transform defaultEffectRoot, InputActionFactory inputActionFactory, InputProgressService inputProgressService, IInputQTEService inputQTEService)
    {
      this.table = table;
      this.gameDataService = gameDataService;
      this.resourceManager = resourceManager;
      this.sceneProvider = sceneProvider;
      this.cameraService = cameraService;
      this.defaultEffectRoot = defaultEffectRoot;
      this.inputActionFactory = inputActionFactory;
      this.inputProgressService = inputProgressService;
      this.inputQTEService = inputQTEService;
    }
  }

  private readonly Model model;

  private readonly SignalService signalService;
  private readonly EffectService effectService;
  private readonly PlayerService playerSetupService;
  private readonly TriggerTileService triggerTileSetupService;

  private readonly Dictionary<IStageEventSubscriber.StageEventType, UnityEvent> stageEvents = new();  

  private IStageStateHandler.State stageState = IStageStateHandler.State.Ready;
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
    triggerTileSetupService = new TriggerTileService();

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
      SetupPlayers(stageDataContainer);
      SetupTriggers(stageDataContainer);
      SetupDynamicObstacles(stageDataContainer);      
    }
    catch
    {
      model.gameDataService.SetSelectedStage(-1, -1);
      model.sceneProvider.LoadSceneAsync(SceneType.Lobby).Forget();
    }
  }
  #endregion

  #region IStageService
  public UniTask RestartAsync()
  {
    playerSetupService.RestartAll();
    triggerTileSetupService.RestartAll();

    isLeftExhausted = false;
    isRightExhausted = false;
    isLeftClear = false;
    isRightClear = false;

    SetState(IStageStateHandler.State.Playing);
    return UniTask.CompletedTask;
  }

  public void Complete()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.Complete);

    IStageObjectControlService<IPlayerPresenter> playerController = playerSetupService;
    IStageObjectControlService<ITriggerTilePresenter> triggerTileController = triggerTileSetupService;
    playerController.EnableAll(false);
    triggerTileController.EnableAll(false);

    SetState(IStageStateHandler.State.Success);
  }

  public void Begin()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.Begin);

    playerSetupService.EnableAll(true);
    triggerTileSetupService.EnableAll(true);
    SetState(IStageStateHandler.State.Playing);
  }

  public void Pause()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.Pause);

    playerSetupService.EnableAll(false);
    triggerTileSetupService.EnableAll(false);
    SetState(IStageStateHandler.State.Pause);
  }

  public void Resume()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.Resume);

    playerSetupService.EnableAll(true);
    triggerTileSetupService.EnableAll(true);
    SetState(IStageStateHandler.State.Playing);
  }

  public void SetState(IStageStateHandler.State state)
    => stageState = state;

  public IStageStateHandler.State GetState()
    => stageState;
  #endregion

  #region IStageResultHandler
  public void LeftExhausted()
  {
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.LeftExhausted);

    isLeftExhausted = true;

    if (isLeftExhausted && isRightExhausted)
      stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.AllExhausted);
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
      stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.AllExhausted);
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
    model.cameraService.SetSize(stageData.CameraSize);
  }

  private void SetupPlayers(StageDataContainer stageData, bool isEnableImmediately = false)
  {
    IStageObjectSetupService<IPlayerPresenter> stageObjectSetupService = playerSetupService;
    var leftPosition = stageData.LeftPlayerBeginTransform.position;
    var rightPosition = stageData.RightPlayerBeginTransform.position;
    stageObjectSetupService.SetupAsync(new PlayerService.SetupData(leftPosition,rightPosition),isEnableImmediately).Forget();
  }

  private void SetupTriggers(StageDataContainer stageData, bool isEnableImmediately = false)
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
    triggerTileSetupService.SetupAsync(model,isEnableImmediately).Forget();
  }

  private void SetupDynamicObstacles(StageDataContainer stageData)
  {
    foreach (var dynamicObstalce in stageData.DynamicObstacles)
    {

    }
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
      if (index == stageDataContainer.BeforeDialogueIndex)
        beforeDialogueData = JsonUtility.FromJson<DialogueData>(data.text);
      else if (index == stageDataContainer.AfterDialogueIndex)
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
