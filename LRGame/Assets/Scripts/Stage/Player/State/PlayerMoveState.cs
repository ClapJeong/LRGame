using UnityEngine;

public class PlayerMoveState : IPlayerState
{
  private readonly IPlayerStateController stateController;
  private readonly IPlayerMoveController moveController;


  public PlayerMoveState(
    IPlayerStateController stateController, 
    IPlayerMoveController moveController)
  {
    this.stateController = stateController;
    this.moveController = moveController;
  }

  public void FixedUpdate()
  {
    moveController.ApplyMoveAcceleration();
  }

  public void OnEnter()
  {
    moveController.SubscribeOnCanceled(OnMoveCanceled);
  }

  public void OnExit()
  {
    moveController.UnsubscribeCanceled(OnMoveCanceled);
  }

  private void OnMoveCanceled(Direction direction)
  {
    stateController.ChangeState(PlayerStateType.Idle);
  }
}