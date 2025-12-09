using System;
using UnityEngine;

public interface IPlayerMoveController : IDisposable
{
  public void SetLinearVelocity(Vector3 velocity);

  public void ApplyMoveAcceleration();

  public void ApplyMoveDeceleration();
}
