namespace LR.Stage.Player
{
  public class PlayerIdleState : IPlayerState
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerInputActionController inputActionController;
    private readonly IPlayerStateController stateController;
    private readonly IPlayerEnergyUpdater energyUpdater;
    private readonly IPlayerReactionController reactionController;

    public PlayerIdleState(
      IPlayerMoveController moveController, 
      IPlayerInputActionController inputActionController, 
      IPlayerStateController stateController,
      IPlayerEnergyUpdater energyUpdater,
      IPlayerReactionController reactionController)
    {
      this.moveController = moveController;
      this.inputActionController = inputActionController;
      this.stateController = stateController;
      this.energyUpdater = energyUpdater;
      this.reactionController = reactionController;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveDeceleration();      
      energyUpdater.UpdateEnergy(UnityEngine.Time.fixedDeltaTime);

      if (reactionController.IsCharging)
        stateController.ChangeState(PlayerStateType.Inputting);
    }

    public void OnEnter()
    {      
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