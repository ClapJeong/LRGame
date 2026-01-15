
using LR.Stage.Player.Enum;
using UnityEngine;

namespace LR.Stage.Player
{
  public class PlayerEffectController : IPlayerEffectController
  {
    private readonly PlayerParticleSet particleSet;

    public PlayerEffectController(PlayerParticleSet particleSet)
    {
      this.particleSet = particleSet;
    }

    public void PlayEffect(PlayerEffect effect)
      => particleSet.GetParticle(effect).Play();    

    public void StopEffect(PlayerEffect effect)
      => particleSet.GetParticle(effect).Stop();

    public void SetMoveDirection(Vector2 direction)
    {
      particleSet
        .GetParticle(PlayerEffect.Move)
        .transform
        .rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, Mathf.Sign(direction.x) * 180.0f));
    }
  }
}
