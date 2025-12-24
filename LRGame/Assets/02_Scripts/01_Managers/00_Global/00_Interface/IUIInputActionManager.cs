using System;
using System.Collections.Generic;
using UnityEngine.Events;

public interface IUIInputActionManager: IDisposable
{
  public void SubscribePerformedEvent(UIInputDirectionType type, UnityAction onPerformed);

  public void UnsubscribePerformedEvent(UIInputDirectionType type, UnityAction onPerformed);

  public void SubscribeCanceledEvent(UIInputDirectionType type, UnityAction onCanceled);

  public void UnsubscribeCanceledEvent(UIInputDirectionType type, UnityAction onCanceled);

  public void SubscribePerformedEvent(List<UIInputDirectionType> types, UnityAction onPerformed);

  public void UnsubscribePerformedEvent(List<UIInputDirectionType> types, UnityAction onPerformed);

  public void SubscribeCanceledEvent(List<UIInputDirectionType> types, UnityAction onCanceled);

  public void UnsubscribeCanceledEvent(List<UIInputDirectionType> types, UnityAction onCanceled);

  public bool IsPerforming(UIInputDirectionType type);

  public bool IsAnyPerforming(List<UIInputDirectionType> types);
}
