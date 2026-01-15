using Cysharp.Threading.Tasks;

public interface IStageStateHandler
{
  public void Begin();

  public void Pause();

  public void Resume();

  public void Complete();

  public UniTask RestartAsync();

  public void SetState(StageEnum.State state);
}
