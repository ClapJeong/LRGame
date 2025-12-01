using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDepthService : IUIDepthService
{
  private readonly Stack<GameObject> depthSelectedObjects = new();

  public UIDepthService()
  {
  }

  public void UpdateFocusingSelectedGameObject()
  {
    if (EventSystem.current.currentSelectedGameObject == null &&
      depthSelectedObjects.TryPeek(out var currentSelectedGameObject))
      EventSystem.current.SetSelectedGameObject(currentSelectedGameObject);
  }

  public void LowerDepth()
  {
    depthSelectedObjects.Pop();
    if (depthSelectedObjects.Count > 0)
    {
      var lowerSelectedGameObject = depthSelectedObjects.Peek();
      EventSystem.current.SetSelectedGameObject(lowerSelectedGameObject);
    }      
  }

  public void RaiseDepth(GameObject targetSelectingGameObject)
  {
    var lastSelectedGameObject = EventSystem.current.currentSelectedGameObject;
    depthSelectedObjects.Push(lastSelectedGameObject);
    EventSystem.current.SetSelectedGameObject(targetSelectingGameObject);
  }

  public void SelectTopObject()
  {
    var currentSelectedGameObject = depthSelectedObjects.Peek();
    EventSystem.current.SetSelectedGameObject(currentSelectedGameObject);
  }
}