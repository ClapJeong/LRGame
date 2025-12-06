using LR.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIProgressSubmitController : IUIProgressSubmitController
{
  private readonly Dictionary<Direction, InputAction> rightInputActions = new();

  private readonly List<Direction> currentPerforming = new();
  private IUIProgressSubmitView selectedView;  

  public UIProgressSubmitController(IUISelectedGameObjectService selectedGameObjectService, InputActionFactory inputActionFactory)
  {
    var table = GlobalManager.instance.Table.UISO.InputPaths;
    rightInputActions[Direction.Up] = inputActionFactory.Get(table.RightUPPath, context => OnInputAction(Direction.Up, context));
    rightInputActions[Direction.Right] = inputActionFactory.Get(table.RightRightPath, context => OnInputAction(Direction.Right, context));
    rightInputActions[Direction.Down] = inputActionFactory.Get(table.RightDownPath, context => OnInputAction(Direction.Down, context));
    rightInputActions[Direction.Left] = inputActionFactory.Get(table.RightLeftPath, context => OnInputAction(Direction.Left, context));

    selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);
    selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnExit, OnSelectedGameObjectExit);
  }

  public void Release(IUIProgressSubmitView view)
  {
    if (selectedView == view)
      selectedView = null;
  }

  private void OnInputAction(Direction direction, InputAction.CallbackContext context)
  {
    if ((selectedView as UnityEngine.Object) == null)
    {
      selectedView = null;
      return;
    }

    switch (context.phase)
    {
      case InputActionPhase.Performed:
        {
          selectedView?.Perform(direction);
          currentPerforming.Add(direction);
        }
        break;

      case InputActionPhase.Canceled:
        {
          selectedView?.Cancel(direction);
          currentPerforming.Remove(direction);
        }
        break;
    }
  }

  private void OnSelectedGameObjectEnter(GameObject gameObject)
  {
    if (gameObject.TryGetComponent<IUIProgressSubmitView>(out var view))
      selectedView = view;
  }

  private void OnSelectedGameObjectExit(GameObject gameObject)
  {
    foreach(var direction in currentPerforming)
      selectedView?.Cancel(direction);

    currentPerforming.Clear();
  }
}