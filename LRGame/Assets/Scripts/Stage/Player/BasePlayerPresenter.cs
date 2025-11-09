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

  public void SetRoot(Transform root)
    =>view.SetRoot(root);

  public void SetActive(bool isActive)
    => view.SetActive(isActive);

  public void SetLocalPosition(Vector3 position)
    => view.SetLocalPosition(position);

  public void SetWorldPosition(Vector3 worldPosition)
    => view.SetWorldPosition(worldPosition);

  public void SetEuler(Vector3 euler)
    => view.SetEuler(euler);

  public void SetRotation(Quaternion rotation)
    => view.SetRotation(rotation);

  public void SetScale(Vector3 scale)
    => view.SetScale(scale);

  public void Enable(bool enable)
    => view.SetActive(enable);
}
