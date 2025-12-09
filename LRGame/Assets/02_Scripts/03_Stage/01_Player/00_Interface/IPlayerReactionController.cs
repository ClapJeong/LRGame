using System;
using UnityEngine;

public interface IPlayerReactionController : IDisposable
{
  public void Bounce(BounceData data, Vector3 direction);
}
