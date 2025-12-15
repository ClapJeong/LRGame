using System;
using UnityEngine;

namespace LR.Stage.Player
{
  public interface IPlayerReactionController : IDisposable
  {
    public void Bounce(BounceData data, Vector3 direction);

    public void SetCharging(bool isCharging);

    public bool GetIsCharging();
  }
}