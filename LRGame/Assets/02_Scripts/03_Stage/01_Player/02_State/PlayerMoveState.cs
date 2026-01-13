using UnityEngine;

namespace LR.Stage.Player
{
  public class PlayerMoveState : IPlayerState
  {
    private readonly IPlayerStateController stateController;
    private readonly IPlayerInputActionController inputActionController;
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerEnergyUpdater energyUpdater;
    private readonly IPlayerReactionController reactionController;

    public PlayerMoveState(
      IPlayerMoveController moveController,
      IPlayerInputActionController inputActionController,
      IPlayerStateController stateController,
      IPlayerEnergyUpdater energyUpdater,
      IPlayerReactionController reactionController)
    {
      this.stateController = stateController;
      this.inputActionController = inputActionController;
      this.moveController = moveController;
      this.energyUpdater = energyUpdater;
      this.reactionController = reactionController;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveAcceleration();
      energyUpdater.UpdateEnergy(UnityEngine.Time.fixedDeltaTime);

      if (reactionController.IsInputting)
        stateController.ChangeState(PlayerStateType.Inputting);
    }

    public void OnEnter()
    {
      inputActionController.SubscribeOnCanceled(OnMoveCanceled);
    }

    public void OnExit()
    {
      inputActionController.UnsubscribeCanceled(OnMoveCanceled);
    }

    private void OnMoveCanceled(Direction direction)
    {
      if (inputActionController.IsAnyInput() == false)
        stateController.ChangeState(PlayerStateType.Idle);
    }
  }
}