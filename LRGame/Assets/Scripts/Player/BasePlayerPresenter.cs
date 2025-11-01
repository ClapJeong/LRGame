using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BasePlayerPresenter : IPlayerPresenter
{
  private readonly Dictionary<Direction, InputAction> moveInputActions = new();
  private IPlayerView view;
  private PlayerModel model;

  public void Initialize(IPlayerView view, PlayerModel model)
  {
    this.view = view;
    this.model = model;
  }

  public void CreateMoveInputAction(string path, Direction direction)
  {
    var vectorDirection = model.ParseDirection(direction);
    moveInputActions[direction] = FactoryManager.Instance.InputActionFactory.Get(path, OnMove);

    void OnMove(InputAction.CallbackContext context)
    {
      switch (context.phase)
      {
        case InputActionPhase.Started:
          view.AddForce(vectorDirection);
          break;

        case InputActionPhase.Performed:
          break;

        case InputActionPhase.Canceled:
          view.RemoveForce(vectorDirection);
          break;
      }
    }
  }

  public void EnableInputAction(Direction direction, bool enable)
  {
    if(moveInputActions.TryGetValue(direction, out InputAction action))
    {
      if (enable)
        action.Enable();
      else
        action.Disable();
    }
  }

  public void EnableAllInputActions(bool enable)
  {
    foreach(var inputAction in moveInputActions.Values)
    {
      if(enable)
        inputAction.Enable();
      else
        inputAction.Disable();
    }  
  }

  public void SetEnable(bool isEnable)
  {
    view.SetActive(isEnable);
  }
}
