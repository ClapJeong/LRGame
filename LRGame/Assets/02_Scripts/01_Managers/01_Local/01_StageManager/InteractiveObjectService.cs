using Cysharp.Threading.Tasks;
using LR.Stage.InteractiveObject;
using System.Collections.Generic;


public class InteractiveObjectService : IStageObjectSetupService<IInteractiveObject>, IStageObjectControlService<IInteractiveObject>
{
  public class Model
  {
    public List<IInteractiveObject> interactiveObjects;
    public IStageStateProvider stageStateProvider;

    public Model(List<IInteractiveObject> interactiveObjects, IStageStateProvider stageStateProvider)
    {
      this.interactiveObjects = interactiveObjects;
      this.stageStateProvider = stageStateProvider;
    }
  }

  private Model model;
  private bool isSetupComplete = false;

  public async UniTask<List<IInteractiveObject>> SetupAsync(object data, bool isEnableImmediately = false)
  {
    this.model = data as Model;

    foreach(var baseInteractiveObject in model.interactiveObjects)
      baseInteractiveObject.Initialize(model.stageStateProvider);

    isSetupComplete = true;
    return model.interactiveObjects;
  }

  public async UniTask AwaitUntilSetupCompleteAsync()
  {
    await UniTask.WaitUntil(() => isSetupComplete);
  }

  public void EnableAll(bool isEnable)
  {
    foreach (var baseInteractiveObject in model.interactiveObjects)
      baseInteractiveObject.Enable(isEnable);
  }

  public void Release()
  {
    
  }

  public void RestartAll()
  {
    foreach (var baseInteractiveObject in model.interactiveObjects)
      baseInteractiveObject.Restart();
  }  
}
