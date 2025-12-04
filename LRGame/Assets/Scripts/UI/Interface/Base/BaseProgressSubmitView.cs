using System;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI
{
  public class BaseProgressSubmitView : MonoBehaviour, IUIProgressSubmitView
  {
    private class EventSet
    {
      public enum EventState
      {
        None,
        Progressing,
      }

      public UnityAction onPerformed;
      public UnityAction onCanceled;
      public UnityAction onComplete;
      public UnityAction<float> onProgress;
      public EventState state = EventState.None;
      public float progress = 0.0f;
    }

    private readonly Dictionary<Direction, EventSet> eventSets = new();
    private IDisposable updateDisposable;
    private UISO uiSO;

    private void Awake()
    {
      uiSO = GlobalManager.instance.Table.UISO;
    }

    private void OnDestroy()
    {
      updateDisposable?.Dispose();
    }

    public void Cancel(Direction direction)
    {
      if (eventSets.ContainsKey(direction) == false)
        return;

      var set  = eventSets[direction];
      if(set.state == EventSet.EventState.Progressing)
        set.onCanceled?.Invoke();

      set.state = EventSet.EventState.None;

      if (set.progress > 0.0f)
      {
        set.progress = 0.0f;
        set.onProgress?.Invoke(set.progress);
      }

      if (AnyProgressing() == false)
      {
        updateDisposable?.Dispose();
        updateDisposable = null;
      }
    }

    public void Perform(Direction direction)
    {
      if (eventSets.TryGetValue(direction, out var set))
      {
        set.onPerformed?.Invoke();
        set.state = EventSet.EventState.Progressing;

        if(updateDisposable == null)
        {
          updateDisposable = this.UpdateAsObservable().Subscribe(_ => UpdateProgress());
        }          
      }
    }

    #region Subscribes
    public void SubscribeOnCanceled(Direction direction, UnityAction onCanceled)
    {
      if (eventSets.ContainsKey(direction) == false)
        eventSets[direction] = new EventSet();

      eventSets[direction].onCanceled += onCanceled;
    }

    public void SubscribeOnComplete(Direction direction, UnityAction onComplete)
    {
      if (eventSets.ContainsKey(direction) == false)
        eventSets[direction] = new EventSet();

      eventSets[direction].onComplete += onComplete;
    }

    public void SubscribeOnPerformed(Direction direction, UnityAction onPerformed)
    {
      if (eventSets.ContainsKey(direction) == false)
        eventSets[direction] = new EventSet();

      eventSets[direction].onPerformed += onPerformed;
    }

    public void SubscribeOnProgress(Direction direction, UnityAction<float> onProgress)
    {
      if (eventSets.ContainsKey(direction) == false)
        eventSets[direction] = new EventSet();

      eventSets[direction].onProgress += onProgress;
    }

    public void UnsubscribeOnCanceled(Direction direction, UnityAction onCanceled)
    {
      if (eventSets.TryGetValue(direction, out var eventSet))
        eventSet.onCanceled -= onCanceled;
    }

    public void UnsubscribeOnComplete(Direction direction, UnityAction onComplete)
    {
      if (eventSets.TryGetValue(direction, out var eventSet))
        eventSet.onComplete -= onComplete;
    }

    public void UnsubscribeOnPerformed(Direction direction, UnityAction onPerformed)
    {
      if (eventSets.TryGetValue(direction, out var eventSet))
        eventSet.onPerformed -= onPerformed;
    }

    public void UnsubscribeOnProgress(Direction direction, UnityAction<float> onProgress)
    {
      if (eventSets.TryGetValue(direction, out var eventSet))
        eventSet.onProgress -= onProgress;
    }

    public void SubscribeOnCanceled(List<Direction> directions, UnityAction onCanceled)
    {
      foreach(var direction in directions)
        SubscribeOnCanceled(direction, onCanceled);
    }

    public void SubscribeOnComplete(List<Direction> directions, UnityAction onComplete)
    {
      foreach(var direction in directions)
        SubscribeOnComplete(direction, onComplete);
    }

    public void SubscribeOnPerformed(List<Direction> directions, UnityAction onPerformed)
    {
      foreach(var direction in directions)
        SubscribeOnPerformed(direction, onPerformed);
    }

    public void SubscribeOnProgress(List<Direction> directions, UnityAction<float> onProgress)
    {
      foreach(var direction in directions)
        SubscribeOnProgress(direction, onProgress);
    }

    public void UnsubscribeOnCanceled(List<Direction> directions, UnityAction onCanceled)
    {
      foreach(var direction in directions)
        UnsubscribeOnCanceled(direction, onCanceled);
    }

    public void UnsubscribeOnComplete(List<Direction> directions, UnityAction onComplete)
    {
      foreach(var direction in directions)
        UnsubscribeOnComplete(direction, onComplete);
    }

    public void UnsubscribeOnPerformed(List<Direction> directions, UnityAction onPerformed)
    {
      foreach(var direction in directions)
        UnsubscribeOnPerformed(direction, onPerformed);
    }

    public void UnsubscribeOnProgress(List<Direction> directions, UnityAction<float> onProgress)
    {
      foreach(var direction in directions)
        UnsubscribeOnProgress(direction, onProgress);
    }


    public void UnsubscribeAll()
    {
      foreach(var eventSet in eventSets.Values)
      {
        eventSet.onCanceled = null;
        eventSet.onComplete = null;
        eventSet.onProgress = null;
        eventSet.onPerformed = null;
      }  
    }
    #endregion

    public void ResetProgress(Direction direction)
    {
      if (eventSets.TryGetValue(direction, out var eventSet))
        eventSet.progress = 0.0f;
    }

    public void ResetAllProgress()
    {
      foreach(var eventSet in eventSets.Values)
        eventSet.progress = 0.0f;
    }


    private void UpdateProgress()
    {
      foreach (var eventSet in eventSets.Values)
      {
        if (eventSet.state == EventSet.EventState.None)
          continue;

        if(eventSet.progress < 1.0f)
        {
          eventSet.progress = Mathf.Min(eventSet.progress + uiSO.ProgressSubmitDuration * Time.deltaTime, 1.0f);
          eventSet.onProgress?.Invoke(eventSet.progress);

          if (eventSet.progress >= 1.0f)
            eventSet.onComplete?.Invoke();
        }        
      }
    }

    private bool AnyProgressing()
    {
      foreach (var e in eventSets.Values)
        if (e.state == EventSet.EventState.Progressing)
          return true;

      return false;
    }
  }
}