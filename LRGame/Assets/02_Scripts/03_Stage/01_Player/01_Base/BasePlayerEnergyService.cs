using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using static LR.Stage.Player.IPlayerEnergySubscriber;

namespace LR.Stage.Player
{
  public class BasePlayerEnergyService : 
    IPlayerEnergyController, 
    IPlayerEnergyUpdater,
    IPlayerEnergySubscriber,
    IPlayerEnergyProvider, 
    IDisposable
  {
    private readonly PlayerEnergyData playerEnergyData;
    private readonly Dictionary<IPlayerEnergySubscriber.EventType, UnityEvent> energyEvents = new();
    private readonly SpriteRenderer spriteRenderer;
    private readonly CancellationTokenSource cts = new();
    private readonly Dictionary<float, UnityEvent> aboveEvents = new();
    private readonly Dictionary<float, UnityEvent> belowEvents = new();

    private float energy;
    private float prevEnergy;
    private bool isUpdateEnergy = false;
    private bool isInvincible = false;

    #region IPlayerEnergyProvider
    public bool IsInvincible => isInvincible;

    public bool IsDead => energy <= 0.0f;

    public bool IsFull => energy >= playerEnergyData.MaxEnergy;

    public float CurrentEnergy => energy;
    #endregion

    public BasePlayerEnergyService(PlayerEnergyData playerEnergyData, SpriteRenderer spriteRenderer)
    {
      this.playerEnergyData = playerEnergyData;
      this.spriteRenderer = spriteRenderer;

      energy = playerEnergyData.MaxEnergy;
    }

    #region IPlayerEnergyController
    public void Damage(float value, bool ignoreInvincible = false)
    {
      if (ignoreInvincible == false && isInvincible)
        return;

      energy = Mathf.Max(0.0f, energy -value);

      if (IsDead)
        energyEvents.TryInvoke(IPlayerEnergySubscriber.EventType.OnExhausted);

      PlayInvincibleAsync().Forget();
    }

    public void Restart()
    {
      prevEnergy= playerEnergyData.MaxEnergy;
      energy = playerEnergyData.MaxEnergy;
      isUpdateEnergy = true;
    }

    public void Restore(float value)
    {
      var prevEnergy = energy;
      energy = Mathf.Min(playerEnergyData.MaxEnergy, energy + value);

      if(prevEnergy == 0 &&
         energy > 0)
        energyEvents.TryInvoke(IPlayerEnergySubscriber.EventType.OnRevived);

      if (IsFull)
        energyEvents.TryInvoke(IPlayerEnergySubscriber.EventType.OnRestoreFull);
    }

    public void RestoreFull()
    {
      var prevEnergy = energy;
      energy = playerEnergyData.MaxEnergy;

      if (prevEnergy == 0)
        energyEvents.TryInvoke(IPlayerEnergySubscriber.EventType.OnRevived);

      energyEvents.TryInvoke(IPlayerEnergySubscriber.EventType.OnRestoreFull);
    }
        #endregion

    #region IPlayerEnergySubscriber
    public void SubscribeEvent(IPlayerEnergySubscriber.EventType type, UnityAction action)
    {
      energyEvents.AddEvent(type, action);
    }

    public void UnsubscribeEvent(IPlayerEnergySubscriber.EventType type, UnityAction action)
    {
      energyEvents.RemoveEvent(type, action);
    }
    #endregion

    #region IPlayerEnergyUpdater
    public void UpdateEnergy(float deltaTime)
    {
      if(IsDead ||
         isUpdateEnergy == false)
        return;

      prevEnergy = energy;
      var currentEnergy = Mathf.Max(0.0f, energy - playerEnergyData.DecreasingValue * deltaTime);

      var prevNormalized = prevEnergy / playerEnergyData.MaxEnergy;
      var currentNormalized = currentEnergy / playerEnergyData.MaxEnergy;
      if (currentNormalized < prevNormalized)
      {
        foreach (var pair in belowEvents)
          if (IsCrossedDown(prevNormalized, currentNormalized, pair.Key))
            pair.Value?.Invoke();        
      }
      else if (currentNormalized > prevNormalized)
      {
        foreach (var pair in aboveEvents)
          if(IsCrossedUp(prevNormalized, currentNormalized, pair.Key))
            pair.Value?.Invoke();        
      }
      energy = currentEnergy;

      if (IsDead)
        energyEvents.TryInvoke(IPlayerEnergySubscriber.EventType.OnExhausted);
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

    #region IPlayerEnergySubscriber
    public void SubscribeOnChanged(OnChangedType type, float normalizedValue, UnityAction action)
    {
      switch (type)
      {
        case OnChangedType.Above:
          aboveEvents.AddEvent(normalizedValue, action);
          break;

        case OnChangedType.Below:
          belowEvents.AddEvent(normalizedValue, action);
          break;
      }
    }

    public void UnsubscribeOnChanged(OnChangedType type, float normalizedValue, UnityAction action)
    {
      switch (type)
      {
        case OnChangedType.Above:
          aboveEvents.RemoveEvent(normalizedValue, action);
          break;

        case OnChangedType.Below:
          belowEvents.RemoveEvent(normalizedValue, action);
          break;
      }
    }

    private static bool IsCrossedDown(float prev, float curr, float normalized)
       => prev > normalized && curr <= normalized;

    private static bool IsCrossedUp(float prev, float curr, float normalized)
      => prev < normalized && curr >= normalized;

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
          spriteRenderer.SetAlpha(playerEnergyData.InvincibleBlinkAlphaMax);
          await UniTask.WaitForSeconds(interval, false, PlayerLoopTiming.Update, token);
          durataion += interval;
          token.ThrowIfCancellationRequested();

          spriteRenderer.SetAlpha(playerEnergyData.InvincibleBlinkAlphaMin);
          await UniTask.WaitForSeconds(interval, false, PlayerLoopTiming.Update, token);
          token.ThrowIfCancellationRequested();
          durataion += interval;
        }
        
        isInvincible = false;
      }
      catch (OperationCanceledException) { }
      finally
      {
        spriteRenderer.SetAlpha(1.0f);
      }
    }
  }
}