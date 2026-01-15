using LR.Stage.Player.Enum;
using UnityEngine;

namespace LR.Stage.Player
{
  public interface IPlayerEffectController
  {
    public void PlayEffect(PlayerEffect effect);

    public void StopEffect(PlayerEffect effect);

    public void SetMoveDirection(Vector2 direction);
  }
}
