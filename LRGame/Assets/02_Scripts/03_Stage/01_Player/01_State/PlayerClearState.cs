using UnityEngine;

namespace LR.Stage.Player
{

  public class PlayerClearState : IPlayerState
  {
    private readonly IPlayerMoveController moveController;

    public PlayerClearState(IPlayerMoveController moveController)
    {
      this.moveController = moveController;
    }

    public void FixedUpdate()
    {

    }

    public void OnEnter()
    {
      moveController.SetLinearVelocity(Vector3.zero);
    }

    public void OnExit()
    {

    }
  }
}