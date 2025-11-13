using Cysharp.Threading.Tasks;

public class StageManager : IStageController, IStageCreator
{
  private readonly PlayerService playerSetupService;
  private readonly TriggerTileService triggerTileSetupService;

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
    IStageObjectSetupService<ITriggerTilePresenter> triggersSetupService = triggerTileSetupService;
    triggersSetupService.SetupAsync(new TriggerTileService.SetupData(stageData.TriggerTiles),isEnableImmediately).Forget();
  }


  private void SetupDynamicObstacles(StageDataContainer stageData)
  {
    foreach (var dynamicObstalce in stageData.DynamicObstacles)
    {

    }
  }

  public UniTask ReStartAsync()
  {
    regenCTS?.Dispose();
    regenCTS = new CTSContainer();
    var token = regenCTS.token;
    ISceneProvider sceneProvider = GlobalManager.instance.SceneProvider;
    sceneProvider.ReloadCurrentSceneAsync(
      token: token,
      onProgress: null,
      onComplete: null,
      waitUntilLoad: null).Forget();

    return UniTask.CompletedTask;
  }

  public void Complete()
  {
    IStageObjectEnableService<IPlayerPresenter> playerController = playerSetupService;    
    IStageObjectEnableService<ITriggerTilePresenter> triggerTileController = triggerTileSetupService;
    playerController.EnableAll(false);
    triggerTileController.EnableAll(false);
    UnityEngine.Debug.Log("Complete!");
  }

  public void Fail(StageFailType failType)
  {
    IStageObjectEnableService<IPlayerPresenter> playerController = playerSetupService;
    IStageObjectEnableService<ITriggerTilePresenter> triggerTileController = triggerTileSetupService;
    playerController.EnableAll(false);
    triggerTileController.EnableAll(false);
    UnityEngine.Debug.Log($"Fail: {failType}");
  }

  public void Begin()
  {
    playerSetupService.EnableAll(true);
    triggerTileSetupService.EnableAll(true);
  }

  public void Pause()
  {
    playerSetupService.EnableAll(false);
    triggerTileSetupService.EnableAll(false);
  }

  public void Resume()
  {
    playerSetupService.EnableAll(true);
    triggerTileSetupService.EnableAll(true);
  }
}
