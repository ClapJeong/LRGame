using LR.Table.TriggerTile;
using UnityEngine;
using LR.Stage.Player.Enum;

namespace LR.Stage.Player
{
  public class PlayerReactionController : IPlayerReactionController
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerStateController stateController;

    private bool isCharging;
    public bool IsInputting => isCharging;

    public PlayerReactionController(IPlayerMoveController moveController, IPlayerStateController stateController)
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
      stateController.ChangeState(PlayerState.Stun);
    }

    public void Dispose()
    {
    }
  }
}