using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI
{
  public abstract class BaseUIView : MonoBehaviour, IUIView
  {
    protected UIVisibleState visibleState = UIVisibleState.None;

    protected Dictionary<UIViewEventType, UnityEvent> events = new();

    public UIVisibleState GetVisibleState()
      => visibleState;

    public abstract UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default);

    public abstract UniTask HideAsync(bool isImmediately = false, CancellationToken token = default);

    public void SubscribeEvent(UIViewEventType eventType, UnityAction action)
    {
      if(events.TryGetValue(eventType, out var unityEvent))
      {
        unityEvent.AddListener(action);
      }
      else
      {
        events[eventType] = new UnityEvent();
        events[eventType].AddListener(action);
      }
    }

    public void UnsubscribeEvent(UIViewEventType eventType, UnityAction action)
    {
      if(events.TryGetValue(eventType, out var unityEvent))
        unityEvent.RemoveListener(action);
    }

    public void DestroySelf()
      => Destroy(gameObject);
  }
}