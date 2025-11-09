using Cysharp.Threading.Tasks;
using UnityEngine;

public class LocalManager : MonoBehaviour
{
  public static LocalManager instance;

  private StageManager stageManager;
  public StageManager StageManager => stageManager;

  private void Awake()
  {
    instance = this;
    InitializeManagers();

    IStageCreator stageCreator = StageManager;
    stageCreator.CreateAsync().Forget();
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.F1))
    {
      IStageCreator stageCreator = StageManager;
      stageCreator.ReStartAsync().Forget();
    }
  }

  private void InitializeManagers()
  {
    stageManager = new StageManager();
  }
}
