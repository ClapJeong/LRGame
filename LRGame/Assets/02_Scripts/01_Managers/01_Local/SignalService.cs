using System.Collections.Generic;
using UnityEngine.Events;

public class SignalService : ISignalKeyRegister, ISignalConsumer, ISignalSubscriber
{
  private class EventSet
  {
    public readonly UnityEvent unityEvent = new();
    public int ProviderCount { get; private set; } = 1;

    private int activeCount;

    public void AddProvider()
      => ProviderCount++;

    public void Acquire()
    {
      activeCount++;
      if (activeCount == ProviderCount)
        unityEvent?.Invoke();
    }

    public void Release()
    {
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
  #endregion

  #region ISignalSubscriber
  public void Subscribe(string key, UnityAction action)
  {
    eventSets[key].unityEvent.AddListener(action);
  }

  public void Unsubscribe(string key, UnityAction action)
  {
    eventSets[key].unityEvent.RemoveListener(action);
  }
  #endregion
}
