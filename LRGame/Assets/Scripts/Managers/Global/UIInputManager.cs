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

    public InputActionSet(string path)
    {
      var inputActionFactory = GlobalManager.instance.FactoryManager.InputActionFactory;
      inputAction = inputActionFactory.Get(path, onPerformed, InputActionFactory.InputActionPhaseType.Performed);
      inputActionFactory.Add(inputAction,onCanceled,InputActionFactory.InputActionPhaseType.Canceled);
    }
  }

  private Dictionary<UIInputActionType, InputActionSet> inputSets = new();  

  public UIInputManager()
  {
    if(Mouse.current != null)
      DisableMouse();
    CreateUIInputActions();
  }


  public void SubscribeCanceledEvent(UIInputActionType type, UnityAction onCanceled)
    => inputSets[type].onCanceled += onCanceled;

  public void SubscribePerformedEvent(UIInputActionType type, UnityAction onPerformed)
    => inputSets[type].onPerformed += onPerformed;

  public void UnsubscribeCanceledEvent(UIInputActionType type, UnityAction onCanceled)
    => inputSets[type].onCanceled -= onCanceled;

  public void UnsubscribePerformedEvent(UIInputActionType type, UnityAction onPerformed)
    => inputSets[type].onPerformed += onPerformed;

  private void DisableMouse()
  {
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
  }

  private void CreateUIInputActions()
  {
    var paths = GlobalManager.instance.Table.UISO.InputPaths;

    inputSets.Add(UIInputActionType.LeftLeft, new InputActionSet(paths.LeftLeftPath));
    inputSets.Add(UIInputActionType.LeftRight, new InputActionSet(paths.LeftRightPath));
    inputSets.Add(UIInputActionType.LeftDown, new InputActionSet(paths.LeftDownPath));
    inputSets.Add(UIInputActionType.LeftUP, new InputActionSet(paths.LeftUpPath));

    inputSets.Add(UIInputActionType.RightLeft, new InputActionSet(paths.RightLeftPath));
    inputSets.Add(UIInputActionType.RightRight, new InputActionSet(paths.RightRightPath));
    inputSets.Add(UIInputActionType.RightDown, new InputActionSet(paths.RightDownPath));
    inputSets.Add(UIInputActionType.RightUP, new InputActionSet(paths.RightUPPath));

    inputSets.Add(UIInputActionType.Space, new InputActionSet(paths.Space));
  }

  public void Dispose()
  {
    var inputActionFactory = GlobalManager.instance.FactoryManager.InputActionFactory;
    if (inputActionFactory != null)
    {
      foreach (var set in inputSets.Values)
        inputActionFactory.Release(set.inputAction);
    }
  }
}