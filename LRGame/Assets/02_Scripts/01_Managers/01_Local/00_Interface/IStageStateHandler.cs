using Cysharp.Threading.Tasks;

public interface IStageStateHandler
{
  public enum State
  {
    Ready,
    Playing,
    Success,
    Fail,
    Pause,
  }

  public void Begin();

  public void Pause();

  public void Resume();

  public void Complete();

  public UniTask RestartAsync();

  public void SetState(State state);

  public State GetState();
}
