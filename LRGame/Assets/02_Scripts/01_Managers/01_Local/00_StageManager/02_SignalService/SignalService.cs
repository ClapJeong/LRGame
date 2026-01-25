using LR.Stage.TriggerTile.Enum;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

public class SignalService : 
  ISignalKeyRegister, 
  ISignalConsumer, 
  ISignalSubscriber,
  ISignalIDLifeProvider
{
  private class Signal
  {
    public readonly UnityEvent activateEvent = new();
    public readonly UnityEvent deactivateEvent = new();
    public readonly UnityEvent<int> idActivateEvent = new();
    public readonly UnityEvent<int> idDeactivateEvent = new();

    private readonly Dictionary<int, bool> keys = new();
    public Dictionary<int, SignalLife> IDLifes { get; private set; } = new();

    public Signal(int id, SignalLife signalLife)
    {
      AddProvider(id, signalLife);
    }

    public void AddProvider(int id, SignalLife signalLife)
    {
      keys[id] = false;
      IDLifes[id] = signalLife;
    }

    public void Acquire(int id)
    {
      if (keys[id] == true)
        return;

      keys[id] = true;
      idActivateEvent?.Invoke(id);

      if (IsActivated())
        activateEvent?.Invoke();
    }

    public void Release(int id)
    {
      if (keys[id] == false)
        return;
      idDeactivateEvent?.Invoke(id);

      if(IsActivated())
        deactivateEvent?.Invoke();

      keys[id] = false;
    }

    public void ResetActiveCount()
    {
      var originKeys = keys.Keys.ToList();
      foreach(var key in originKeys)
        keys[key] = false;
    }

    private bool IsActivated()
    {
      foreach (var value in keys.Values)
        if (!value)
          return false;

      return true;
    }
  }

  private readonly Dictionary<string, Signal> signals = new();

  #region ISignalKeyRegister
  public void RegisterKey(string key, int id, SignalLife signalLife)
  {
    if (signals.TryGetValue(key, out var set))
      set.AddProvider(id, signalLife);
    else
      signals[key] = new Signal(id, signalLife);
  }
  #endregion

  #region ISignalConsumer
  public void AcquireSignal(string key, int id)
  {
    signals[key].Acquire(id);
  }

  public void ReleaseSignal(string key, int id)
  {
    signals[key].Release(id);
  }

  public void ResetAllSignal()
  {
    foreach (var eventSet in signals.Values)
      eventSet.ResetActiveCount();
  }
  #endregion

  #region ISignalSubscriber
  public void SubscribeSignalActivate(string key, UnityAction activate)
  {
    signals[key]
      .activateEvent
      .AddListener(activate);
  }

  public void UnsubscribeSignalActivate(string key, UnityAction activate)
  {
    signals[key]
      .activateEvent.
      RemoveListener(activate);
  }

  public void SubscribeSignalDeactivate(string key, UnityAction deactivate)
  {
    signals[key]
      .deactivateEvent
      .AddListener(deactivate);
  }

  public void UnsubscribeSignalDeactivate(string key, UnityAction deactivate)
  {
    signals[key]
      .deactivateEvent
      .RemoveListener(deactivate);
  }

  public void SubscribeIDActivate(string key, int id, UnityAction<int> activate)
  {
    signals[key]
      .idActivateEvent
      .AddListener(activate);
  }

  public void UnsubscribeIDActivate(string key, int id, UnityAction<int> activate)
  {
    signals[key]
      .idActivateEvent
      .RemoveListener(activate);
  }

  public void SubscribeIDDeactivate(string key, int id, UnityAction<int> deactivate)
  {
    signals[key]
      .idDeactivateEvent
      .AddListener(deactivate);
  }

  public void UnsubscribeIDDeactivate(string key, int id, UnityAction<int> deactivate)
  {
    signals[key]
      .idDeactivateEvent
      .RemoveListener(deactivate);
  }

  #endregion

  #region ISignalLifesProvider
  public Dictionary<int, SignalLife> GetSignalIDLifes(string key)
    => signals[key]
      .IDLifes;
  #endregion
}
