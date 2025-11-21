using Unity.VisualScripting;
using UnityEngine.InputSystem;

public class PlayerIdleState : IPlayerState
{
  private readonly IPlayerMoveController moveController;
  private readonly IPlayerStateController playerStateController;


  public PlayerIdleState(IPlayerMoveController moveController, IPlayerStateController stateController)
  {
    this.moveController = moveController;
    this.playerStateController = stateController;
  }

  public void FixedUpdate()
  {
    moveController.ApplyMoveDeceleration();
  }

  public void OnEnter()
  {
    moveController.SubscribeOnPerformed(OnMovePerformed);
  }

  public void OnExit()
  {
    moveController.UnsubscribePerfoemd(OnMovePerformed);
  }

  private void OnMovePerformed(Direction direction)
  {
    playerStateController.ChangeState(PlayerStateType.Move);
  }
}