using LR.UI;
using UnityEngine;
using UnityEngine.Events;

public interface IUISelectionEventService
{
  public enum EventType
  {
    OnEnter,
    OnExit,
  }

  public void SetSelectedObject(GameObject gameObject);

  public void SubscribeEvent(EventType type, UnityAction<IRectView> action);

  public void UnsubscribeEvent(EventType type, UnityAction<IRectView> action);
}