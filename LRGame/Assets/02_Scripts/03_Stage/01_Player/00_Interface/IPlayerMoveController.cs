using System;
using UnityEngine;

namespace LR.Stage.Player
{
  public interface IPlayerMoveController : IDisposable
  {
    public void SetLinearVelocity(Vector3 velocity);

    public void ApplyMoveAcceleration();

    public void ApplyMoveDeceleration();

    public Vector2 GetCurrentDirection();
  }
}