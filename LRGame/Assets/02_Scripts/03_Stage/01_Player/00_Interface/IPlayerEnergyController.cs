using UnityEngine.Events;

namespace LR.Stage.Player
{
  public interface IPlayerEnergyController
  {
    public enum EventType
    {
      OnRestoreFull,
      OnExhausted,
    }

    public void Restore(float value);

    public void RestoreFull();

    public void Damage(float value, bool ignoreInvincible = false);    

    public float GetCurrentEnergy();

    public bool IsDead();

    public bool IsFull();

    public bool IsInvincible();

    public void SubscribeEvent(EventType type, UnityAction action);

    public void UnsubscribeEvent(EventType type, UnityAction action);
  }
}