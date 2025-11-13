using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;

namespace ScriptableEvent
{
  [CreateAssetMenu(fileName = "ScriptableEventSO", menuName = "SO/ScriptableEvent")]
  public class ScriptableEventSO : ScriptableObject
  {
    private class StageListnerSet
    {
      public static implicit operator bool(StageListnerSet s) => s != null;

      public readonly StageEventType type;
      public readonly List<ScriptableStageEventListener> listeners;

      public StageListnerSet(StageEventType type,ScriptableStageEventListener listener)
      {
        this.type = type;
        this.listeners = new() { listener };
      }

      public void Add(ScriptableStageEventListener listener)
        => listeners.Add(listener);

      public void Remove(ScriptableStageEventListener listener)
        =>listeners.Remove(listener);

      public void Raise()
      {
        for(int i=0;i<listeners.Count; i++)
          listeners[i].Raise();
      }
    }
    private readonly List<ScriptableLocaleEventListener> setLocaleListeners = new();
    private readonly List<StageListnerSet> stageListeners = new();
    public static ScriptableEventSO instance;

    private void OnEnable()
    {
      if (instance == null)
        instance = this;
    }

    #region Locale
    public void OnLocaleChanged(Locale locale)
    {
      for (int i = 0; i < setLocaleListeners.Count; i++)
        setLocaleListeners[i].Raise(locale);
    }

    public void RegisterSetLocaleEvent(ScriptableLocaleEventListener listener)
      => setLocaleListeners.Add(listener);

    public void UnregisterSetLocaleEvent(ScriptableLocaleEventListener listener)
      => setLocaleListeners.Remove(listener);
    #endregion

    #region Satge
    public void OnStageEvent(StageEventType stageEventType)
    {
      var set = stageListeners.FirstOrDefault(s => s.type == stageEventType);
      set?.Raise();
    }

    public void RegisterStageEvent(StageEventType stageEventType, ScriptableStageEventListener listener)
    {
      var set = stageListeners.FirstOrDefault(s => s.type == stageEventType);

      if (set)
        set.Add(listener);
      else
        stageListeners.Add(new StageListnerSet(stageEventType, listener));
    }

    public void UnregisterStageEvent(StageEventType stageEventType, ScriptableStageEventListener listener)
    {
      var set = stageListeners.FirstOrDefault(s => s.type == stageEventType);
      set?.Remove(listener);
    }
    #endregion
  }
}