using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace LR.UI
{
  [ExecuteInEditMode]
  [RequireComponent(typeof(LocalizeStringEvent))]
  public class BaseLocalizeStringView : MonoBehaviour, ILocalizeStringView
  {
    private LocalizeStringEvent stringEvent;

    private void OnEnable()
    {
      stringEvent = GetComponent<LocalizeStringEvent>();
    }

    public virtual void SetArgument(List<object> arguments)
    {
      stringEvent.StringReference.Arguments = arguments;
      stringEvent.RefreshString();
    }

    public virtual void SetEntry(string key)
    {
      stringEvent.SetEntry(key);
    }
  }
}