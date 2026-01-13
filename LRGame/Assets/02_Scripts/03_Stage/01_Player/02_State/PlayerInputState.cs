using UnityEngine;

namespace LR.Stage.Player
{
  public class PlayerInputState: IPlayerState
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerStateController stateController;
    private readonly IPlayerReactionController reactionController;
    private readonly IPlayerEnergyUpdater energyUpdater;
    private readonly IInputSequenceStopController inputSequenceStopController;

    public PlayerInputState(IPlayerMoveController moveController, IPlayerStateController stateController, IPlayerReactionController reactionController, IPlayerEnergyUpdater energyUpdater, IInputSequenceStopController inputSequenceStopController)
    {
      this.moveController = moveController;
      this.stateController = stateController;
      this.reactionController = reactionController;
      this.energyUpdater = energyUpdater;
      this.inputSequenceStopController = inputSequenceStopController;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveDeceleration();
      energyUpdater.UpdateEnergy(Time.fixedDeltaTime);

      if (reactionController.IsInputting == false)
      {
        stateController.ChangeState(PlayerStateType.Idle);
      }        
    }

    public void OnEnter()
    {
    }

    public void OnExit()
    {
      inputSequenceStopController.Stop();
    }
  }
}