using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.GameScene.Dialogue.Root
{
  public class DialogueInputActionController : IDisposable
  {
    private readonly IDialogueController dialogueController;
    private readonly IUIInputActionManager uiInputActionManager;
    private readonly TextPresentationData textPresentationData; 

    private readonly UnityAction onLeftPerformed;
    private readonly UnityAction onLeftCanceled;
    private readonly UnityAction onRightPerformed;
    private readonly UnityAction onRightCanceled;

    private readonly UnityAction onSkipPressed;
    private readonly UnityAction onSkipCanceled;
    private readonly UnityAction<float> onSkipProgress;
    private readonly CTSContainer skipCTS = new();

    private bool isSubscribed = false;
    private bool isLeftPerformed;
    private bool isRightPerformed;

    public DialogueInputActionController(IDialogueController dialogueController, IUIInputActionManager uiInputActionManager, TextPresentationData textPresentationData, UnityAction onLeftPerformed, UnityAction onLeftCanceled, UnityAction onRightPerformed, UnityAction onRightCanceled, UnityAction onSkipPressed, UnityAction onSkipCanceled, UnityAction<float> onSkipProgress)
    {
      this.dialogueController = dialogueController;
      this.uiInputActionManager = uiInputActionManager;
      this.textPresentationData = textPresentationData;
      this.onLeftPerformed = onLeftPerformed;
      this.onLeftCanceled = onLeftCanceled;
      this.onRightPerformed = onRightPerformed;
      this.onRightCanceled = onRightCanceled;
      this.onSkipPressed = onSkipPressed;
      this.onSkipCanceled = onSkipCanceled;
      this.onSkipProgress = onSkipProgress;
    }

    public void Dispose()
    {
      if(isSubscribed)
        UnsubscribeInputActions();
    }

    public void ResetLeftRightPeformed()
    {
      isLeftPerformed = false;
      isRightPerformed = false;
    }

    public void SubscribeInputActions()
    {
      uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.LeftUp, OnLeftPerformed);
      uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.LeftRight, OnLeftPerformed);
      uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.LeftDown, OnLeftPerformed);
      uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.LeftLeft, OnLeftPerformed);
      uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.LeftUp, OnLeftCanceled);
      uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.LeftRight, OnLeftCanceled);
      uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.LeftDown, OnLeftCanceled);
      uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.LeftLeft, OnLeftCanceled);

      uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.RightUp, OnRightPerformed);
      uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.RightRight, OnRightPerformed);
      uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.RightDown, OnRightPerformed);
      uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.RightLeft, OnRightPerformed);
      uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.RightUp, OnRightCanceled);
      uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.RightRight, OnRightCanceled);
      uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.RightDown, OnRightCanceled);
      uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.RightLeft, OnRightCanceled);

      uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.Space, OnSkipPerformed);
      uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.Space, OnSkipCanceled);

      isSubscribed = true;
    }

    public void UnsubscribeInputActions()
    {
      uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.LeftUp, OnLeftPerformed);
      uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.LeftRight, OnLeftPerformed);
      uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.LeftDown, OnLeftPerformed);
      uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.LeftLeft, OnLeftPerformed);
      uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.LeftUp, OnLeftCanceled);
      uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.LeftRight, OnLeftCanceled);
      uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.LeftDown, OnLeftCanceled);
      uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.LeftLeft, OnLeftCanceled);

      uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.RightUp, OnRightPerformed);
      uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.RightRight, OnRightPerformed);
      uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.RightDown, OnRightPerformed);
      uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.RightLeft, OnRightPerformed);
      uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.RightUp, OnRightCanceled);
      uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.RightRight, OnRightCanceled);
      uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.RightDown, OnRightCanceled);
      uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.RightLeft, OnRightCanceled);

      uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.Space, OnSkipPerformed);
      uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.Space, OnSkipCanceled);

      isSubscribed = false;
    }

    private void OnLeftPerformed()
    {
      onLeftPerformed?.Invoke();

      isLeftPerformed = true;
      if (isLeftPerformed && isRightPerformed)
        dialogueController.NextSequence();
    }

    private void OnLeftCanceled()
    {
      onLeftCanceled?.Invoke();

      isLeftPerformed = false;
    }

    private void OnRightPerformed()
    {
      onRightPerformed?.Invoke();

      isRightPerformed = true;
      if (isLeftPerformed && isRightPerformed)
        dialogueController.NextSequence();
    }

    private void OnRightCanceled()
    {
      onRightCanceled?.Invoke();

      isRightPerformed = false;
    }

    private void OnSkipPerformed()
    {
      onSkipPressed?.Invoke();
      skipCTS.Dispose();
      skipCTS.Create();
      SkipAsync(skipCTS.token).Forget();
    }

    private void OnSkipCanceled()
    {
      onSkipCanceled?.Invoke();
      skipCTS.Cancel();
    }

    private async UniTask SkipAsync(CancellationToken token)
    {
      var duration = 0.0f;
      try
      {
        while(duration < textPresentationData.SkipInputDuration)
        {
          token.ThrowIfCancellationRequested();
          onSkipProgress?.Invoke(duration / textPresentationData.SkipInputDuration);

          duration += Time.deltaTime;
          await UniTask.Yield();
        }
        onSkipProgress?.Invoke(1.0f);
        dialogueController.Skip();
      }
      catch (OperationCanceledException)
      {
        onSkipProgress?.Invoke(0.0f);
      }
    }
  }
}
