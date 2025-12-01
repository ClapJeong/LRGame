using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UISelectedGameObjectService : IUISelectedGameObjectService
{
  private UnityEvent<GameObject> onSelectEnter = new();
  private UnityEvent<GameObject> onSelectExit = new();
  private GameObject previousSelectedObject;

  public void UpdateDetectingSelectedObject()
  {
    var currentSelectedObject = EventSystem.current.currentSelectedGameObject;
    if(previousSelectedObject != null &&
       currentSelectedObject != null &&그냥무작정이전오브젝트가져오는게아니라뎁스따라서가져오는거걸러야함
       currentSelectedObject != previousSelectedObject)
    {
      onSelectExit?.Invoke(previousSelectedObject);
      onSelectEnter?.Invoke(currentSelectedObject);
    }
    else if(previousSelectedObject != null &&
            currentSelectedObject == null)
    {
      onSelectExit?.Invoke(previousSelectedObject);
    }
    else if(previousSelectedObject == null &&
            currentSelectedObject != null)
    {
      onSelectEnter?.Invoke(currentSelectedObject);
    }

    previousSelectedObject = currentSelectedObject;
  }


  public void SetSelectedObject(GameObject gameObject)
    => EventSystem.current.SetSelectedGameObject(gameObject);

  public void SubscribeEvent(IUISelectedGameObjectService.EventType type, UnityAction<GameObject> action)
  {
    switch (type)
    {
      case IUISelectedGameObjectService.EventType.OnEnter:
        onSelectEnter.AddListener(action);
        break;

      case IUISelectedGameObjectService.EventType.OnExit:
        onSelectExit.AddListener(action);
        break;
    }
  }

  public void UnsubscribeEvent(IUISelectedGameObjectService.EventType type, UnityAction<GameObject> action)
  {
    switch (type)
    {
      case IUISelectedGameObjectService.EventType.OnEnter:
        onSelectEnter.RemoveListener(action);
        break;

      case IUISelectedGameObjectService.EventType.OnExit:
        onSelectExit.RemoveListener(action);
        break;
    }
  }
}