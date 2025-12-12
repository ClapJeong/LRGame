using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine.Events;
using LR.Stage.Player;
using LR.Stage.TriggerTile;
using LR.Stage;

public class StageManager : IStageService, IStageCreator
{
  private readonly IResourceManager resourceManager;
  private readonly ISceneProvider sceneProvider;
  private readonly ICameraService cameraService;

  private readonly PlayerService playerSetupService;
  private readonly TriggerTileService triggerTileSetupService;

  private readonly Dictionary<IStageService.StageEventType, UnityEvent> stageEvents = new();  

  private IStageService.State stageState = IStageService.State.Ready;

  public StageManager(IResourceManager resourceManager, ISceneProvider sceneProvider, ICameraService cameraService)
  {
    this.resourceManager = resourceManager;
    this.sceneProvider = sceneProvider;
    this.cameraService = cameraService;

    playerSetupService = new PlayerService();
    triggerTileSetupService = new TriggerTileService();
  }

  #region IStageCreator
  public async UniTask CreateAsync(int index, bool isEnableImmediately = false)
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var key = table.Path.Stage + string.Format(table.StageName.StageNameFormat, index);
    try
    {
      var stageDataContainer = await resourceManager.CreateAssetAsync<StageDataContainer>(key);

      SetupCamera(stageDataContainer);
      SetupPlayers(stageDataContainer);
      SetupTriggers(stageDataContainer);
      SetupDynamicObstacles(stageDataContainer);

      SetState(IStageService.State.Ready);
    }
    catch
    {
      GlobalManager.instance.GameDataService.SetSelectedStage(-1, -1);
      sceneProvider.LoadSceneAsync(SceneType.Lobby).Forget();
    }
  }
  #endregion

  private void SetupCamera(StageDataContainer stageData)
  {
    cameraService.SetSize(stageData.CameraSize);
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
    IStageService stageService = this;
    IStageObjectSetupService<ITriggerTilePresenter> triggersSetupService = triggerTileSetupService;
    triggersSetupService.SetupAsync(new TriggerTileService.Model(stageData.TriggerTiles, stageService),isEnableImmediately).Forget();
  }

  private void SetupDynamicObstacles(StageDataContainer stageData)
  {
    foreach (var dynamicObstalce in stageData.DynamicObstacles)
    {

    }
  }

  #region IStageService
  public UniTask RestartAsync()
  {
    playerSetupService.RestartAll();
    triggerTileSetupService.RestartAll();

    SetState(IStageService.State.Playing);
    return UniTask.CompletedTask;
  }

  public void Complete()
  {
    if (stageEvents.TryGetValue(IStageService.StageEventType.Complete, out var existEvent))
      existEvent?.Invoke();

    IStageObjectControlService<IPlayerPresenter> playerController = playerSetupService;    
    IStageObjectControlService<ITriggerTilePresenter> triggerTileController = triggerTileSetupService;
    playerController.EnableAll(false);
    triggerTileController.EnableAll(false);
    SetState(IStageService.State.Success);
  }

  public void Begin()
  {
    if (stageEvents.TryGetValue(IStageService.StageEventType.Begin, out var existEvent))
      existEvent?.Invoke();

    playerSetupService.EnableAll(true);
    triggerTileSetupService.EnableAll(true);
    SetState(IStageService.State.Playing);
  }

  public void Pause()
  {
    if (stageEvents.TryGetValue(IStageService.StageEventType.Pause, out var existEvent))
      existEvent?.Invoke();

    playerSetupService.EnableAll(false);
    triggerTileSetupService.EnableAll(false);
    SetState(IStageService.State.Pause);
  }

  public void Resume()
  {
    if (stageEvents.TryGetValue(IStageService.StageEventType.Resume, out var existEvent))
      existEvent?.Invoke();

    playerSetupService.EnableAll(true);
    triggerTileSetupService.EnableAll(true);
    SetState(IStageService.State.Playing);
  }

  public void OnLeftFailed()
  {
    if (stageEvents.TryGetValue(IStageService.StageEventType.LeftFailed, out var existEvent))
      existEvent?.Invoke();

    IStageObjectControlService<IPlayerPresenter> playerController = playerSetupService;
    IStageObjectControlService<ITriggerTilePresenter> triggerTileController = triggerTileSetupService;
    playerController.EnableAll(false);
    triggerTileController.EnableAll(false);
    SetState(IStageService.State.Fail);
  }

  public void OnRightFailed()
  {
    if (stageEvents.TryGetValue(IStageService.StageEventType.RightFailed, out var existEvent))
      existEvent?.Invoke();

    IStageObjectControlService<IPlayerPresenter> playerController = playerSetupService;
    IStageObjectControlService<ITriggerTilePresenter> triggerTileController = triggerTileSetupService;
    playerController.EnableAll(false);
    triggerTileController.EnableAll(false);
    SetState(IStageService.State.Fail);
  }

  public void SubscribeOnEvent(IStageService.StageEventType type, UnityAction action)
  {
    if (stageEvents.TryGetValue(type, out var existEvent))
      existEvent.AddListener(action);
    else
    {
      stageEvents[type] = new UnityEvent();
      stageEvents[type].AddListener(action);
    }      
  }

  public void UnsubscribeOnEvent(IStageService.StageEventType type, UnityAction action)
  {
    if (stageEvents.TryGetValue(type, out var existEvent))
      existEvent.RemoveListener(action);
  }

  public async UniTask<IPlayerPresenter> GetPresenterAsync(PlayerType type)
  {
    await playerSetupService.AwaitUntilSetupCompleteAsync();
    return playerSetupService.GetPresenter(type);
  }

  public void SetState(IStageService.State state)
    => stageState = state;

  public IStageService.State GetState()
    => stageState;
  #endregion
}
