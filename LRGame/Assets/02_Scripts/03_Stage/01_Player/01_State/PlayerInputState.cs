using UnityEngine;
using LR.Stage.Player.Enum;

namespace LR.Stage.Player
{
  public class PlayerInputState: IPlayerState
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerStateController stateController;
    private readonly IPlayerReactionController reactionController;
    private readonly IPlayerEnergyUpdater energyUpdater;
    private readonly IInputSequenceStopController inputSequenceStopController;
    private readonly IPlayerAnimatorController animatorController;
    private readonly IPlayerEffectController effectController;

    public PlayerInputState(
      IPlayerMoveController moveController, 
      IPlayerStateController stateController, 
      IPlayerReactionController reactionController, 
      IPlayerEnergyUpdater energyUpdater, 
      IPlayerAnimatorController animatorController,
      IInputSequenceStopController inputSequenceStopController,
      IPlayerEffectController effectController)
    {
      this.moveController = moveController;
      this.stateController = stateController;
      this.reactionController = reactionController;
      this.energyUpdater = energyUpdater;
      this.animatorController = animatorController;
      this.inputSequenceStopController = inputSequenceStopController;
      this.effectController = effectController;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveDeceleration();
      energyUpdater.UpdateEnergy(Time.fixedDeltaTime);

      if (reactionController.IsInputting == false)
      {
        stateController.ChangeState(PlayerState.Idle);
      }        
    }

    public void OnEnter()
    {
      animatorController.Play(AnimatorHash.Player.Clip.Inputing);
      effectController.PlayEffect(PlayerEffect.Inputing);
    }

    public void OnExit()
    {
      inputSequenceStopController.Stop();
      effectController.StopEffect(PlayerEffect.Inputing);
    }
  }
}