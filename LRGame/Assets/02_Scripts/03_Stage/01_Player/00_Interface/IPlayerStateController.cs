using Cysharp.Threading.Tasks;
using System;
using System.Threading;

public interface IPlayerStateController : IDisposable
{
  public void ChangeState(PlayerStateType playerState);
}