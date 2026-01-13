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
    public class Duration
    {
      public float max;
      public float current;

      public Duration(float max)
      {
        this.max = max;
        this.current = max;
      }

      public void Reset()
        => current = max;
    }

    public Duration sequence;
    public Duration qte;

    public DurationData(float sequenceMaxDuration, float qteMaxDuration)
    {
      sequence = new(sequenceMaxDuration);
      qte = new(qteMaxDuration);      
    }

    public void ResetQTEDuration()
      => qte.Reset();
  }

  private readonly InputActionFactory InputActionFactory;
  private readonly IInputQTEUIService uiService;
  private readonly ICameraService cameraService;

  private IStageStateProvider stageStateProvider;
  private IStageStateProvider StageStateProvider
  {
    get
    {
      stageStateProvider ??= LocalManager.instance.StageManager;

      return stageStateProvider;
    }
  }

  private readonly CTSContainer cts = new(); 
  private InputAction qteInputAction;  
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

    var hasSequence = durationData.sequence.max > 0f;
    var hasQTE = durationData.qte.max > 0f;
    var sequenceTimeout = false;
    var qteTimeout = false;
    try
    {
      while (!isPerformed && 
             (hasSequence && !sequenceTimeout) && 
             (hasQTE && !qteTimeout))
      {
        token.ThrowIfCancellationRequested();
        if (StageStateProvider.GetState() == StageEnum.State.Pause)
        {
          await UniTask.Yield();
          continue;
        }

        float delta = Time.deltaTime;

        if (hasSequence)
        {
          durationData.sequence.current -= delta;
          durationData.sequence.current = Mathf.Max(durationData.sequence.current, 0f);

          presenter.OnSequenceProgress(durationData.sequence.current / durationData.sequence.max);

          if (durationData.sequence.current <= 0f)
          {
            sequenceTimeout = true;
            isPerformed = false;
            break;
          }
        }

        if (hasQTE)
        {
          durationData.qte.current -= delta;
          durationData.qte.current = Mathf.Max(durationData.qte.current, 0f);          

          presenter.OnQTEProgress(durationData.qte.current / durationData.qte.max);

          qteTimeout = durationData.qte.current <= 0f;
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
      context.phase != InputActionPhase.Performed ||
      StageStateProvider.GetState() != StageEnum.State.Playing)
      return;

    isPerformed = true;
  }
}
