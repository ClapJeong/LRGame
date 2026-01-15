using LR.Table.TriggerTile;
using UnityEngine;
using LR.Stage.Player.Enum;

namespace LR.Stage.Player
{
  public class PlayerReactionController : IPlayerReactionController
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerStateController stateController;
    private readonly IPlayerStateProvider stateProvider;

    private bool isCharging;
    public bool IsInputting => isCharging;

    private bool IsFreezeState => stateProvider.GetCurrentState() == PlayerState.Freeze;

    public PlayerReactionController(IPlayerMoveController moveController, IPlayerStateController stateController, IPlayerStateProvider stateProvider)
    {
      this.moveController = moveController;
      this.stateController = stateController;
      this.stateProvider = stateProvider;
    }

    public void Bounce(BounceData data, Vector3 direction)
    {
      if (IsFreezeState)
        return;

      moveController.SetLinearVelocity(direction * data.Force);
    }

    public void SetInputting(bool isCharging)
      => this.isCharging = isCharging;

    public void Stun()
    {
      if (IsFreezeState)
        return;

      stateController.ChangeState(PlayerState.Stun);
    }

    public void Freeze()
    {
      stateController.ChangeState(PlayerState.Freeze);
    }

    public void Dispose()
    {
    }    
  }
}