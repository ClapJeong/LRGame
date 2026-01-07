using Cysharp.Threading.Tasks;
using LR.Table.Input;
using LR.UI.GameScene.InputQTE;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputQTEService : IInputQTEService
{
  public enum QTEResultType
  {
    Success,
    Fail,
    SequenceTimeout,
  }

  private class DurationData
  {
    public readonly float sequenceMaxDuration;
    public readonly float qteMaxDuration;
    public float sequenceDuration;
    public float qteDuration;    

    public DurationData(float sequenceMaxDuration, float qteMaxDuration)
    {
      this.sequenceMaxDuration = sequenceMaxDuration;
      this.sequenceDuration = sequenceMaxDuration;
      this.qteMaxDuration = qteMaxDuration;
      this.qteDuration = qteMaxDuration;
    }

    public void ResetQTEDuration()
    {
      qteDuration = qteMaxDuration;
    }
  }

  private readonly InputActionFactory InputActionFactory;
  private readonly IInputQTEUIService uiService;
  private readonly ICameraService cameraService;

  private InputAction qteInputAction;
  private readonly CTSContainer cts = new();
  private bool isPlaying = false;
  private bool isPerformed = false;
  private InputQTEData currentData;

  public InputQTEService(InputActionFactory inputActionFactory, IInputQTEUIService uiService, ICameraService cameraService)
  {
    InputActionFactory = inputActionFactory;
    this.uiService = uiService;
    this.cameraService = cameraService;
  }

  public async void Play(
    InputQTEData data, 
    CharacterMoveKeyCodeData keyCodeData, 
    Transform followTarget,
    UnityAction onSuccess,
    UnityAction onFail)
  {
    if (isPlaying)
      return;

    cts.Dispose();
    cts.Create();

    currentData = data;
    var presenter = await uiService.GetPrsenterAsync(data.UIType, followTarget);
    isPlaying = true;
    PlayAsync(presenter, keyCodeData, onSuccess, onFail, cts.token).Forget();
  }

  public async void Play(
    InputQTEData data, 
    CharacterMoveKeyCodeData keyCodeData, 
    Vector2 worldPosition,
    UnityAction onSuccess,
    UnityAction onFail)
  {
    if (isPlaying)
      return;

    cts.Dispose();
    cts.Create();

    currentData = data;
    var screenPosition = cameraService.GetScreenPosition(worldPosition);
    var presenter = await uiService.GetPrsenterAsync(data.UIType, screenPosition);
    isPlaying = true;
    PlayAsync(presenter, keyCodeData, onSuccess, onFail, cts.token).Forget();
  }

  public void Stop()
  {
    if (!isPlaying)
      return;

    cts.Cancel();
  }

  private async UniTask PlayAsync(
    IUIInputQTEPresenter presenter, 
    CharacterMoveKeyCodeData keyCodeData,
    UnityAction onSuccess,
    UnityAction onFail,
    CancellationToken token)
  {
    bool isSuccess = false;
    try
    {
      await presenter.ActivateAsync();
      presenter.OnSequenceBegin();

      var targetCount = currentData.Count;
      var currentCount = 0;
      var durationData = new DurationData(currentData.SequenceDuration, currentData.QTEDuration);
      var playQTE = true;
      while (playQTE)
      {
        var targetDirection = currentData.GetRandomDirection();
        RegisterInputAction(keyCodeData.GetKeyCode(targetDirection));

        token.ThrowIfCancellationRequested();
        durationData.ResetQTEDuration();
        presenter.OnQTEBegin(targetDirection);
        var qteResult = await PlayQTEAsync(presenter, durationData, token);
        
        switch (qteResult)
        {
          case QTEResultType.Success:
            {
              currentCount++;

              if(currentCount == targetCount)
              {
                playQTE = false;
                isSuccess = true;
              }
              presenter.OnQTECountChanged(currentCount);
            }
            break;

          case QTEResultType.Fail:
            {
              switch (currentData.QTEFailType)
              {
                case InputQTEEnum.QTEFaiResultType.None:
                  {

                  }
                  break;

                case InputQTEEnum.QTEFaiResultType.DecreaseOnlyCount:
                  {
                    currentCount = Mathf.Max(0, currentCount - 1);
                    presenter.OnQTECountChanged(currentCount);
                  }
                  break;

                case InputQTEEnum.QTEFaiResultType.DecreaseCountWithFail:
                  {
                    currentCount = Mathf.Max(0, currentCount - 1);
                    presenter.OnQTECountChanged(currentCount);
                    if(currentCount == 0)
                    {
                      playQTE = false;
                      isSuccess = false;
                    }
                  }
                  break;

                case InputQTEEnum.QTEFaiResultType.FailSequence:
                  {
                    playQTE = false;
                    isSuccess = false;
                  }
                  break;                
              }
            }
            break;

          case QTEResultType.SequenceTimeout:
            {
              playQTE = false;
              isSuccess = false;
            }
            break;
        }
        UnregisterInputAction();
      }
    }
    catch (OperationCanceledException)
    {
      UnregisterInputAction();
    }
    finally
    {
      isPlaying = false;

      if (isSuccess)
        onSuccess?.Invoke();
      else
        onFail?.Invoke();
      presenter.OnSequenceResult(isSuccess);
      presenter.DeactivateAsync().Forget();
    }
  }

  private async UniTask<QTEResultType> PlayQTEAsync(
    IUIInputQTEPresenter presenter,
    DurationData durationData,
    CancellationToken token)
  {
    isPerformed = false;

    var hasSequence = durationData.sequenceMaxDuration > 0f;
    var hasQTE = durationData.qteMaxDuration > 0f;
    var sequenceTimeout = false;
    var qteTimeout = false;

    try
    {
      while (!isPerformed && 
             (hasSequence && !sequenceTimeout) && 
             (hasQTE && !qteTimeout))
      {
        token.ThrowIfCancellationRequested();

        float delta = Time.deltaTime;

        if (hasSequence)
        {
          durationData.sequenceDuration -= delta;
          durationData.sequenceDuration = Mathf.Max(durationData.sequenceDuration, 0f);

          presenter.OnSequenceProgress(
            durationData.sequenceDuration / durationData.sequenceMaxDuration
          );

          if (durationData.sequenceDuration <= 0f)
          {
            sequenceTimeout = true;
            isPerformed = false;
            break;
          }
        }

        if (hasQTE)
        {
          durationData.qteDuration -= delta;
          durationData.qteDuration = Mathf.Max(durationData.qteDuration, 0f);          

          presenter.OnQTEProgress(
            durationData.qteDuration / durationData.qteMaxDuration
          );

          qteTimeout = durationData.qteDuration <= 0f;
        }

        await UniTask.Yield(PlayerLoopTiming.Update);
      }

      return CompleteQTE(presenter, sequenceTimeout);
    }
    catch (OperationCanceledException)
    {
      presenter.OnQTEResult(false);
      return QTEResultType.Fail;
    }
  }

  private QTEResultType CompleteQTE(
    IUIInputQTEPresenter presenter,
    bool sequenceTimeout)
  {
    QTEResultType result;

    if (sequenceTimeout)
      result = QTEResultType.SequenceTimeout;
    else if (isPerformed)
      result = QTEResultType.Success;
    else
      result = QTEResultType.Fail;

    presenter.OnQTEResult(result == QTEResultType.Success);

    return result;
  }

  private void RegisterInputAction(KeyCode keyCode)
  {
    qteInputAction = InputActionFactory.Register(InputActionPaths.ParshPath(keyCode), OnInputActionPerformed);
  }

  private void UnregisterInputAction()
  {
    InputActionFactory.Unregister(qteInputAction, OnInputActionPerformed);
    isPerformed = false;
  }

  private void OnInputActionPerformed(InputAction.CallbackContext context)
  {
    if (!isPlaying ||
      context.phase != InputActionPhase.Performed)
      return;

    isPerformed = true;
  }
}
