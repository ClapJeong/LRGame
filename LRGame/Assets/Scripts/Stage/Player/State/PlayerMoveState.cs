using UnityEngine;

public class PlayerMoveState : IPlayerState
{
  private readonly IPlayerStateController stateController;
  private readonly IPlayerInputActionController inputActionController;
  private readonly IPlayerMoveController moveController;  

  public PlayerMoveState(     
    IPlayerMoveController moveController,
    IPlayerInputActionController inputActionController,
    IPlayerStateController stateController)
  {
    this.stateController = stateController;
    this.inputActionController = inputActionController;
    this.moveController = moveController;
  }

  public void FixedUpdate()
  {
    moveController.ApplyMoveAcceleration();
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
    if(inputActionController.IsAnyInput() == false)
      stateController.ChangeState(PlayerStateType.Idle);
  }
}