using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class UIInputManager : IUIInputActionManager
{
  private class InputActionSet
  {
    private readonly InputActionFactory inputActionFactory;

    public readonly InputAction inputAction;
    public readonly UnityEvent onPerformed = new();
    public readonly UnityEvent onCanceled = new();

    public InputActionSet(string path, InputActionFactory inputActionFactory)
    {
      this.inputActionFactory = inputActionFactory;

      inputAction = inputActionFactory.Register(path, OnInputAction);
      inputAction.Enable();
    }

    private void OnInputAction(InputAction.CallbackContext context)
    {
      switch (context.phase)
      {
        case InputActionPhase.Performed: onPerformed?.Invoke(); break;
        case InputActionPhase.Canceled: onCanceled?.Invoke(); break;
      }
    }

    public void Release()
    {
      inputActionFactory.Unregister(inputAction, OnInputAction);
    }
  }

  private readonly TableContainer table;
  private readonly InputActionFactory inputActionFactory;
  private Dictionary<UIInputDirection, InputActionSet> inputSets = new();  

  public UIInputManager(TableContainer table, InputActionFactory inputActionFactory)
  {
    this.table = table;
    this.inputActionFactory = inputActionFactory;

#if !UNITY_EDITOR
    if(Mouse.current != null)
      DisableMouse();
#endif
    CreateUIInputActions();
  }


  public void SubscribeCanceledEvent(UIInputDirection type, UnityAction onCanceled)
    => inputSets[type].onCanceled.AddListener(onCanceled);

  public void SubscribePerformedEvent(UIInputDirection type, UnityAction onPerformed)
    => inputSets[type].onPerformed.AddListener(onPerformed);

  public void UnsubscribeCanceledEvent(UIInputDirection type, UnityAction onCanceled)
    => inputSets[type].onCanceled.RemoveListener(onCanceled);

  public void UnsubscribePerformedEvent(UIInputDirection type, UnityAction onPerformed)
    => inputSets[type].onPerformed.RemoveListener(onPerformed);

  public void SubscribePerformedEvent(List<UIInputDirection> types, UnityAction onPerformed)
  {
    foreach (var inputDirectionType in types)
      SubscribePerformedEvent(inputDirectionType, onPerformed);
  }

  public void UnsubscribePerformedEvent(List<UIInputDirection> types, UnityAction onPerformed)
  {
    foreach (var inputDirectionType in types)
      UnsubscribePerformedEvent(inputDirectionType, onPerformed);
  }

  public void SubscribeCanceledEvent(List<UIInputDirection> types, UnityAction onCanceled)
  {
    foreach (var inputDirectionType in types)
      SubscribeCanceledEvent(inputDirectionType, onCanceled);
  }

  public void UnsubscribeCanceledEvent(List<UIInputDirection> types, UnityAction onCanceled)
  {
    foreach (var inputDirectionType in types)
      UnsubscribeCanceledEvent(inputDirectionType, onCanceled);
  }

  public bool IsPerforming(UIInputDirection type)
  {
    if (inputSets.TryGetValue(type, out var inputActionSet))
      return inputActionSet.inputAction.IsPressed();
    else
      return false;
  }

  public bool IsAnyPerforming(List<UIInputDirection> types)
  {
    foreach(var inputDirectionType in types)
      if(IsPerforming(inputDirectionType)) return true;

    return false;
  }

  private void DisableMouse()
  {
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
  }

  private void CreateUIInputActions()
  {
    var paths = table.UISO.InputPaths;

    inputSets[UIInputDirection.LeftLeft] = new InputActionSet(paths.LeftLeftPath, inputActionFactory);
    inputSets[UIInputDirection.LeftRight] = new InputActionSet(paths.LeftRightPath, inputActionFactory);
    inputSets[UIInputDirection.LeftDown] = new InputActionSet(paths.LeftDownPath, inputActionFactory);
    inputSets[UIInputDirection.LeftUp] = new InputActionSet(paths.LeftUpPath, inputActionFactory);

    inputSets[UIInputDirection.RightLeft] = new InputActionSet(paths.RightLeftPath, inputActionFactory);
    inputSets[UIInputDirection.RightRight] = new InputActionSet(paths.RightRightPath, inputActionFactory);
    inputSets[UIInputDirection.RightDown] = new InputActionSet(paths.RightDownPath, inputActionFactory);
    inputSets[UIInputDirection.RightUp] = new InputActionSet(paths.RightUPPath, inputActionFactory);

    inputSets[UIInputDirection.Space] = new InputActionSet(paths.Space, inputActionFactory);
  }

  public void Dispose()
  {
    if (inputActionFactory != null)
    {
      foreach (var set in inputSets.Values)
        set.Release();
    }
  }
}