using System;
using UnityEngine;

namespace LR.Stage.Player
{
  public interface IPlayerReactionController : IDisposable
  {
    public bool IsCharging { get; }

    public void Bounce(BounceData data, Vector3 direction);

    public void SetCharging(bool isCharging);
  }
}