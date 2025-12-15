using System;

namespace LR.Stage.Player
{
  public interface IPlayerStateController : IDisposable
  {
    public void ChangeState(PlayerStateType playerState);

    public void UndoState();

    public PlayerStateType GetCurrentState();
  }
}