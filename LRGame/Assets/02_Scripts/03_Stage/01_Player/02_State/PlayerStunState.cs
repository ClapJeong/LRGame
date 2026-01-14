using Cysharp.Threading.Tasks;
using System;
using System.Threading;

namespace LR.Stage.Player
{
  public class PlayerStunState : IPlayerState
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerStateController stateController;
    private readonly IPlayerEnergyUpdater energyUpdater;
    private readonly IPlayerAnimatorController animatorController;
    private readonly IPlayerInputActionController inputActionController;
    private readonly PlayerStunData stunData;

    private readonly CTSContainer cts = new();

    public PlayerStunState(
      IPlayerMoveController moveController, 
      IPlayerStateController stateController, 
      IPlayerEnergyUpdater energyUpdater, 
      IPlayerAnimatorController animatorController,
      IPlayerInputActionController inputActionController,
      PlayerStunData stunData)
    {
      this.moveController = moveController;
      this.stateController = stateController;
      this.energyUpdater = energyUpdater;
      this.animatorController = animatorController;
      this.inputActionController = inputActionController;
      this.stunData = stunData;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveDeceleration();
      energyUpdater.UpdateEnergy(UnityEngine.Time.fixedDeltaTime);
    }

    public void OnEnter()
    {
      animatorController.Play(AnimatorHash.Player.Clip.Stun);
      cts.Dispose();
      cts.Create();
      AwaitStunAsync(cts.token).Forget();
    }

    public void OnExit()
    {
      cts.Dispose();
      cts.Create();
    }

    private async UniTask AwaitStunAsync(CancellationToken token)
    {
      try
      {
        await UniTask.WaitForSeconds(stunData.StunDuration, false, PlayerLoopTiming.Update, token);

        var nextState = inputActionController.IsAnyInput() ? PlayerStateType.Move : PlayerStateType.Idle;
        stateController.ChangeState(nextState);
      }
      catch (OperationCanceledException) { }
    }

  }
}
