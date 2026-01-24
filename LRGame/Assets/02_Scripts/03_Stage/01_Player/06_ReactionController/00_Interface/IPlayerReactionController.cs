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

    public void Stun();

    public void Freeze();

    public void Clear();

    public void RestoreEnergy(float value);

    public void RestoreEnergyFull();

    public void DamageEnergy(float value, bool ignoreInvincible = false);
  }
}