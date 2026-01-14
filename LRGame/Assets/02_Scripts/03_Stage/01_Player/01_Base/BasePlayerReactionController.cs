using LR.Table.TriggerTile;
using UnityEngine;

namespace LR.Stage.Player
{
  public class BasePlayerReactionController : IPlayerReactionController
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerStateController stateController;

    private bool isCharging;
    public bool IsInputting => isCharging;

    public BasePlayerReactionController(IPlayerMoveController moveController, IPlayerStateController stateController)
    {
      this.moveController = moveController;
      this.stateController = stateController;
    }

    public void Bounce(BounceData data, Vector3 direction)
    {
      moveController.SetLinearVelocity(direction * data.Force);
    }

    public void SetInputting(bool isCharging)
      => this.isCharging = isCharging;

    public void Stun()
    {
      stateController.ChangeState(PlayerStateType.Stun);
    }

    public void Dispose()
    {
    }
  }
}