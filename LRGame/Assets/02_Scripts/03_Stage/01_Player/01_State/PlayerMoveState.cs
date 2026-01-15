using UnityEngine;
using LR.Stage.Player.Enum;

namespace LR.Stage.Player
{
  public class PlayerMoveState : IPlayerState
  {
    private readonly IPlayerStateController stateController;
    private readonly IPlayerInputActionController inputActionController;
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerEnergyUpdater energyUpdater;
    private readonly IPlayerReactionController reactionController;
    private readonly IPlayerAnimatorController animatorController;
    private readonly IPlayerEffectController effectController;

    public PlayerMoveState(
      IPlayerMoveController moveController,
      IPlayerInputActionController inputActionController,
      IPlayerStateController stateController,
      IPlayerEnergyUpdater energyUpdater,
      IPlayerReactionController reactionController,
      IPlayerAnimatorController animatorController,
      IPlayerEffectController effectController)
    {
      this.stateController = stateController;
      this.inputActionController = inputActionController;
      this.moveController = moveController;
      this.energyUpdater = energyUpdater;
      this.reactionController = reactionController;
      this.animatorController = animatorController;
      this.effectController = effectController;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveAcceleration();
      effectController.SetMoveDirection(moveController.GetCurrentDirection());

      var currentDirection = moveController.GetCurrentDirection();
      UpdateParameter(currentDirection);

      energyUpdater.UpdateEnergy(UnityEngine.Time.fixedDeltaTime);

      if (reactionController.IsInputting)
        stateController.ChangeState(PlayerState.Inputting);
    }

    public void OnEnter()
    {
      var currentDirection = moveController.GetCurrentDirection();
      UpdateParameter(currentDirection);
      animatorController.Play(AnimatorHash.Player.Clip.MoveBlend);
      inputActionController.SubscribeOnCanceled(OnMoveCanceled);
      effectController.PlayEffect(PlayerEffect.Move);
    }

    public void OnExit()
    {
      UpdateParameter(Vector2.zero);
      inputActionController.UnsubscribeCanceled(OnMoveCanceled);
      effectController.StopEffect(PlayerEffect.Move);
    }

    private void OnMoveCanceled(Direction direction)
    {
      if (inputActionController.IsAnyInput() == false)
        stateController.ChangeState(PlayerState.Idle);
    }

    private void UpdateParameter(Vector2 direction)
    {
      var horizontal = direction.x == 0.0f ? 0.0f : Mathf.Sign(direction.x);
      animatorController.SetFloat(AnimatorHash.Player.Parameter.Horizontal, horizontal);

      var vertical = direction.y == 0.0f ? 0.0f : Mathf.Sign(direction.y);
      animatorController.SetFloat(AnimatorHash.Player.Parameter.Vertical, vertical);
    }
  }
}