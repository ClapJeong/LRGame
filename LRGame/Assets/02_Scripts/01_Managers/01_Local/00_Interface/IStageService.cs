using Cysharp.Threading.Tasks;
using UnityEngine.Events;

public interface IStageService
{
  public enum StageEventType
  {
    Begin,
    Pause,
    Resume,
    Complete,
    LeftFailed,
    RightFailed,
    Restart
  }

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

  public void OnLeftFailed();

  public void OnRightFailed();

  public UniTask RestartAsync();

  public void SubscribeOnEvent(StageEventType type, UnityAction action);

  public void UnsubscribeOnEvent(StageEventType type, UnityAction action);

  public void SetState(State state);

  public State GetState();
}
