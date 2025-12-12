using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace LR.Stage.Player
{
  public class BasePlayerInputActionController : IPlayerInputActionController
  {
    private readonly PlayerModel model;
    private readonly Dictionary<Direction, InputAction> moveInputActions = new();

    private UnityEvent<Direction> onPerformed = new();
    private UnityEvent<Direction> onCanceled = new();

    public BasePlayerInputActionController(PlayerModel model)
    {
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
        switch (context.phase)
        {
          case InputActionPhase.Started:
            break;

          case InputActionPhase.Performed:
            onPerformed?.Invoke(direction);
            break;

          case InputActionPhase.Canceled:
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

    public void Dispose()
    {
      foreach (var inputAction in moveInputActions.Values.ToList())
        GlobalManager.instance.FactoryManager.InputActionFactory.Release(inputAction);
    }

    public bool IsAnyInput()
    {
      foreach (var inputAction in moveInputActions.Values)
        if (inputAction.IsPressed())
          return true;

      return false;
    }
  }
}