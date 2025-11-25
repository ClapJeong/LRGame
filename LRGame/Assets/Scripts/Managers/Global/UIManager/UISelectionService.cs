using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UISelectionService : IUISelectionEventService
{
  private UnityEvent<RectTransform> onSelectEnter = new();
  private UnityEvent<RectTransform> onSelectExit = new();
  private GameObject previousSelectedObject;

  public void UpdateDetectingSelectedObject()
  {
    var currentSelectedObject = EventSystem.current.currentSelectedGameObject;
    if(previousSelectedObject != null &&
       currentSelectedObject != null &&
       currentSelectedObject != previousSelectedObject)
    {
      onSelectExit?.Invoke(previousSelectedObject.GetComponent<RectTransform>());
      onSelectEnter?.Invoke(currentSelectedObject.GetComponent<RectTransform>());
    }
    else if(previousSelectedObject != null &&
            currentSelectedObject == null)
    {
      onSelectExit?.Invoke(previousSelectedObject.GetComponent<RectTransform>());
    }
    else if(previousSelectedObject == null &&
            currentSelectedObject != null)
    {
      onSelectEnter?.Invoke(currentSelectedObject.GetComponent<RectTransform>());
    }

    previousSelectedObject = currentSelectedObject;
  }


  public void SetSelectedObject(RectTransform rectTransform)
    => EventSystem.current.SetSelectedGameObject(rectTransform.gameObject);

  public void SubscribeEvent(IUISelectionEventService.EventType type, UnityAction<RectTransform> action)
  {
    switch (type)
    {
      case IUISelectionEventService.EventType.OnEnter:
        onSelectEnter.AddListener(action);
        break;

      case IUISelectionEventService.EventType.OnExit:
        onSelectExit.AddListener(action);
        break;
    }
  }

  public void UnsubscribeEvent(IUISelectionEventService.EventType type, UnityAction<RectTransform> action)
  {
    switch (type)
    {
      case IUISelectionEventService.EventType.OnEnter:
        onSelectEnter.RemoveListener(action);
        break;

      case IUISelectionEventService.EventType.OnExit:
        onSelectExit.RemoveListener(action);
        break;
    }
  }
}