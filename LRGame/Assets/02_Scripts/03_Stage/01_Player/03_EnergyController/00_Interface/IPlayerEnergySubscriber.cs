using UnityEngine.Events;

namespace LR.Stage.Player
{
  public interface IPlayerEnergySubscriber
  {
    public enum StateEvent
    {
      OnRestoreFull,
      OnExhausted,
      OnRevived,
    }

    public enum ValueEvent
    {
      Damaged,
      Restored,
    }

    public enum Threshhold
    {
      Above,
      Below,
    }

    public void SubscribeStateEvent(StateEvent stateEvent, UnityAction action);

    public void UnsubscribeStateEvent(StateEvent stateEvent, UnityAction action);

    public void SubscribeThreshhold(Threshhold threshhold, float normalizedValue, UnityAction action);

    public void UnsubscribeThreshhold(Threshhold threshhold, float normalizedValue, UnityAction action);

    public void SubscribeValueEvent(ValueEvent valueEvent, UnityAction<float> action);

    public void UnsubscribeValueEvent(ValueEvent valueEvent, UnityAction<float> action);
  }
}