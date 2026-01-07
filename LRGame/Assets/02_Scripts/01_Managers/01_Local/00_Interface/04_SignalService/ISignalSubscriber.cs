using UnityEngine.Events;

public interface ISignalSubscriber
{
  public void Subscribe(string key, UnityAction action);
  public void Unsubscribe(string key, UnityAction action);
}
