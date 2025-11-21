using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class BasePlayerMoveController : IPlayerMoveController
{
  private readonly PlayerModel model;
  private readonly Dictionary<Direction, InputAction> moveInputActions = new();

  private readonly IRigidbodyController rigidbodyController;

  private UnityEvent<Direction> onPerformed = new();
  private UnityEvent<Direction> onCanceled = new();

  private Vector3 inputDirection;

  public BasePlayerMoveController(IRigidbodyController rigidbodyController, PlayerModel model)
  {
    this.rigidbodyController = rigidbodyController;
    this.model = model;
  }

  public void CreateMoveInputAction(Dictionary<string, Direction> pathDirectionPairs)
  {
    foreach (var pair in pathDirectionPairs)
      CreateMoveInputAction(pair.Key, pair.Value);
  }

  public void CreateMoveInputAction(string path, Direction direction)
  {
    moveInputActions[direction] = GlobalManager.instance.FactoryManager.InputActionFactory.Get(path, NestedOnMove);

    void NestedOnMove(InputAction.CallbackContext context)
    {
      var vectorDirection = model.ParseDirection(direction);

      switch (context.phase)
      {
        case InputActionPhase.Started:
          break;

        case InputActionPhase.Performed:
          inputDirection += vectorDirection;
          onPerformed?.Invoke(direction);
          break;

        case InputActionPhase.Canceled:
          inputDirection -= vectorDirection;
          onCanceled?.Invoke(direction);
          break;
      }
    }
  }

  public void EnableInputAction(Direction direction, bool enable)
  {
    if (moveInputActions.TryGetValue(direction, out InputAction action))
    {
      if (enable)
        action.Enable();
      else
        action.Disable();
    }
  }

  public void EnableAllInputActions(bool enable)
  {
    foreach (var inputAction in moveInputActions.Values)
    {
      if (enable)
        inputAction.Enable();
      else
        inputAction.Disable();
    }
  }

  public void SubscribeOnPerformed(UnityAction<Direction> performed)
  => onPerformed.AddListener(performed);

  public void SubscribeOnCanceled(UnityAction<Direction> canceled)
    => onCanceled.AddListener(canceled);

  public void UnsubscribePerfoemd(UnityAction<Direction> performed)
    => onPerformed.RemoveListener(performed);

  public void UnsubscribeCanceled(UnityAction<Direction> canceled)
    => onCanceled.RemoveListener(canceled);

  public void ApplyMoveAcceleration()
  {
    Vector3 currentVel = rigidbodyController.GetLinearVelocity();
    Vector3 desiredVel = inputDirection.normalized * model.so.Movement.MaxSpeed;

    currentVel = Vector3.MoveTowards(
          currentVel,
          desiredVel,
          model.so.Movement.Acceleration * Time.fixedDeltaTime);

    rigidbodyController.SetLinearVelocity(currentVel);
  }

  public void ApplyMoveDeceleration()
  {
    Vector3 currentVel = rigidbodyController.GetLinearVelocity();

    currentVel = Vector3.MoveTowards(
    currentVel,
    Vector3.zero,
    model.so.Movement.Decceleration * Time.fixedDeltaTime);

    rigidbodyController.SetLinearVelocity(currentVel);
  }
}