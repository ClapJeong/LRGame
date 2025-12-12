namespace LR.Stage.Player
{
  public class PlayerIdleState : IPlayerState
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerInputActionController inputActionController;
    private readonly IPlayerStateController playerStateController;
    private readonly IPlayerEnergyUpdater energyUpdater;


    public PlayerIdleState(
      IPlayerMoveController moveController, 
      IPlayerInputActionController inputActionController, 
      IPlayerStateController stateController,
      IPlayerEnergyUpdater energyUpdater)
    {
      this.moveController = moveController;
      this.inputActionController = inputActionController;
      this.playerStateController = stateController;
      this.energyUpdater = energyUpdater;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveDeceleration();
      energyUpdater.UpdateEnergy(UnityEngine.Time.fixedDeltaTime);
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
      playerStateController.ChangeState(PlayerStateType.Move);
    }
  }
}