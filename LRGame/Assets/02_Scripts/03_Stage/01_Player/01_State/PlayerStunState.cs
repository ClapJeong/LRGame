using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using LR.Stage.Player.Enum;

namespace LR.Stage.Player
{
  public class PlayerStunState : IPlayerState
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerStateController stateController;
    private readonly IPlayerEnergyUpdater energyUpdater;
    private readonly IPlayerAnimatorController animatorController;
    private readonly IPlayerInputActionController inputActionController;
    private readonly IPlayerEffectController effectController;
    private readonly PlayerStunData stunData;

    private float duration = 0.0f;

    public PlayerStunState(
      IPlayerMoveController moveController, 
      IPlayerStateController stateController, 
      IPlayerEnergyUpdater energyUpdater, 
      IPlayerAnimatorController animatorController,
      IPlayerInputActionController inputActionController,
      IPlayerEffectController effectController,
      PlayerStunData stunData)
    {
      this.moveController = moveController;
      this.stateController = stateController;
      this.energyUpdater = energyUpdater;
      this.animatorController = animatorController;
      this.inputActionController = inputActionController;
      this.effectController = effectController;
      this.stunData = stunData;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveDeceleration();
      energyUpdater.UpdateEnergy(UnityEngine.Time.fixedDeltaTime);
      duration -= UnityEngine.Time.fixedDeltaTime;

      if (duration <= 0.0f)
        ChangeToNextState();
    }

    public void OnEnter()
    {
      duration = stunData.StunDuration;
      animatorController.Play(AnimatorHash.Player.Clip.Stun);
      effectController.PlayEffect(PlayerEffect.Stun);
    }

    public void OnExit()
    {
      effectController.StopEffect(PlayerEffect.Stun);
    }

    private void ChangeToNextState()
    {
      var nextState = inputActionController.IsAnyInput() ? PlayerState.Move : PlayerState.Idle;
      stateController.ChangeState(nextState);
    }
  }
}
