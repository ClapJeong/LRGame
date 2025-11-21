using Cysharp.Threading.Tasks;
using System;

public class PlayerBounceState : IPlayerState
{
  private readonly IPlayerMoveController moveController;
  private readonly IPlayerInputActionController inputActionController;
  private readonly IPlayerStateController stateController;
  private readonly BounceData bounceData;

  private CTSContainer cts=null;

  public PlayerBounceState(
    IPlayerMoveController moveController,
    IPlayerInputActionController inputActionController,
    IPlayerStateController stateController,
    BounceData bounceData)
  {
    this.moveController = moveController;
    this.inputActionController = inputActionController;
    this.stateController = stateController;
    this.bounceData = bounceData;
  }

  public void FixedUpdate()
  {
    moveController.ApplyMoveDeceleration();
  }

  public void OnEnter()
  {
    cts?.Dispose();
    cts = new();
    ChangeToIdleAsync().Forget();
  }

  public void OnExit()
  {
    cts.Dispose();
  }

  private async UniTask ChangeToIdleAsync()
  {
    try
    {
      await UniTask.WaitForSeconds(bounceData.StunDuration, false, PlayerLoopTiming.Update, cts.token);
      if(inputActionController.IsAnyInput())
        stateController.ChangeState(PlayerStateType.Move);
      else
        stateController.ChangeState(PlayerStateType.Idle);
    }
    catch (OperationCanceledException) { }
  }
}