using UnityEngine.Events;

namespace LR.Stage.Player
{
  public interface IPlayerEnergyController
  {
    public void Restore(float value);

    public void RestoreFull();

    public void Damage(float value, bool ignoreInvincible = false);

    public void Restart();    
  }
}