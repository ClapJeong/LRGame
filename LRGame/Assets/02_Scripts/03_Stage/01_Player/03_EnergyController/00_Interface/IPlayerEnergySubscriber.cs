using UnityEngine.Events;

namespace LR.Stage.Player
{
  public interface IPlayerEnergySubscriber
  {
    public enum EventType
    {
      OnRestoreFull,
      OnExhausted,
      OnRevived,
    }

    public enum OnChangedType
    {
      Above,
      Below,
    }

    public void SubscribeEvent(EventType type, UnityAction action);

    public void UnsubscribeEvent(EventType type, UnityAction action);

    public void SubscribeOnChanged(OnChangedType type, float normalizedValue, UnityAction action);

    public void UnsubscribeOnChanged(OnChangedType type, float normalizedValue, UnityAction action);
  }
}