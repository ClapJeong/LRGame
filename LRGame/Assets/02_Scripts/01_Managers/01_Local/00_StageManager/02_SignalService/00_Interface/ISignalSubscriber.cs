using LR.Stage.TriggerTile.Enum;
using UnityEngine.Events;

public interface ISignalSubscriber
{
  public void SubscribeActivate(string key, UnityAction activate);

  public void UnsubscribeActivate(string key, UnityAction activate);

  public void SubscribeDeactivate(string key, UnityAction deactivate);

  public void UnsubscribeDeactivate(string key, UnityAction deactivate);
}
