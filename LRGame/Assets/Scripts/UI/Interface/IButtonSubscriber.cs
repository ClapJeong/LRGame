using UnityEngine;
using UnityEngine.Events;

public interface IButtonSubscriber
{
  public void SubscribeOnClick(UnityAction onClick);

  public void UnsubscribeOnClick(UnityAction onClick);
}
