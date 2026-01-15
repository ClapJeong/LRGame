namespace LR.Stage.Player
{
  public class PlayerFreezeState : IPlayerState
  {
    private readonly IPlayerMoveController moveController;
    private readonly IPlayerAnimatorController animatorController;

    public PlayerFreezeState(IPlayerMoveController moveController, IPlayerAnimatorController animatorController)
    {
      this.moveController = moveController;
      this.animatorController = animatorController;
    }

    public void FixedUpdate()
    {
      moveController.ApplyMoveDeceleration();
    }

    public void OnEnter()
    {
      
    }

    public void OnExit()
    {
      
    }
  }
}
