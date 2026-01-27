using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using LR.Stage.StageDataContainer;
using LR.Table.Dialogue;
using LR.UI.GameScene.Stage;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using LR.Stage.Player.Enum;
using LR.Stage.SignalListener;

public class StageManager : 
  IStageStateHandler,
  IStageStateProvider,
  IStageResultHandler,
  IStageEventSubscriber,
  IPlayerGetter,
  IStageCreator,
  IDialogueDataProvider,
  IDialoguePlayableProvider
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

    public Model(
      GameObject localManager, 
      TableContainer table, 
      IGameDataService gameDataService, 
      IResourceManager resourceManager, 
      ISceneProvider sceneProvider, 
      ICameraService cameraService, 
      Transform defaultEffectRoot, 
      InputActionFactory inputActionFactory, 
      IInputProgressService inputProgressService, 
      IInputQTEService inputQTEService, 
      IChatCardService chatCardService, 
      IUIPresenterContainer uiPresenterContainer)
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
  private readonly SignalListenerService signalListenerService;
  private readonly ChatCardEventService chatCardEventService;
  private readonly ScoreCalculator scoreCalculator;

  private readonly Dictionary<IStageEventSubscriber.StageEventType, UnityEvent> stageEvents = new();  

  private StageEnum.State stageState = StageEnum.State.Ready;
  private bool isLeftExhausted = false;
  private bool isRightExhausted = false;
  private bool isLeftClear = false;
  private bool isRightClear = false;

  public StageDataContainer StageDataContainer { get; private set;  }
  private DialogueData beforeDialogueData;
  private DialogueData afterDialogueData;

  public StageManager(Model model)
  {
    this.model = model;

    scoreCalculator = new();
    signalService = new();
    effectService = new(
      model.resourceManager, 
      model.table.AddressableKeySO, 
      model.table.EffectTableSO,
      model.defaultEffectRoot);
    playerSetupService = new PlayerService(
      model.table,
      model.resourceManager,
      stageService: this,
      stageResultHandler: this,
      model.inputActionFactory,
      model.inputQTEService,
      model.inputProgressService);
    triggerTileService = new TriggerTileService(
      effectService,
      stageResultHandler: this,
      playerGetter: this,
      this.model.table,
      this.model.inputProgressService,
      this.model.inputQTEService,
      signalService);
    interactiveObjectService = new(this);
    signalListenerService = new(
      effectService,
      signalService,
      signalService,
      this.model.table,
      this.model.resourceManager);
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
    var key = model.table.AddressableKeySO.Path.Stage + index.ToString() + ".prefab";
    try
    {
      StageDataContainer = await model.resourceManager.CreateAssetAsync<StageDataContainer>(key);

      var handles = await model.resourceManager.LoadAssetsAsync(model.table.AddressableKeySO.Label.Dialogue);
      CacheDialogueDatas(handles, StageDataContainer);
      SetupCamera(StageDataContainer);
      var tasks = new UniTask[]
      {
        playerSetupService.SetupAsync(StageDataContainer, isEnableImmediately),
        triggerTileService.SetupAsync(StageDataContainer, isEnableImmediately),
        interactiveObjectService.SetupAsync(StageDataContainer, isEnableImmediately),
        signalListenerService.SetupAsync(StageDataContainer, isEnableImmediately),
      };
      await UniTask.WhenAll(tasks);
      SetupChatCardEventService(StageDataContainer);
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
    
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.Restart);

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
    stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.AllClearEnter);

    playerSetupService.EnableAll(false);
    triggerTileService.EnableAll(false);
    interactiveObjectService.EnableAll(false);

    scoreCalculator.CalculateScore(
      StageDataContainer.scoreData,
      playerSetupService.GetPlayer(PlayerType.Left),
      playerSetupService.GetPlayer(PlayerType.Right),
      out var leftScore,
      out var rightScore);

    model.gameDataService.GetSelectedStage(out var chapter, out var stage);
    model.gameDataService.SetClearData(chapter, stage, leftScore, rightScore);
    model.gameDataService.SaveDataAsync().Forget();

    SetState(StageEnum.State.Success);

    effectService.Create(
      InstanceEffectType.StageClear, 
      Vector3.zero, 
      Quaternion.identity,
      onComplete: () =>
      {
        stageEvents.TryInvoke(IStageEventSubscriber.StageEventType.Complete);
      });    
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

  #region IDialoguePlayableProvider
  public bool IsBeforeDialoguePlayable()
  {
    model.gameDataService.GetSelectedStage(out var chapter, out var stage);
    var isClearStage = model.gameDataService.IsClearStage(chapter, stage);
    var isDialogueDataExist = beforeDialogueData != null;
    return isClearStage == false && isDialogueDataExist;
  }

  public bool IsAfterDialoguePlayable()
  {
    model.gameDataService.GetSelectedStage(out var chapter, out var stage);
    var isClearStage = model.gameDataService.IsClearStage(chapter, stage);
    var isDialogueDataExist = afterDialogueData != null;
    return isClearStage == false && isDialogueDataExist;
  }
  #endregion
}
