using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
  public static StageManager instance;

  [SerializeField] private PlayerSetupService playerSetupService;

  private void Awake()
  {
    instance = this;
  }

  private async void Start()
  {
    var stageDataContainer = await GameManager.instance.ResourceManager.CreateAssetAsync<StageDataContainer>("TestStage");
    SetupStage(stageDataContainer);
  }

  public void SetupStage(StageDataContainer stageData)
  {
    SetupPlayers(stageData);
    SetupTriggers(stageData);
    SetupDynamicObstacles(stageData);
  }

  private void SetupPlayers(StageDataContainer stageData)
  {
    var leftPosition = stageData.LeftPlayerBeginTransform.position;
    var rightPosition = stageData.RightPlayerBeginTransform.position;
    playerSetupService.InitializePositions(leftPosition, rightPosition);
    playerSetupService.SetupAsync().Forget();
  }

  private void SetupTriggers(StageDataContainer stageData)
  {
    foreach (var trigger in stageData.TriggerTiles)
    {

    }
  }

  private void SetupDynamicObstacles(StageDataContainer stageData)
  {
    foreach (var dynamicObstalce in stageData.DynamicObstacles)
    {

    }
  }
}
