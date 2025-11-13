using UnityEngine;
using UnityEngine.Events;

public interface IStageController
{
  public enum StageEventType
  {
    Begin,
    Pause,
    Resume,
    Complete,
    LeftFailed,
    RightFailed,
  }
  public void Begin();

  public void Pause();

  public void Resume();

  public void Complete();

  public void OnLeftFailed();

  public void OnRightFailed();

  public void SubscribeOnEvent(StageEventType type, UnityAction action);

  public void UnsubscribeOnEvent(StageEventType type, UnityAction action);
}
