using System;
using UnityEngine;
using UnityEngine.Events;

public interface IButtonController : IDisposable
{
  public void SetInteractable(bool interactable);

  public void SubscribeOnClick(UnityAction onClick);

  public void UnsubscribeOnClick(UnityAction onClick);

  public void DisposeOnClick();
}
