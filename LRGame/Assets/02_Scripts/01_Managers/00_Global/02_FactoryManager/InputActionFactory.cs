using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputActionFactory
{
  public enum InputActionPhaseType
  {
    Started,
    Performed,
    Canceled
  }

  private readonly Dictionary<InputAction, UnityEvent<InputAction.CallbackContext>> inputActions = new();

  public InputAction Get(List<string> paths, UnityAction action, InputActionPhaseType type)
  {
    var contextEvent = new UnityEvent<InputAction.CallbackContext>();
    contextEvent.AddListener(CreatePhaseFilteredCallback(action, type));

    var inputAction = CreateInputAction(paths, contextEvent);

    return inputAction;
  }

  public InputAction Get(string path, UnityAction action, InputActionPhaseType type)
      => Get(new List<string>() { path }, action, type);

  public InputAction Get(List<string> paths, UnityAction<InputAction.CallbackContext> contextAction)
  {
    var contextEvent = new UnityEvent<InputAction.CallbackContext>();
    contextEvent.AddListener(contextAction);

    var inputAction = CreateInputAction(paths, contextEvent);

    return inputAction;
  }

  public InputAction Get(string path, UnityAction<InputAction.CallbackContext> contextAction)
      => Get(new List<string>() { path }, contextAction);

  public void Add(InputAction inputAction, UnityAction addAction, InputActionPhaseType type)
  {
    if (inputActions.TryGetValue(inputAction, out var unityEvent))
    {
      unityEvent.AddListener(CreatePhaseFilteredCallback(addAction, type));
    }
  }

  public void Add(InputAction inputAction, UnityAction<InputAction.CallbackContext> addContextAction)
  {
    if (inputActions.TryGetValue(inputAction, out var unityEvent))
    {
      unityEvent.AddListener(addContextAction);
    }
  }

  public void Release(params InputAction[] inputActions)
  {
    for (int i = 0; i < inputActions.Length; i++)
      if (inputActions[i] != null)
        ReleaseAsync(inputActions[i]).Forget();
  }

  private async UniTask ReleaseAsync(InputAction inputAction)
  {
    if (inputAction == null)
      return;

    if (inputActions.TryGetValue(inputAction, out var unityEvent))
    {
      unityEvent.RemoveAllListeners();
      inputActions.Remove(inputAction);
    }

    inputAction.Disable();
    await UniTask.Yield();
    inputAction.Dispose();
  }

  public void Clear()
  {
    foreach (var key in inputActions.Keys.ToList())
    {
      ReleaseAsync(key).Forget();
    }

    inputActions.Clear();
  }

  public void AttachOnDestroy(InputAction inputAction, GameObject gameObject)
  {
    gameObject
      .OnDestroyAsObservable()
      .Subscribe(_=>Release(inputAction));
  }

  // ---------- 내부 유틸 메서드 ----------

  private UnityAction<InputAction.CallbackContext> CreatePhaseFilteredCallback(UnityAction action, InputActionPhaseType type)
  {
    return context =>
    {
      if (IsMatchingPhase(context.phase, type))
      {
        action?.Invoke();
      }
    };
  }

  private bool IsMatchingPhase(InputActionPhase phase, InputActionPhaseType targetType)
  {
    return targetType switch
    {
      InputActionPhaseType.Started => phase == InputActionPhase.Started,
      InputActionPhaseType.Performed => phase == InputActionPhase.Performed,
      InputActionPhaseType.Canceled => phase == InputActionPhase.Canceled,
      _ => false
    };
  }

  private InputAction CreateInputAction(List<string> paths, UnityEvent<InputAction.CallbackContext> contextEvent)
  {
    var inputAction = new InputAction(
        $"InputAction_{Guid.NewGuid()}",
        InputActionType.Button,
        null);

    inputAction.started += context => contextEvent.Invoke(context);
    inputAction.performed += context => contextEvent.Invoke(context);
    inputAction.canceled += context => contextEvent.Invoke(context);

    foreach (var path in paths)
    {
      inputAction.AddBinding(path);
    }

    inputActions[inputAction] = contextEvent;
    inputAction.Enable();
    return inputAction;
  }
}