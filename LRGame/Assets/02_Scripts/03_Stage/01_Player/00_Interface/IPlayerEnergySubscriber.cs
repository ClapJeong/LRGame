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
    public void SubscribeEvent(EventType type, UnityAction action);

    public void UnsubscribeEvent(EventType type, UnityAction action);
  }
}