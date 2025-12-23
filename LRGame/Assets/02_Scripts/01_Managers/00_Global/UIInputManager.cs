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
  private Dictionary<UIInputDirectionType, InputActionSet> inputSets = new();  

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


  public void SubscribeCanceledEvent(UIInputDirectionType type, UnityAction onCanceled)
    => inputSets[type].onCanceled += onCanceled;

  public void SubscribePerformedEvent(UIInputDirectionType type, UnityAction onPerformed)
    => inputSets[type].onPerformed += onPerformed;

  public void UnsubscribeCanceledEvent(UIInputDirectionType type, UnityAction onCanceled)
    => inputSets[type].onCanceled -= onCanceled;

  public void UnsubscribePerformedEvent(UIInputDirectionType type, UnityAction onPerformed)
    => inputSets[type].onPerformed -= onPerformed;

  public void SubscribePerformedEvent(List<UIInputDirectionType> types, UnityAction onPerformed)
  {
    foreach (var inputDirectionType in types)
      SubscribePerformedEvent(inputDirectionType, onPerformed);
  }

  public void UnsubscribePerformedEvent(List<UIInputDirectionType> types, UnityAction onPerformed)
  {
    foreach (var inputDirectionType in types)
      UnsubscribePerformedEvent(inputDirectionType, onPerformed);
  }

  public void SubscribeCanceledEvent(List<UIInputDirectionType> types, UnityAction onCanceled)
  {
    foreach (var inputDirectionType in types)
      SubscribeCanceledEvent(inputDirectionType, onCanceled);
  }

  public void UnsubscribeCanceledEvent(List<UIInputDirectionType> types, UnityAction onCanceled)
  {
    foreach (var inputDirectionType in types)
      UnsubscribeCanceledEvent(inputDirectionType, onCanceled);
  }


  private void DisableMouse()
  {
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
  }

  private void CreateUIInputActions()
  {
    var paths = table.UISO.InputPaths;

    inputSets[UIInputDirectionType.LeftLeft] = new InputActionSet(paths.LeftLeftPath, inputActionFactory);
    inputSets[UIInputDirectionType.LeftRight] = new InputActionSet(paths.LeftRightPath, inputActionFactory);
    inputSets[UIInputDirectionType.LeftDown] = new InputActionSet(paths.LeftDownPath, inputActionFactory);
    inputSets[UIInputDirectionType.LeftUp] = new InputActionSet(paths.LeftUpPath, inputActionFactory);

    inputSets[UIInputDirectionType.RightLeft] = new InputActionSet(paths.RightLeftPath, inputActionFactory);
    inputSets[UIInputDirectionType.RightRight] = new InputActionSet(paths.RightRightPath, inputActionFactory);
    inputSets[UIInputDirectionType.RightDown] = new InputActionSet(paths.RightDownPath, inputActionFactory);
    inputSets[UIInputDirectionType.RightUp] = new InputActionSet(paths.RightUPPath, inputActionFactory);

    inputSets[UIInputDirectionType.Space] = new InputActionSet(paths.Space, inputActionFactory);
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