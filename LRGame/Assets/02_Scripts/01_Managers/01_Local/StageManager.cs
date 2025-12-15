using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine.Events;
using LR.Stage.Player;
using LR.Stage.TriggerTile;
using LR.Stage;

public class StageManager : 
  IStageStateHandler, 
  IStageResultHandler,
  IStageEventSubscriber,
  IPlayerGetter,
  IStageCreator
{
  public class Model
  {
    public IResourceManager resourceManager;
    public ISceneProvider sceneProvider;
    public ICameraService cameraService;

    public Model(IResourceManager resourceManager, ISceneProvider sceneProvider, ICameraService cameraService)
    {
      this.resourceManager = resourceManager;
      this.sceneProvider = sceneProvider;
      this.cameraService = cameraService;
    }
  }

  private readonly Model model;

  private readonly PlayerService playerSetupService;
  private readonly TriggerTileService triggerTileSetupService;

  private readonly Dictionary<IStageEventSubscriber.StageEventType, UnityEvent> stageEvents = new();  

  private IStageStateHandler.State stageState = IStageStateHandler.State.Ready;
  private bool isLeftExhausted = false;
  private bool isRightExhausted = false;
  private bool isLeftClear = false;
  private bool isRightClear = false;

  public StageManager(Model model)
  {
    this.model = model;

    playerSetupService = new PlayerService(
      stageService: this,
      stageResultHandler: this);
    triggerTileSetupService = new TriggerTileService();
  }

  #region IStageCreator
  public async UniTask CreateAsync(int index, bool isEnableImmediately = false)
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var key = table.Path.Stage + string.Format(table.StageName.StageNameFormat, index);
    try
    {
      var stageDataContainer = await model.resourceManager.CreateAssetAsync<StageDataContainer>(key);

      SetupCamera(stageDataContainer);
      SetupPlayers(stageDataContainer);
      SetupTriggers(stageDataContainer);
      SetupDynamicObstacles(stageDataContainer);

      SetState(IStageStateHandler.State.Ready);
    }
    catch
    {
      GlobalManager.instance.GameDataService.SetSelectedStage(-1, -1);
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
      stageResultHandler: this,
      playerGetter: this,
      existViews: stageData.TriggerTiles);
    triggerTileSetupService.SetupAsync(model,isEnableImmediately).Forget();
  }

  private void SetupDynamicObstacles(StageDataContainer stageData)
  {
    foreach (var dynamicObstalce in stageData.DynamicObstacles)
    {

    }
  }
}
