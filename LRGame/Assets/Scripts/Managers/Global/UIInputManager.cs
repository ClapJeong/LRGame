using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class UIInputManager : IUIInputActionManager
{
  private class InputActionSet
  {
    public InputAction inputAction;
    public UnityAction onPerformed;
    public UnityAction onCanceled;

    public InputActionSet(string path, InputActionFactory inputActionFactory)
    {
      inputAction = inputActionFactory.Get(path, OnInputAction);
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
  }

  private readonly TableContainer table;
  private readonly InputActionFactory inputActionFactory;
  private Dictionary<UIInputActionType, InputActionSet> inputSets = new();  

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


  public void SubscribeCanceledEvent(UIInputActionType type, UnityAction onCanceled)
    => inputSets[type].onCanceled += onCanceled;

  public void SubscribePerformedEvent(UIInputActionType type, UnityAction onPerformed)
    => inputSets[type].onPerformed += onPerformed;

  public void UnsubscribeCanceledEvent(UIInputActionType type, UnityAction onCanceled)
    => inputSets[type].onCanceled -= onCanceled;

  public void UnsubscribePerformedEvent(UIInputActionType type, UnityAction onPerformed)
    => inputSets[type].onPerformed -= onPerformed;

  public void SubscribePerformedEvent(List<UIInputActionType> types, UnityAction onPerformed)
  {
    foreach (var inputActionType in types)
      SubscribePerformedEvent(inputActionType, onPerformed);
  }

  public void UnsubscribePerformedEvent(List<UIInputActionType> types, UnityAction onPerformed)
  {
    foreach (var inputActionType in types)
      UnsubscribePerformedEvent(inputActionType, onPerformed);
  }

  public void SubscribeCanceledEvent(List<UIInputActionType> types, UnityAction onCanceled)
  {
    foreach (var inputActionType in types)
      SubscribeCanceledEvent(inputActionType, onCanceled);
  }

  public void UnsubscribeCanceledEvent(List<UIInputActionType> types, UnityAction onCanceled)
  {
    foreach (var inputActionType in types)
      UnsubscribeCanceledEvent(inputActionType, onCanceled);
  }


  private void DisableMouse()
  {
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
  }

  private void CreateUIInputActions()
  {
    var paths = table.UISO.InputPaths;

    inputSets[UIInputActionType.LeftLeft] = new InputActionSet(paths.LeftLeftPath, inputActionFactory);
    inputSets[UIInputActionType.LeftRight] = new InputActionSet(paths.LeftRightPath, inputActionFactory);
    inputSets[UIInputActionType.LeftDown] = new InputActionSet(paths.LeftDownPath, inputActionFactory);
    inputSets[UIInputActionType.LeftUP] = new InputActionSet(paths.LeftUpPath, inputActionFactory);

    inputSets[UIInputActionType.RightLeft] = new InputActionSet(paths.RightLeftPath, inputActionFactory);
    inputSets[UIInputActionType.RightRight] = new InputActionSet(paths.RightRightPath, inputActionFactory);
    inputSets[UIInputActionType.RightDown] = new InputActionSet(paths.RightDownPath, inputActionFactory);
    inputSets[UIInputActionType.RightUP] = new InputActionSet(paths.RightUPPath, inputActionFactory);

    inputSets[UIInputActionType.Space] = new InputActionSet(paths.Space, inputActionFactory);
  }

  public void Dispose()
  {
    if (inputActionFactory != null)
    {
      foreach (var set in inputSets.Values)
        inputActionFactory.Release(set.inputAction);
    }
  }
}