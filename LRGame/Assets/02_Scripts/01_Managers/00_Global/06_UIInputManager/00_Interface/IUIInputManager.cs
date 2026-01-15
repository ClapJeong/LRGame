using System;
using System.Collections.Generic;
using UnityEngine.Events;
using LR.UI.Enum;

public interface IUIInputManager: IDisposable
{
  public void SubscribePerformedEvent(InputDirection type, UnityAction onPerformed);

  public void UnsubscribePerformedEvent(InputDirection type, UnityAction onPerformed);

  public void SubscribeCanceledEvent(InputDirection type, UnityAction onCanceled);

  public void UnsubscribeCanceledEvent(InputDirection type, UnityAction onCanceled);

  public void SubscribePerformedEvent(List<InputDirection> types, UnityAction onPerformed);

  public void UnsubscribePerformedEvent(List<InputDirection> types, UnityAction onPerformed);

  public void SubscribeCanceledEvent(List<InputDirection> types, UnityAction onCanceled);

  public void UnsubscribeCanceledEvent(List<InputDirection> types, UnityAction onCanceled);

  public bool IsPerforming(InputDirection type);

  public bool IsAnyPerforming(List<InputDirection> types);
}
