using LR.Stage.TriggerTile.Enum;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

public class SignalService : 
  ISignalKeyRegister, 
  ISignalConsumer, 
  ISignalSubscriber,
  ISignalLifesProvider
{
  private class EventSet
  {
    public readonly UnityEvent onActive = new();
    public readonly UnityEvent onDeactive = new();
    
    private readonly Dictionary<int, bool> keys = new();
    public Dictionary<int, SignalLife> KeyLifes { get; private set; } = new();

    public EventSet(int id, SignalLife signalLife)
    {
      AddProvider(id, signalLife);
    }

    public void AddProvider(int id, SignalLife signalLife)
    {
      keys[id] = false;
      KeyLifes[id] = signalLife;
    }

    public void Acquire(int id)
    {
      if (keys[id] == true)
        return;

      keys[id] = true;

      if (IsActivated())
        onActive?.Invoke();
    }

    public void Release(int id)
    {
      if (keys[id] == false)
        return;

      if(IsActivated())
        onDeactive?.Invoke();

      keys[id] = false;
    }

    public void ResetActiveCount()
    {
      var originKeys = keys.Keys;
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

  private readonly Dictionary<string, EventSet> eventSets = new();

  #region ISignalKeyRegister
  public void RegisterKey(string key, int id, SignalLife signalLife)
  {
    if (eventSets.TryGetValue(key, out var set))
      set.AddProvider(id, signalLife);
    else
      eventSets[key] = new EventSet(id, signalLife);
  }
  #endregion

  #region ISignalConsumer
  public void AcquireSignal(string key, int id)
  {
    eventSets[key].Acquire(id);
  }

  public void ReleaseSignal(string key, int id)
  {
    eventSets[key].Release(id);
  }

  public void ResetAllSignal()
  {
    foreach (var eventSet in eventSets.Values)
      eventSet.ResetActiveCount();
  }
  #endregion

  #region ISignalSubscriber
  public void SubscribeActivate(string key, UnityAction activate)
  {
    eventSets[key]
      .onActive
      .AddListener(activate);
  }

  public void UnsubscribeActivate(string key, UnityAction activate)
  {
    eventSets[key]
      .onActive.
      RemoveListener(activate);
  }

  public void SubscribeDeactivate(string key, UnityAction deactivate)
  {
    eventSets[key]
      .onDeactive
      .AddListener(deactivate);
  }

  public void UnsubscribeDeactivate(string key, UnityAction deactivate)
  {
    eventSets[key]
      .onDeactive
      .RemoveListener(deactivate);
  }
  #endregion

  #region ISignalLifesProvider
  public List<SignalLife> GetSignalLifes(string key)
    => eventSets[key]
      .KeyLifes
      .Values
      .ToList();
  #endregion
}
