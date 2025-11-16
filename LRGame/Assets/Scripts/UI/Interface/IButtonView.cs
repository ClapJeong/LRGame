using System;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI
{
  public interface IButtonView : IDisposable
  {
    public void SetInteractable(bool interactable);

    public void SubscribeOnClick(UnityAction onClick);

    public void UnsubscribeOnClick(UnityAction onClick);

    public void DisposeOnClick();
  }
}