using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using static LR.Stage.Player.IPlayerEnergySubscriber;

namespace LR.Stage.Player
{
  public class PlayerEnergyService : 
    IPlayerEnergyController, 
    IPlayerEnergyUpdater,
    IPlayerEnergySubscriber,
    IPlayerEnergyProvider, 
    IDisposable
  {
    private readonly PlayerEnergyData playerEnergyData;    
    private readonly SpriteRenderer spriteRenderer;
    private readonly IPlayerStateProvider stateProvider;
    private readonly IPlayerEffectController effectController;
    private IPlayerReactionController reactionController;

    private readonly Dictionary<StateEvent, UnityEvent> stateEvents = new();
    private readonly Dictionary<ValueEvent, UnityEvent<float>> valueEvents = new();
    private readonly CancellationTokenSource cts = new();
    private readonly Dictionary<float, UnityEvent> aboveEvents = new();
    private readonly Dictionary<float, UnityEvent> belowEvents = new();

    private bool IsEnergyWorking => stateProvider.GetCurrentState() == Enum.PlayerState.Freeze ||
                                    stateProvider.GetCurrentState() == Enum.PlayerState.Clear;

    private float energy;
    private float prevEnergy;
    private bool isUpdateEnergy = false;
    private bool isInvincible = false;

    #region IPlayerEnergyProvider
    public bool IsInvincible => isInvincible;

    public bool IsDead => energy <= 0.0f;

    public bool IsFull => energy >= playerEnergyData.MaxEnergy;

    public float CurrentEnergy => energy;

    public float CurrentNormalized => energy / playerEnergyData.MaxEnergy;
    #endregion

    public PlayerEnergyService(
      PlayerEnergyData playerEnergyData, 
      SpriteRenderer spriteRenderer, 
      IPlayerStateProvider stateProvider,
      IPlayerEffectController effectController)
    {
      this.playerEnergyData = playerEnergyData;
      this.spriteRenderer = spriteRenderer;
      this.stateProvider = stateProvider;
      this.effectController = effectController;

      energy = playerEnergyData.MaxEnergy;
    }

    public void DelayInject(IPlayerReactionController reactionController)
    {
      this.reactionController = reactionController;
    }

    #region IPlayerEnergyController
    public void Damage(float value, bool ignoreInvincible = false)
    {
      if (ignoreInvincible == false && isInvincible)
        return;

      if (IsEnergyWorking)
        return;

      var beforeNormalized = CurrentNormalized;
      energy = Mathf.Max(0.0f, energy -value);

      valueEvents.TryInvoke(ValueEvent.Damaged, beforeNormalized - CurrentNormalized);

      if (IsDead)
        OnExhauset();

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
      if (IsEnergyWorking)
        return;

      var prevNormalized = CurrentNormalized;
      var prevEnergy = energy;
      energy = Mathf.Min(playerEnergyData.MaxEnergy, energy + value);

      valueEvents.TryInvoke(ValueEvent.Restored, CurrentNormalized - prevNormalized);

      if(prevEnergy == 0 &&
         energy > 0)
        stateEvents.TryInvoke(IPlayerEnergySubscriber.StateEvent.OnRevived);

      if (IsFull)
        stateEvents.TryInvoke(IPlayerEnergySubscriber.StateEvent.OnRestoreFull);
    }

    public void RestoreFull()
    {
      if (IsEnergyWorking)
        return;

      var prevEnergy = energy;
      energy = playerEnergyData.MaxEnergy;

      if (prevEnergy == 0)
        stateEvents.TryInvoke(IPlayerEnergySubscriber.StateEvent.OnRevived);

      stateEvents.TryInvoke(IPlayerEnergySubscriber.StateEvent.OnRestoreFull);
    }
        #endregion

    #region IPlayerEnergyUpdater
    public void UpdateEnergy(float deltaTime)
    {
      if(IsDead || isUpdateEnergy == false)
        return;

      if (IsEnergyWorking)
        return;

      prevEnergy = energy;
      var decreaseValue = reactionController.IsDecaying ? playerEnergyData.DecayDecreasingValue 
                                                        : playerEnergyData.DecreasingValue;
      var currentEnergy = Mathf.Max(0.0f, energy - decreaseValue * deltaTime);

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
        OnExhauset();
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
    public void SubscribeStateEvent(IPlayerEnergySubscriber.StateEvent type, UnityAction action)
      => stateEvents.AddEvent(type, action);

    public void UnsubscribeStateEvent(IPlayerEnergySubscriber.StateEvent type, UnityAction action)
      => stateEvents.RemoveEvent(type, action);

    public void SubscribeThreshhold(Threshhold type, float normalizedValue, UnityAction action)
    {
      switch (type)
      {
        case Threshhold.Above:
          aboveEvents.AddEvent(normalizedValue, action);
          break;

        case Threshhold.Below:
          belowEvents.AddEvent(normalizedValue, action);
          break;
      }
    }

    public void UnsubscribeThreshhold(Threshhold type, float normalizedValue, UnityAction action)
    {
      switch (type)
      {
        case Threshhold.Above:
          aboveEvents.RemoveEvent(normalizedValue, action);
          break;

        case Threshhold.Below:
          belowEvents.RemoveEvent(normalizedValue, action);
          break;
      }
    }

    private static bool IsCrossedDown(float prev, float curr, float normalized)
       => prev > normalized && curr <= normalized;

    private static bool IsCrossedUp(float prev, float curr, float normalized)
      => prev < normalized && curr >= normalized;

    public void SubscribeValueEvent(ValueEvent valueEvent, UnityAction<float> action)
      => valueEvents.AddEvent(valueEvent, action);

    public void UnsubscribeValueEvent(ValueEvent valueEvent, UnityAction<float> action)
      => valueEvents.RemoveEvent(valueEvent, action);
    #endregion

    private void OnExhauset()
    {
      stateEvents.TryInvoke(IPlayerEnergySubscriber.StateEvent.OnExhausted);
      effectController.PlayEffect(Enum.PlayerEffect.Exhaust);
    }

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