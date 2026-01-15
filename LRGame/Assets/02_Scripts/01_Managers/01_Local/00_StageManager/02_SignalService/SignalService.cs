using System.Collections.Generic;
using UnityEngine.Events;

public class SignalService : ISignalKeyRegister, ISignalConsumer, ISignalSubscriber
{
  private class EventSet
  {
    public readonly UnityEvent onActive = new();
    public readonly UnityEvent onDeactive = new();
    public int ProviderCount { get; private set; } = 1;

    private int activeCount;

    public void AddProvider()
      => ProviderCount++;

    public void Acquire()
    {
      activeCount++;
      if (activeCount == ProviderCount)
        onActive?.Invoke();
    }

    public void Release()
    {
      if (activeCount == ProviderCount) 
        onDeactive?.Invoke();
      activeCount--;
    }

    public void ResetActiveCount()
    {
      activeCount = 0;
    }
  }

  private readonly Dictionary<string, EventSet> eventSets = new();

  #region ISignalKeyRegister
  public void RegisterKey(string key)
  {
    if (eventSets.TryGetValue(key, out var set))
      set.AddProvider();
    else
      eventSets[key] = new EventSet();
  }
  #endregion

  #region ISignalConsumer
  public void AcquireSignal(string key)
  {
    eventSets[key].Acquire();
  }

  public void ReleaseSignal(string key)
  {
    eventSets[key].Release();
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
    eventSets[key].onActive.AddListener(activate);
  }

  public void UnsubscribeActivate(string key, UnityAction activate)
  {
    eventSets[key].onActive.RemoveListener(activate);
  }

  public void SubscribeDeactivate(string key, UnityAction deactivate)
  {
    eventSets[key].onDeactive.AddListener(deactivate);
  }

  public void UnsubscribeDeactivate(string key, UnityAction deactivate)
  {
    eventSets[key].onDeactive.RemoveListener(deactivate);
  }

  #endregion
}
