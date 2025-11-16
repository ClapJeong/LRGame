using System;
using UniRx;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace LR.UI
{
  [RequireComponent(typeof(Button))]
  public class BaseButtonView : MonoBehaviour, IButtonView
  {
    private Button button;
    private UnityAction onClick;
    private IDisposable onClickDisposable;

    private void OnEnable()
    {
      button = GetComponent<Button>();
      onClickDisposable = button
        .onClick
        .AsObservable()
        .Subscribe(_=>onClick?.Invoke());
    }

    public virtual void Dispose()
    {
      DisposeOnClick();
    }

    public virtual void DisposeOnClick()
      => onClickDisposable?.Dispose();

    public virtual void SetInteractable(bool interactable)
      => button.interactable = interactable;

    public virtual void SubscribeOnClick(UnityAction onClick)
      => this.onClick += onClick;

    public virtual void UnsubscribeOnClick(UnityAction onClick)
      => this.onClick -= onClick;
  }
}