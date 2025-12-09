using Unity.VisualScripting;
using UnityEngine.InputSystem;

public class PlayerIdleState : IPlayerState
{
  private readonly IPlayerMoveController moveController;
  private readonly IPlayerInputActionController inputActionController;
  private readonly IPlayerStateController playerStateController;


  public PlayerIdleState(IPlayerMoveController moveController, IPlayerInputActionController inputActionController, IPlayerStateController stateController)
  {
    this.moveController = moveController;
    this.inputActionController = inputActionController;
    this.playerStateController = stateController;
  }

  public void FixedUpdate()
  {
    moveController.ApplyMoveDeceleration();
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