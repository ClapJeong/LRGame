using System;

namespace LR.Stage.Player
{
  public interface IPlayerStateController : IDisposable
  {
    public void ChangeState(PlayerStateType playerState);
  }
}