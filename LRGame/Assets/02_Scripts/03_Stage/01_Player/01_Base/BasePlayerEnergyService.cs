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
    }

    #region IPlayerEnergyController
    public void Damage(float value, bool ignoreInvincible = false)
    {
      if (ignoreInvincible == false && isInvincible)
        return;

      energy = Mathf.Max(0.0f, energy -value);

      if (IsDead() && 
          energyEvents.TryGetValue(IPlayerEnergyController.EventType.OnExhausted, out var unityEvent))
        unityEvent.Invoke();

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
      energy = Mathf.Min(playerEnergyData.MaxEnergy, energy + value);

      if(IsFull() &&
         energyEvents.TryGetValue(IPlayerEnergyController.EventType.OnRestoreFull, out var unityEvent))
        unityEvent.Invoke();
    }

    public void RestoreFull()
    {
      energy = playerEnergyData.MaxEnergy;

      if(energyEvents.TryGetValue(IPlayerEnergyController.EventType.OnRestoreFull, out var unityEvent))
        unityEvent.Invoke();
    }

    public void SubscribeEvent(IPlayerEnergyController.EventType type, UnityAction action)
    {
      if (energyEvents.TryGetValue(type, out var unityEvent) == false)
        unityEvent = new UnityEvent();
      unityEvent.AddListener(action);
    }

    public void UnsubscribeEvent(IPlayerEnergyController.EventType type, UnityAction action)
    {
      if(energyEvents.TryGetValue(type, out var unityEvent))
        unityEvent.RemoveListener(action);
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

      if(IsDead() &&
         energyEvents.TryGetValue(IPlayerEnergyController.EventType.OnExhausted, out var unityEvent))
        unityEvent.Invoke();
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