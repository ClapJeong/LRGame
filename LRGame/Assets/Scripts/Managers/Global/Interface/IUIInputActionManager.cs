using System;
using UnityEngine.Events;

public interface IUIInputActionManager: IDisposable
{
  public void SubscribePerformedEvent(UIInputActionType type, UnityAction onPerformed);

  public void UnsubscribePerformedEvent(UIInputActionType type, UnityAction onPerformed);

  public void SubscribeCanceledEvent(UIInputActionType type, UnityAction onCanceled);

  public void UnsubscribeCanceledEvent(UIInputActionType type, UnityAction onCanceled);
}
