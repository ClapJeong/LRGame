using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace LR.Stage.Player
{
  public class PlayerInputActionController : IPlayerInputActionController
  {
    private class InputActionSet : IDisposable
    {
      private readonly InputActionFactory factory;
      private readonly UnityAction onPerformed;
      private readonly UnityAction onCanceled;

      private InputAction inputAction;
      private bool enableInputAction;

      public InputActionSet(InputActionFactory factory, string path, UnityAction onPerformed, UnityAction onCanceled)
      {
        this.factory = factory;
        this.onPerformed = onPerformed;
        this.onCanceled = onCanceled;

        Register(path);
      }

      private void Register(string path)
      {
        inputAction = factory.Register(path, OnInputAction);
      }

      public void Dispose()
      {
        factory.Unregister(inputAction, OnInputAction);
      }

      public void Enable(bool isEnable)
      {
        ResetState();
        enableInputAction = isEnable;
      }

      public bool IsPressed()
        => inputAction.IsPressed();

      private void ResetState()
      {
        inputAction.Disable();
        inputAction.Enable();
      }

      private void OnInputAction(InputAction.CallbackContext context)
      {
        if (enableInputAction == false)
          return;

        switch (context.phase)
        {
          case InputActionPhase.Started:
            break;

          case InputActionPhase.Performed:
            onPerformed?.Invoke();
            break;

          case InputActionPhase.Canceled:
            onCanceled?.Invoke();
            break;
        }
      }
    }

    private readonly InputActionFactory inputActionFactory;

    private readonly Dictionary<Direction, InputActionSet> inputActionSets = new();
    private readonly UnityEvent<Direction> onPerformed = new();
    private readonly UnityEvent<Direction> onCanceled = new();

    public PlayerInputActionController(InputActionFactory inputActionFactory)
    {
      this.inputActionFactory = inputActionFactory;
    }

    public void CreateMoveInputAction(Dictionary<string, Direction> pathDirectionPairs)
    {
      foreach (var pair in pathDirectionPairs)
        CreateMoveInputAction(pair.Key, pair.Value);
    }

    public void CreateMoveInputAction(string path, Direction direction)
    {
      inputActionSets[direction] = (new(inputActionFactory, path, () => onPerformed?.Invoke(direction), () => onCanceled?.Invoke(direction)));
    }

    public void EnableInputAction(Direction direction, bool enable)
    {
      if (inputActionSets.TryGetValue(direction, out var set))
        set.Enable(enable);
    }

    public void EnableAllInputActions(bool enable)
    {
      foreach (var set in inputActionSets.Values)
        set.Enable(enable);
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
      foreach (var set in inputActionSets.Values)
        set.Dispose();
    }

    public bool IsAnyInput()
    {
      foreach (var set in inputActionSets.Values)
        if (set.IsPressed())
          return true;

      return false;
    }
  }
}