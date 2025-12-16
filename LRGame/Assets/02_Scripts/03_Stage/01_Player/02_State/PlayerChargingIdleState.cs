namespace LR.Stage.Player
{
  public class PlayerChargingIdleState: IPlayerState
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerInputActionController inputActionController;
    private readonly IPlayerStateController stateController;
    private readonly IPlayerReactionController reactionController;

    public PlayerChargingIdleState(
      IPlayerMoveController moveController,
      IPlayerInputActionController inputActionController,
      IPlayerStateController stateController,
      IPlayerReactionController reactionController)
    {
      this.moveController = moveController;
      this.inputActionController = inputActionController;
      this.stateController = stateController;
      this.reactionController = reactionController;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveDeceleration();

      if (reactionController.IsCharging == false)
        stateController.ChangeState(PlayerStateType.Idle);
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
      stateController.ChangeState(PlayerStateType.ChargingMove);
    }
  }
}