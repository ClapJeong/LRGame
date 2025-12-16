namespace LR.Stage.Player
{
  public interface IPlayerStateProvider
  {
    public PlayerStateType GetCurrentState();
  }
}