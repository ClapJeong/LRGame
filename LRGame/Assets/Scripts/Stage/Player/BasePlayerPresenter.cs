using System.Collections.Generic;
using Unity.VisualScripting;
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
    view.SetWorldPosition(model.beginPosition);
    view.SetSO(model.so);
    //view.SetAcceleration(model.acceleration);
    //view.SetDecceleration(model.deceleration);
    //view.SetMaxSpeed(model.maxSpeed);
  }

  public void CreateMoveInputAction(Dictionary<string, Direction> pathDirectionPairs)
  {
    foreach(var pair in  pathDirectionPairs)
      CreateMoveInputAction(pair.Key,pair.Value);
  }

  public void CreateMoveInputAction(string path, Direction direction)
  {
    var vectorDirection = model.ParseDirection(direction);
    moveInputActions[direction] = GlobalManager.instance.FactoryManager.InputActionFactory.Get(path, OnMove);

    void OnMove(InputAction.CallbackContext context)
    {
      switch (context.phase)
      {
        case InputActionPhase.Started:
          view.AddDirection(vectorDirection);
          break;

        case InputActionPhase.Performed:
          break;

        case InputActionPhase.Canceled:
          view.RemoveDirection(vectorDirection);
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


  public void Enable(bool enable)
  {
    EnableAllInputActions(enable);
  }

  public void Restart()
  {
    EnableAllInputActions(true);
    view.SetWorldPosition(model.beginPosition);
  }
}
