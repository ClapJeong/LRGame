using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "ScriptableEventSO", menuName = "SO/ScriptableEvent")]
public class ScriptableEventSO : ScriptableObject
{
  private List<ScriptableLocaleEventListener> setLocaleListeners = new ();

  public void OnLocaleChanged(Locale locale)
  {
    for (int i = 0; i < setLocaleListeners.Count; i++)
      setLocaleListeners[i].Raise(locale);
  }

  public void RegisterSetLocaleEvent(ScriptableLocaleEventListener listener)
    => setLocaleListeners.Add(listener);

  public void UnregisterSetLocaleEvent(ScriptableLocaleEventListener listener)
    => setLocaleListeners.Remove(listener);
}
