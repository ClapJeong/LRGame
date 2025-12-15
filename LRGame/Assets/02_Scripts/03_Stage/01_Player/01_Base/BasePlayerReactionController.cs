using UnityEngine;

namespace LR.Stage.Player
{
  public class BasePlayerReactionController : IPlayerReactionController
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerStateController stateController;

    private bool isCharging;

    public BasePlayerReactionController(IPlayerMoveController moveController, IPlayerStateController stateController)
    {
      this.moveController = moveController;
      this.stateController = stateController;
    }

    public void Bounce(BounceData data, Vector3 direction)
    {
      moveController.SetLinearVelocity(direction * data.Force);
      stateController.ChangeState(PlayerStateType.Bounce);
    }

    public void SetCharging(bool isCharging)
      => this.isCharging = isCharging;

    public bool GetIsCharging()
      => isCharging;

    public void Dispose()
    {
    }
  }
}