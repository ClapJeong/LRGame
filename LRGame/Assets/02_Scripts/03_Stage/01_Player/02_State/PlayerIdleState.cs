using UnityEngine;

namespace LR.Stage.Player
{
  public class PlayerIdleState : IPlayerState
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerInputActionController inputActionController;
    private readonly IPlayerStateController stateController;
    private readonly IPlayerEnergyUpdater energyUpdater;
    private readonly IPlayerReactionController reactionController;
    private readonly IPlayerAnimatorController animatorController;

    public PlayerIdleState(
      IPlayerMoveController moveController, 
      IPlayerInputActionController inputActionController, 
      IPlayerStateController stateController,
      IPlayerEnergyUpdater energyUpdater,
      IPlayerReactionController reactionController,
      IPlayerAnimatorController animatorController)
    {
      this.moveController = moveController;
      this.inputActionController = inputActionController;
      this.stateController = stateController;
      this.energyUpdater = energyUpdater;
      this.reactionController = reactionController;
      this.animatorController = animatorController;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveDeceleration();      
      energyUpdater.UpdateEnergy(UnityEngine.Time.fixedDeltaTime);

      if (reactionController.IsInputting)
        stateController.ChangeState(PlayerStateType.Inputting);
    }

    public void OnEnter()
    {
      animatorController.Play(AnimatorHash.Player.Clip.Idle);
      inputActionController.SubscribeOnPerformed(OnMovePerformed);
    }

    public void OnExit()
    {
      inputActionController.UnsubscribePerfoemd(OnMovePerformed);
    }

    private void OnMovePerformed(Direction direction)
    {
      stateController.ChangeState(PlayerStateType.Move);
    }
  }
}