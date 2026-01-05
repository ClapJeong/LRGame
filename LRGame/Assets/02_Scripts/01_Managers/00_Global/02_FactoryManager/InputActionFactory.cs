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

  private readonly Dictionary<string, InputAction> actionMap = new();
  private readonly Dictionary<InputAction, UnityEvent<InputAction.CallbackContext>> eventMap = new();

  // ---------- Get / Register ----------

  public InputAction Register(
      List<string> paths,
      UnityAction action,
      InputActionPhaseType type)
  {
    var inputAction = GetOrCreate(paths);
    var unityEvent = eventMap[inputAction];

    var callback = CreatePhaseFilteredCallback(action, type);
    unityEvent.AddListener(callback);

    return inputAction;
  }

  public InputAction Register(
      string path,
      UnityAction action,
      InputActionPhaseType type)
    => Register(new List<string> { path }, action, type);

  public InputAction Register(
      List<string> paths,
      UnityAction<InputAction.CallbackContext> contextAction)
  {
    var inputAction = GetOrCreate(paths);
    eventMap[inputAction].AddListener(contextAction);
    return inputAction;
  }

  public InputAction Register(
      string path,
      UnityAction<InputAction.CallbackContext> contextAction)
    => Register(new List<string> { path }, contextAction);

  // ---------- Unregister ----------

  public void Unregister(
      InputAction inputAction,
      UnityAction action,
      InputActionPhaseType type)
  {
    if (!eventMap.TryGetValue(inputAction, out var unityEvent))
      return;

    unityEvent.RemoveListener(CreatePhaseFilteredCallback(action, type));
  }

  public void Unregister(
      InputAction inputAction,
      UnityAction<InputAction.CallbackContext> contextAction)
  {
    if (eventMap.TryGetValue(inputAction, out var unityEvent))
      unityEvent.RemoveListener(contextAction);
  }

  // ---------- 내부 ----------

  private InputAction GetOrCreate(List<string> paths)
  {
    var key = CreateKey(paths);

    if (actionMap.TryGetValue(key, out var inputAction))
      return inputAction;

    var unityEvent = new UnityEvent<InputAction.CallbackContext>();

    inputAction = new InputAction(
        $"InputAction_{key}",
        InputActionType.Button);

    inputAction.started += ctx => unityEvent.Invoke(ctx);
    inputAction.performed += ctx => unityEvent.Invoke(ctx);
    inputAction.canceled += ctx => unityEvent.Invoke(ctx);

    foreach (var path in paths)
      inputAction.AddBinding(path);

    inputAction.Enable();

    actionMap[key] = inputAction;
    eventMap[inputAction] = unityEvent;

    return inputAction;
  }

  private string CreateKey(List<string> paths)
  {
    // 순서 차이 방지
    return string.Join("|", paths.OrderBy(p => p));
  }

  private UnityAction<InputAction.CallbackContext> CreatePhaseFilteredCallback(
      UnityAction action,
      InputActionPhaseType type)
  {
    return context =>
    {
      if (IsMatchingPhase(context.phase, type))
        action?.Invoke();
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
}
