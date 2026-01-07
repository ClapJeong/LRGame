using LR.Table.TriggerTile;
using System;
using UnityEngine;

namespace LR.Stage.Player
{
  public interface IPlayerReactionController : IDisposable
  {
    public bool IsInputting { get; }

    public void Bounce(BounceData data, Vector3 direction);

    public void SetInputting(bool isInputting);
  }
}