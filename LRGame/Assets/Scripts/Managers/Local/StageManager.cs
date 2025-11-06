using Cysharp.Threading.Tasks;

public class StageManager : IStageController, IStageCreator
{
  private readonly PlayerSetupService playerSetupService;
  private readonly TriggerTileSetupService triggerTileSetupService;

  private CTSContainer regenCTS;

  public StageManager()
  {
    playerSetupService = new PlayerSetupService();
    triggerTileSetupService = new TriggerTileSetupService();
  }

  public async UniTask CreateAsync()
  {
    var stageDataContainer = await GlobalManager.instance.ResourceManager.CreateAssetAsync<StageDataContainer>("TestStage");

    SetupPlayers(stageDataContainer);
    SetupTriggers(stageDataContainer);
    SetupDynamicObstacles(stageDataContainer);
  }

  private void SetupPlayers(StageDataContainer stageData)
  {
    var leftPosition = stageData.LeftPlayerBeginTransform.position;
    var rightPosition = stageData.RightPlayerBeginTransform.position;
    playerSetupService.SetupAsync(new PlayerSetupService.SetupData(leftPosition,rightPosition)).Forget();
  }

  private void SetupTriggers(StageDataContainer stageData)
  {
    triggerTileSetupService.SetupAsync(new TriggerTileSetupService.SetupData(stageData.TriggerTiles)).Forget();
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

    GlobalManager.instance.SceneProvider.ReloadCurrentSceneAsync(
      token: token,
      onProgress: null,
      onComplete: null,
      waitUntilLoad: null).Forget();

    return UniTask.CompletedTask;
  }

  public void Complete()
  {
    playerSetupService.EnablePlayers(false);
    triggerTileSetupService.EnableAllTriggers(false);
    UnityEngine.Debug.Log("lehu~");
  }

  public void Fail(StageFailType failType)
  {
    throw new System.NotImplementedException();
  }
}
