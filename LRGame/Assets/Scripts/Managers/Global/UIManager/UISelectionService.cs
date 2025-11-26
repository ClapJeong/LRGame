using LR.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UISelectionService : IUISelectionEventService
{
  private UnityEvent<IRectView> onSelectEnter = new();
  private UnityEvent<IRectView> onSelectExit = new();
  private GameObject previousSelectedObject;

  public void UpdateDetectingSelectedObject()
  {
    var currentSelectedObject = EventSystem.current.currentSelectedGameObject;
    if(previousSelectedObject != null &&
       currentSelectedObject != null &&
       currentSelectedObject != previousSelectedObject)
    {
      onSelectExit?.Invoke(previousSelectedObject.GetComponent<IRectView>());
      onSelectEnter?.Invoke(currentSelectedObject.GetComponent<IRectView>());
    }
    else if(previousSelectedObject != null &&
            currentSelectedObject == null)
    {
      onSelectExit?.Invoke(previousSelectedObject.GetComponent<IRectView>());
    }
    else if(previousSelectedObject == null &&
            currentSelectedObject != null)
    {
      onSelectEnter?.Invoke(currentSelectedObject.GetComponent<IRectView>());
    }

    previousSelectedObject = currentSelectedObject;
  }


  public void SetSelectedObject(GameObject gameObject)
    => EventSystem.current.SetSelectedGameObject(gameObject);

  public void SubscribeEvent(IUISelectionEventService.EventType type, UnityAction<IRectView> action)
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

  public void UnsubscribeEvent(IUISelectionEventService.EventType type, UnityAction<IRectView> action)
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