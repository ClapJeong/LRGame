using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Stage.Player
{
  public class BasePlayerEnergyService : IPlayerEnergyController, IPlayerEnergyUpdater, IDisposable
  {
    private readonly PlayerEnergyData playerEnergyData;
    private readonly Dictionary<IPlayerEnergyController.EventType, UnityEvent> energyEvents = new();
    private readonly CancellationTokenSource cts = new();

    private float energy;
    private bool isUpdateEnergy = true;
    private bool isInvincible = false;    

    public BasePlayerEnergyService(PlayerEnergyData playerEnergyData)
    {
      this.playerEnergyData = playerEnergyData;

      energy = playerEnergyData.MaxEnergy;
    }

    #region IPlayerEnergyController
    public void Damage(float value, bool ignoreInvincible = false)
    {
      if (ignoreInvincible == false && isInvincible)
        return;

      energy = Mathf.Max(0.0f, energy -value);

      if (IsDead())
        energyEvents.TryInvoke(IPlayerEnergyController.EventType.OnExhausted);

      PlayInvincibleAsync().Forget();
    }

    public float GetCurrentEnergy()
      => energy;

    public bool IsDead()
      => energy <= 0.0f;

    public bool IsFull()
      => energy >= playerEnergyData.MaxEnergy;


    public void Restore(float value)
    {
      var prevEnergy = energy;

      energy = Mathf.Min(playerEnergyData.MaxEnergy, energy + value);

      if(prevEnergy == 0 &&
         energy > 0)
        energyEvents.TryInvoke(IPlayerEnergyController.EventType.OnRevived);

      if (IsFull())
        energyEvents.TryInvoke(IPlayerEnergyController.EventType.OnRestoreFull);
    }

    public void RestoreFull()
    {
      energy = playerEnergyData.MaxEnergy;

      energyEvents.TryInvoke(IPlayerEnergyController.EventType.OnRestoreFull);
    }

    public void SubscribeEvent(IPlayerEnergyController.EventType type, UnityAction action)
    {
      energyEvents.AddEvent(type, action);
    }

    public void UnsubscribeEvent(IPlayerEnergyController.EventType type, UnityAction action)
    {
      energyEvents.RemoveEvent(type, action);
    }

    public bool IsInvincible()
      => isInvincible;
    #endregion

    #region IPlayerEnergyUpdater
    public void UpdateEnergy(float deltaTime)
    {
      if(IsDead() || 
         isUpdateEnergy == false)
        return;

      energy = Mathf.Max(0.0f, energy - playerEnergyData.DecreasingValue * deltaTime);

      if (IsDead())
        energyEvents.TryInvoke(IPlayerEnergyController.EventType.OnExhausted);
    }

    public void Pause()
    {
      isUpdateEnergy = false;
    }

    public void Resume()
    {
      isUpdateEnergy = true;
    }
    #endregion

    public void Dispose()
    {
      cts.Cancel();
      cts.Dispose();
    }

    private async UniTask PlayInvincibleAsync()
    {
      isInvincible = true;
      var token = cts.Token;
      try
      {
        await UniTask.WaitForSeconds(playerEnergyData.InvincibleDuration, false, PlayerLoopTiming.Update, token);
        isInvincible = false;
      }
      catch (OperationCanceledException) { }
    }
  }
}