using LR.Stage.Player.Enum;
using UnityEngine;

namespace LR.Stage.Player
{
  public class PlayerParticleSet : MonoBehaviour
  {
    [field: SerializeField] public ParticleSystem Move { get; private set;}
    [field: SerializeField] public ParticleSystem Inputing { get; private set; }
    [field: SerializeField] public ParticleSystem Stun { get; private set; }
    [field: SerializeField] public ParticleSystem Exhaust {  get; private set; }

    public ParticleSystem GetParticle(PlayerEffect effect)
      => effect switch
      {
        PlayerEffect.Move => Move,
        PlayerEffect.Inputing => Inputing,
        PlayerEffect.Stun => Stun,
        PlayerEffect.Exhaust => Exhaust,
        _ => throw new System.NotImplementedException(),
      };
  }
}
