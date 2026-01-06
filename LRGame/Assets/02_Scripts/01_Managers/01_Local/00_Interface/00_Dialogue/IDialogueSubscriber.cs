using UnityEngine.Events;

public interface IDialogueSubscriber
{
  public enum EventType
  {
    OnPlay,
    OnComplete,
    OnSkip,
    OnNextSequence,
  }

  public void SubscribeEvent(EventType eventType, UnityAction action);

  public void UnsubscribeEvent(EventType eventType, UnityAction action);
}
