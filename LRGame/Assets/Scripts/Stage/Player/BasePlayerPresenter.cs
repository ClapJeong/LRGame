using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class BasePlayerPresenter : IPlayerPresenter
{
  private readonly Dictionary<Direction, InputAction> moveInputActions = new();
  private IPlayerView view;
  private PlayerModel model;
  private UnityEvent<Direction> onPerformed = new();
  private UnityEvent<Direction> onCanceled = new();

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
    moveInputActions[direction] = GlobalManager.instance.FactoryManager.InputActionFactory.Get(path, NextedOnMove);

    void NextedOnMove(InputAction.CallbackContext context)
    {
      var vectorDirection = model.ParseDirection(direction);

      switch (context.phase)
      {
        case InputActionPhase.Started:
          break;

        case InputActionPhase.Performed:
          view.AddDirection(vectorDirection);
          onPerformed?.Invoke(direction);
          break;

        case InputActionPhase.Canceled:
          view.RemoveDirection(vectorDirection);
          onCanceled?.Invoke(direction);
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

  public void SubscribeOnPerformed(UnityAction<Direction> performed)
    => onPerformed.AddListener(performed);

  public void SubscribeOnCanceled(UnityAction<Direction> canceled)
    => onCanceled.AddListener(canceled);

  public void UnsubscribePerfoemd(UnityAction<Direction> perfoemd)
    =>onPerformed.RemoveListener(perfoemd);

  public void UnsubscribeCanceled(UnityAction<Direction> canceled)
    =>onCanceled.RemoveListener(canceled);
}
