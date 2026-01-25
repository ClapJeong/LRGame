using UnityEngine.Events;

public interface ISignalSubscriber
{
  public void SubscribeSignalActivate(string key, UnityAction activate);

  public void UnsubscribeSignalActivate(string key, UnityAction activate);

  public void SubscribeSignalDeactivate(string key, UnityAction deactivate);

  public void UnsubscribeSignalDeactivate(string key, UnityAction deactivate);

  public void SubscribeIDActivate(string key, int id, UnityAction<int> activate);

  public void UnsubscribeIDActivate(string key, int id, UnityAction<int> activate);

  public void SubscribeIDDeactivate(string key, int id, UnityAction<int> deactivate);

  public void UnsubscribeIDDeactivate(string key, int id, UnityAction<int> deactivate);
}
