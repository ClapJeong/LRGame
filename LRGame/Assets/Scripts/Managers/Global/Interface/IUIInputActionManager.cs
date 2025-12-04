using System;
using System.Collections.Generic;
using UnityEngine.Events;

public interface IUIInputActionManager: IDisposable
{
  public void SubscribePerformedEvent(UIInputActionType type, UnityAction onPerformed);

  public void UnsubscribePerformedEvent(UIInputActionType type, UnityAction onPerformed);

  public void SubscribeCanceledEvent(UIInputActionType type, UnityAction onCanceled);

  public void UnsubscribeCanceledEvent(UIInputActionType type, UnityAction onCanceled);

  public void SubscribePerformedEvent(List<UIInputActionType> types, UnityAction onPerformed);

  public void UnsubscribePerformedEvent(List<UIInputActionType> types, UnityAction onPerformed);

  public void SubscribeCanceledEvent(List<UIInputActionType> types, UnityAction onCanceled);

  public void UnsubscribeCanceledEvent(List<UIInputActionType> types, UnityAction onCanceled);
}
