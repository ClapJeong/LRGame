using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class UILobbyStageButtonView : MonoBehaviour, IButtonController, ILocalizeStringController
{
  [SerializeField] private Button button;
  [SerializeField] private LocalizeStringEvent localizeStringEvent;

  private UnityAction onClick;
  private IDisposable disposable;

  private void Awake()
  {
   disposable = button
      .OnClickAsObservable()
      .Subscribe(_=>onClick?.Invoke())
      .AddTo(gameObject);
  }

  public void Dispose()
  {
    DisposeOnClick();
  }

  public void DisposeOnClick()
  {
    disposable.Dispose();
  }

  public void SetArgument(List<object> arguments)
  {
    localizeStringEvent.StringReference.Arguments = arguments;
    localizeStringEvent.RefreshString();
  }

  public void SetEntry(string key)
    =>localizeStringEvent.SetEntry(key);

  public void SetInteractable(bool interactable)
    => button.interactable = interactable;

  public void SubscribeOnClick(UnityAction onClick)
  {
    this.onClick += onClick;
  }

  public void UnsubscribeOnClick(UnityAction onClick)
  {
    this.onClick -= onClick;
  }
}
