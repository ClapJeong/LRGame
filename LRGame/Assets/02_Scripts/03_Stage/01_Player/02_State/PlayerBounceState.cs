using Cysharp.Threading.Tasks;
using LR.Table.TriggerTile;
using System;

namespace LR.Stage.Player
{
  public class PlayerBounceState : IPlayerState
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerInputActionController inputActionController;
    private readonly IPlayerStateController stateController;
    private readonly IPlayerEnergyUpdater energyUpdater;
    private readonly IPlayerReactionController reactionController;
    private readonly BounceData bounceData;

    private CTSContainer cts = null;

    public PlayerBounceState(
      IPlayerMoveController moveController,
      IPlayerInputActionController inputActionController,
      IPlayerStateController stateController,
      IPlayerEnergyUpdater energyUpdater,
      IPlayerReactionController reactionController,
      BounceData bounceData)
    {
      this.moveController = moveController;
      this.inputActionController = inputActionController;
      this.stateController = stateController;
      this.energyUpdater = energyUpdater;
      this.reactionController = reactionController;
      this.bounceData = bounceData;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveDeceleration();
      energyUpdater.UpdateEnergy(UnityEngine.Time.fixedDeltaTime);
    }

    public void OnEnter()
    {
      reactionController.SetInputting(false);
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
        if (inputActionController.IsAnyInput())
          stateController.ChangeState(PlayerStateType.Move);
        else
          stateController.ChangeState(PlayerStateType.Idle);
      }
      catch (OperationCanceledException) { }
    }
  }
}