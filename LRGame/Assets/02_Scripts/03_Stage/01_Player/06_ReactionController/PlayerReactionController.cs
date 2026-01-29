using LR.Table.TriggerTile;
using UnityEngine;
using LR.Stage.Player.Enum;

namespace LR.Stage.Player
{
  public class PlayerReactionController : IPlayerReactionController
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerStateController stateController;
    private readonly IPlayerStateProvider stateProvider;
    private readonly IPlayerEnergyController energyController;
    private readonly IPlayerEffectController effectController;

    private bool isCharging;
    public bool IsInputting => isCharging;

    private bool isDecaying;
    public bool IsDecaying => isDecaying;

    private bool IsFreezeState => stateProvider.GetCurrentState() == Enum.PlayerState.Freeze ||
                                    stateProvider.GetCurrentState() == Enum.PlayerState.Clear;

    public PlayerReactionController(
      IPlayerMoveController moveController, 
      IPlayerStateController stateController, 
      IPlayerStateProvider stateProvider,
      IPlayerEnergyController energyController,
      IPlayerEffectController effectController)
    {
      this.moveController = moveController;
      this.stateController = stateController;
      this.stateProvider = stateProvider;
      this.energyController = energyController;
      this.effectController = effectController;
    }

    public void Bounce(BounceData data, Vector3 direction)
    {
      if (IsFreezeState)
        return;

      moveController.SetLinearVelocity(direction * data.Force);
    }

    public void SetInputting(bool isCharging)
      => this.isCharging = isCharging;

    public void Stun()
    {
      if (IsFreezeState)
        return;

      stateController.ChangeState(PlayerState.Stun);
    }

    public void Freeze()
    {
      stateController.ChangeState(PlayerState.Freeze);
    }

    public void Clear()
    {
      stateController.ChangeState(PlayerState.Clear);
    }

    public void RestoreEnergy(float value)
    {
      energyController.Restore(value);
    }

    public void RestoreEnergyFull()
    {
      energyController.RestoreFull(); 
    }

    public void DamageEnergy(float value, bool ignoreInvincible = false)
    {
      energyController.Damage(value, ignoreInvincible);
    }

    public void Decaying(bool isDecaying)
    {
      this.isDecaying = isDecaying;
      if (isDecaying)
        effectController.PlayEffect(PlayerEffect.Decay);
      else
        effectController.StopEffect(PlayerEffect.Decay);
    }

    public void Dispose()
    {
    }    
  }
}