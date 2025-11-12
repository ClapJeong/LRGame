using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

public class ScriptableLocaleEventListener : MonoBehaviour
{
  public enum LocaleEventType
  {
    SetLocale,
  }

  [SerializeField] private ScriptableEventSO so;
  [SerializeField] private LocaleEventType type;
  [SerializeField] private UnityEvent<Locale> setLocaleEvent;

  private void OnEnable()
  {
    switch (type)
    {
      case LocaleEventType.SetLocale:
        so.RegisterSetLocaleEvent(this);
        break;

      default: throw new System.NotImplementedException();
    }
  }

  private void OnDisable()
  {
    switch (type)
    {
      case LocaleEventType.SetLocale:
        so.RegisterSetLocaleEvent(this);
        break;

      default: throw new System.NotImplementedException();
    }
  }

  public void Raise(Locale locale)
    => setLocaleEvent?.Invoke(locale);
}
