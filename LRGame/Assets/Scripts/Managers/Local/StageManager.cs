using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine.Events;

public class StageManager : IStageController, IStageCreator
{
  private readonly PlayerService playerSetupService;
  private readonly TriggerTileService triggerTileSetupService;
  private readonly Dictionary<IStageController.StageEventType, UnityEvent> stageEvents = new();

  private CTSContainer regenCTS;

  public StageManager()
  {
    playerSetupService = new PlayerService();
    triggerTileSetupService = new TriggerTileService();
  }

  public async UniTask CreateAsync(int index, bool isEnableImmediately = false)
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var key = table.Path.Stage + string.Format(table.StageName.StageNameFormat, index);
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var stageDataContainer = await resourceManager.CreateAssetAsync<StageDataContainer>(key);

    SetupPlayers(stageDataContainer);
    SetupTriggers(stageDataContainer);
    SetupDynamicObstacles(stageDataContainer);
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
    IStageController stageController = this;
    IStageObjectSetupService<ITriggerTilePresenter> triggersSetupService = triggerTileSetupService;
    triggersSetupService.SetupAsync(new TriggerTileService.Model(stageData.TriggerTiles, stageController),isEnableImmediately).Forget();
  }


  private void SetupDynamicObstacles(StageDataContainer stageData)
  {
    foreach (var dynamicObstalce in stageData.DynamicObstacles)
    {

    }
  }

  public UniTask RestartAsync()
  {
    playerSetupService.RestartAll();
    triggerTileSetupService.RestartAll();
    return UniTask.CompletedTask;
  }

  public void Complete()
  {
    if (stageEvents.TryGetValue(IStageController.StageEventType.Complete, out var existEvent))
      existEvent?.Invoke();

    IStageObjectControlService<IPlayerPresenter> playerController = playerSetupService;    
    IStageObjectControlService<ITriggerTilePresenter> triggerTileController = triggerTileSetupService;
    playerController.EnableAll(false);
    triggerTileController.EnableAll(false);
    UnityEngine.Debug.Log("Complete!");
  }

  public void Begin()
  {
    if (stageEvents.TryGetValue(IStageController.StageEventType.Begin, out var existEvent))
      existEvent?.Invoke();

    playerSetupService.EnableAll(true);
    triggerTileSetupService.EnableAll(true);
  }

  public void Pause()
  {
    if (stageEvents.TryGetValue(IStageController.StageEventType.Pause, out var existEvent))
      existEvent?.Invoke();

    playerSetupService.EnableAll(false);
    triggerTileSetupService.EnableAll(false);
  }

  public void Resume()
  {
    if (stageEvents.TryGetValue(IStageController.StageEventType.Resume, out var existEvent))
      existEvent?.Invoke();

    playerSetupService.EnableAll(true);
    triggerTileSetupService.EnableAll(true);
  }

  public void OnLeftFailed()
  {
    if (stageEvents.TryGetValue(IStageController.StageEventType.LeftFailed, out var existEvent))
      existEvent?.Invoke();

    IStageObjectControlService<IPlayerPresenter> playerController = playerSetupService;
    IStageObjectControlService<ITriggerTilePresenter> triggerTileController = triggerTileSetupService;
    playerController.EnableAll(false);
    triggerTileController.EnableAll(false);
  }

  public void OnRightFailed()
  {
    if (stageEvents.TryGetValue(IStageController.StageEventType.RightFailed, out var existEvent))
      existEvent?.Invoke();

    IStageObjectControlService<IPlayerPresenter> playerController = playerSetupService;
    IStageObjectControlService<ITriggerTilePresenter> triggerTileController = triggerTileSetupService;
    playerController.EnableAll(false);
    triggerTileController.EnableAll(false);
  }

  public void SubscribeOnEvent(IStageController.StageEventType type, UnityAction action)
  {
    if (stageEvents.TryGetValue(type, out var existEvent))
      existEvent.AddListener(action);
    else
    {
      stageEvents[type] = new UnityEvent();
      stageEvents[type].AddListener(action);
    }      
  }

  public void UnsubscribeOnEvent(IStageController.StageEventType type, UnityAction action)
  {
    if (stageEvents.TryGetValue(type, out var existEvent))
      existEvent.RemoveListener(action);
  }
}
