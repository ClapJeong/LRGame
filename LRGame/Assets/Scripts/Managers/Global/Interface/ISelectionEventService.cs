using UnityEngine;
using UnityEngine.Events;

public interface IUISelectionEventService
{
  public enum EventType
  {
    OnEnter,
    OnExit,
  }

  public void SetSelectedObject(RectTransform rectTransform);

  public void SubscribeEvent(EventType type, UnityAction<RectTransform> action);

  public void UnsubscribeEvent(EventType type, UnityAction<RectTransform> action);
}