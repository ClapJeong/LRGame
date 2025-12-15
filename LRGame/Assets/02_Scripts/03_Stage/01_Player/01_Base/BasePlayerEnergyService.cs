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
    private readonly ISpriteRendererView spriteRendererView;
    private readonly CancellationTokenSource cts = new();

    private float energy;
    private bool isUpdateEnergy = false;
    private bool isInvincible = false;    

    public BasePlayerEnergyService(PlayerEnergyData playerEnergyData, ISpriteRendererView spriteRendererView)
    {
      this.playerEnergyData = playerEnergyData;
      this.spriteRendererView = spriteRendererView;

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

    public void Restart()
    {
      energy = playerEnergyData.MaxEnergy;
      isUpdateEnergy = true;
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
      var prevEnergy = energy;
      energy = playerEnergyData.MaxEnergy;

      if (prevEnergy == 0)
        energyEvents.TryInvoke(IPlayerEnergyController.EventType.OnRevived);

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
        var durataion = 0.00f;
        var targetDuration = playerEnergyData.InvincibleDuration; 
        var interval = 0.15f;
        while(durataion< targetDuration)
        {
          spriteRendererView.SetAlpha(playerEnergyData.InvincibleBlinkAlphaMax);
          await UniTask.WaitForSeconds(interval, false, PlayerLoopTiming.Update, token);
          durataion += interval;
          token.ThrowIfCancellationRequested();

          spriteRendererView.SetAlpha(playerEnergyData.InvincibleBlinkAlphaMin);
          await UniTask.WaitForSeconds(interval, false, PlayerLoopTiming.Update, token);
          token.ThrowIfCancellationRequested();
          durataion += interval;
        }
        
        isInvincible = false;
      }
      catch (OperationCanceledException) { }
      finally
      {
        spriteRendererView.SetAlpha(1.0f);
      }
    }
  }
}