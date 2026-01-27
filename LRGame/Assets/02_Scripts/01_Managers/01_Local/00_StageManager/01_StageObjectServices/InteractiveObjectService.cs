using Cysharp.Threading.Tasks;
using LR.Stage.InteractiveObject;
using LR.Stage.StageDataContainer;
using System.Collections.Generic;


public class InteractiveObjectService : IStageObjectSetupService<IInteractiveObject>, IStageObjectControlService<IInteractiveObject>
{
  private readonly IStageStateProvider stageStateProvider;

  private List<IInteractiveObject> interactiveObjects;
  private bool isSetupComplete = false;

  public InteractiveObjectService(IStageStateProvider stageStateProvider)
  {
    this.stageStateProvider = stageStateProvider;
  }

  public async UniTask<List<IInteractiveObject>> SetupAsync(StageDataContainer stageDataContainer, bool isEnableImmediately = false)
  {
    interactiveObjects = stageDataContainer.InteractiveObject;

    foreach (var baseInteractiveObject in interactiveObjects)
      baseInteractiveObject.Initialize(stageStateProvider);

    isSetupComplete = true;
    return interactiveObjects;
  }

  public async UniTask AwaitUntilSetupCompleteAsync()
  {
    await UniTask.WaitUntil(() => isSetupComplete);
  }

  public void EnableAll(bool isEnable)
  {
    foreach (var baseInteractiveObject in interactiveObjects)
      baseInteractiveObject.Enable(isEnable);
  }

  public void Release()
  {
    
  }

  public void RestartAll()
  {
    foreach (var baseInteractiveObject in interactiveObjects)
      baseInteractiveObject.Restart();
  }  
}
