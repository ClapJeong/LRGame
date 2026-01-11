using System;
using System.Collections.Generic;
using UnityEngine.Events;

public interface IUIInputActionManager: IDisposable
{
  public void SubscribePerformedEvent(UIInputDirection type, UnityAction onPerformed);

  public void UnsubscribePerformedEvent(UIInputDirection type, UnityAction onPerformed);

  public void SubscribeCanceledEvent(UIInputDirection type, UnityAction onCanceled);

  public void UnsubscribeCanceledEvent(UIInputDirection type, UnityAction onCanceled);

  public void SubscribePerformedEvent(List<UIInputDirection> types, UnityAction onPerformed);

  public void UnsubscribePerformedEvent(List<UIInputDirection> types, UnityAction onPerformed);

  public void SubscribeCanceledEvent(List<UIInputDirection> types, UnityAction onCanceled);

  public void UnsubscribeCanceledEvent(List<UIInputDirection> types, UnityAction onCanceled);

  public bool IsPerforming(UIInputDirection type);

  public bool IsAnyPerforming(List<UIInputDirection> types);
}
