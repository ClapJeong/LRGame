namespace LR.Stage.InteractiveObject
{
  public interface IInteractiveObject : IStageObjectController
  {
    public void Initialize(IStageStateProvider stageStateProvider);
  }
}
