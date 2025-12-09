using Cysharp.Threading.Tasks;
using System;
using UnityEngine;

public class BasePlayerReactionController : IPlayerReactionController
{
  private readonly IPlayerMoveController moveController;
  private readonly IPlayerStateController stateController;

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

  public void Dispose()
  {
  }
}