using Cysharp.Threading.Tasks;
using LR.Table.Input;
using LR.UI.GameScene.InputProgress;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputProgressService : IInputProgressService
{
  private readonly InputActionFactory InputActionFactory;
  private readonly IInputProgressUIService uiService;
  private readonly ICameraService cameraService;

  private readonly List<InputAction> inputActions = new();
  private readonly CTSContainer cts = new();
  private bool isPlaying = false;
  private InputProgressData currentData;
  private float value;

  public InputProgressService(InputActionFactory inputActionFactory, IInputProgressUIService uiService, ICameraService cameraService)
  {
    InputActionFactory = inputActionFactory;
    this.uiService = uiService;
    this.cameraService = cameraService;
  }

  public async void Play(
    InputProgressData data,
    CharacterMoveKeyCodeData keyCodeData,
    Transform followTarget,
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
    var presenter = await uiService.GetPresenterAsync(data.UIType, followTarget);
    PlayAsync(presenter, keyCodeData, onProgress, onComplete, onFail, cts.token).Forget();
  }

  public async void Play(
  InputProgressData data,
  CharacterMoveKeyCodeData keyCodeData,
  Vector3 worldPosition,
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
    var screenPosition = cameraService.GetScreenPosition(worldPosition);
    var presenter = await uiService.GetPresenterAsync(data.UIType, screenPosition);
    PlayAsync(presenter, keyCodeData, onProgress, onComplete, onFail, cts.token).Forget();
  }


  public void Stop()
  {
    cts.Cancel();
  }

  private async UniTask PlayAsync(
    IUIInputProgressPresenter presenter,
    CharacterMoveKeyCodeData keyCodeData, 
    UnityAction<float> onProgress, 
    UnityAction onComplete,
    UnityAction onFail,
    CancellationToken token)
  {
    await presenter.ActivateAsync();

    try
    {
      isPlaying = true;
      SubscribeInputActions(keyCodeData);
      while (true)
      {
        if ((currentData.Failable && value <= 0.0f) || value >= 1.0f)
          break;

        token.ThrowIfCancellationRequested();
        value = Mathf.Max(0.0f, value - currentData.DecreaseValuePerSecond * Time.deltaTime);
        onProgress?.Invoke(value);
        presenter.OnProgress(value);
        await UniTask.Yield();
      }

      if (value >= 1.0f)
      {
        value = 1.0f;
        onProgress?.Invoke(value);
        onComplete?.Invoke();

        presenter.OnProgress(value);
        presenter.OnComplete();
      }        
      else if (value <= 0.0f)
      {
        value = 0.0f;
        onProgress?.Invoke(value);        
        onFail?.Invoke();

        presenter.OnProgress(value);
        presenter.OnComplete();
      }
    }
    catch (OperationCanceledException) { }
    finally
    {
      isPlaying = false;
      UnsubscribeInputActions();
      presenter.DeactivateAsync().Forget();
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
