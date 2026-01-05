using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputMashProgressService : IInputMashProgressService
{
  private readonly InputActionFactory InputActionFactory;

  private readonly List<InputAction> inputActions = new();
  private readonly CTSContainer cts = new();
  private bool isPlaying = false;
  private InputMashProgressData currentData;
  private float value;

  public InputMashProgressService(InputActionFactory inputActionFactory)
  {
    InputActionFactory = inputActionFactory;
  }

  public void Play(
    CharacterMoveKeyCodeData keyCodeData, 
    InputMashProgressData data, 
    UnityAction<float> onProgress, 
    UnityAction onComplete,
    UnityAction onFail)
  {
    if (isPlaying)
      return;

    cts.Dispose();
    cts.Create();

    value = data.BeginValue;
    currentData = data;
    InputMashProgressAsync(keyCodeData, onProgress, onComplete, onFail, cts.token).Forget();
  }

  public void Stop()
  {
    cts.Cancel();
  }

  private async UniTask InputMashProgressAsync(
    CharacterMoveKeyCodeData keyCodeData, 
    UnityAction<float> onProgress, 
    UnityAction onComplete,
    UnityAction onFail,
    CancellationToken token)
  {
    SubscribeInputActions(keyCodeData);

    try
    {
      isPlaying = true;
      while (value > 0 && value < 1.0f)
      {
        token.ThrowIfCancellationRequested();
        value -= currentData.DecreaseValuePerSecond * Time.deltaTime;
        onProgress?.Invoke(value);
        await UniTask.Yield();
      }

      if (value >= 1.0f)
      {
        value = 1.0f;
        onProgress?.Invoke(value);
        onComplete?.Invoke();
      }        
      else if (value <= 0.0f)
      {
        value = 0.0f;
        onProgress?.Invoke(value);
        onFail?.Invoke();
      }
    }
    catch (OperationCanceledException) { }
    finally
    {
      isPlaying = false;
      UnsubscribeInputActions();
    }
  }
  
  private void OnPerformed()
  {
    value += currentData.IncreaseValueOnInput;
  }

  private void SubscribeInputActions(CharacterMoveKeyCodeData keyCodeData)
  {
    inputActions.Add(InputActionFactory.Register(InputActionPaths.ParshPath(keyCodeData.GetKeyCode(Direction.Up)), OnPerformed, InputActionFactory.InputActionPhaseType.Performed));
    inputActions.Add(InputActionFactory.Register(InputActionPaths.ParshPath(keyCodeData.GetKeyCode(Direction.Right)), OnPerformed, InputActionFactory.InputActionPhaseType.Performed));
    inputActions.Add(InputActionFactory.Register(InputActionPaths.ParshPath(keyCodeData.GetKeyCode(Direction.Down)), OnPerformed, InputActionFactory.InputActionPhaseType.Performed));
    inputActions.Add(InputActionFactory.Register(InputActionPaths.ParshPath(keyCodeData.GetKeyCode(Direction.Left)), OnPerformed, InputActionFactory.InputActionPhaseType.Performed));
  }

  private void UnsubscribeInputActions()
  {
    foreach (var inputAction in inputActions)
      InputActionFactory.Unregister(inputAction, OnPerformed, InputActionFactory.InputActionPhaseType.Performed);

    inputActions.Clear();
  }
}
