namespace LR.Stage.Player
{
  public class PlayerChargingState : IPlayerState
  {
    private readonly IPlayerStateController stateController;
    private readonly IPlayerInputActionController inputActionController;
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerGetter playerGetter;
    private readonly EnergyChargerData energyChargerData;
    private readonly PlayerType playerType;

    public PlayerChargingState(IPlayerStateController stateController, IPlayerInputActionController inputActionController, IPlayerMoveController moveController, IPlayerGetter playerGetter, EnergyChargerData energyChargerData, PlayerType playerType)
    {
      this.stateController = stateController;
      this.inputActionController = inputActionController;
      this.moveController = moveController;
      this.playerGetter = playerGetter;
      this.energyChargerData = energyChargerData;
      this.playerType = playerType;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveAcceleration();
    }

    public void OnEnter()
    {
      inputActionController.SubscribeOnPerformed(OnMovePerformed);
      inputActionController.SubscribeOnCanceled(OnMoveCanceled);
    }

    public void OnExit()
    {
      inputActionController.UnsubscribePerfoemd(OnMovePerformed);
      inputActionController.UnsubscribeCanceled(OnMoveCanceled);
    }

    private void OnMovePerformed(Direction direction)
    {
      playerGetter
        .GetPlayer(playerType.ParseOpposite())
        .GetEnergyController()
        .Restore(energyChargerData.ChargeValue);
    }

    private void OnMoveCanceled(Direction direction)
    {
      if (inputActionController.IsAnyInput() == false)
        stateController.ChangeState(PlayerStateType.Idle);
    }
  }
}