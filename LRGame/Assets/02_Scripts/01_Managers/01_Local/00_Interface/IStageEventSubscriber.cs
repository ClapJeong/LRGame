using UnityEngine.Events;

public interface IStageEventSubscriber
{
  public enum StageEventType
  {
    Begin,
    Pause,
    Resume,
    Complete,
    LeftExhausted,
    RightExhausted,
    LeftRevived,
    RightRevived,
    AllExhausted,
    LeftClearEnter,
    LeftClearExit,
    RightClearEnter,
    RightClearExit,
    Restart,
  }

  public void SubscribeOnEvent(StageEventType type, UnityAction action);

  public void UnsubscribeOnEvent(StageEventType type, UnityAction action);
}