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
    private readonly UITextPresentationData textPresentationData; 

    private readonly UnityAction onLeftPerformed;
    private readonly UnityAction onLeftCanceled;
    private readonly UnityAction onRightPerformed;
    private readonly UnityAction onRightCanceled;

    private readonly UnityAction onLeftRightPerformed;

    private readonly UnityAction<float> onSkipProgress;
    private readonly CTSContainer skipCTS = new();

    private bool isSubscribed = false;
    private bool isLeftPerformed;
    private bool isRightPerformed;

    public DialogueInputActionController(IDialogueController dialogueController, IUIInputActionManager uiInputActionManager, UITextPresentationData textPresentationData, UnityAction onLeftPerformed, UnityAction onLeftCanceled, UnityAction onRightPerformed, UnityAction onRightCanceled, UnityAction onLeftRightPerformed, UnityAction<float> onSkipProgress)
    {
      this.dialogueController = dialogueController;
      this.uiInputActionManager = uiInputActionManager;
      this.textPresentationData = textPresentationData;
      this.onLeftPerformed = onLeftPerformed;
      this.onLeftCanceled = onLeftCanceled;
      this.onRightPerformed = onRightPerformed;
      this.onRightCanceled = onRightCanceled;
      this.onLeftRightPerformed = onLeftRightPerformed;
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
      if (isSubscribed)
        return;

      var leftDirections = UIInputDirectionTypeUtil.GetLefts();
      uiInputActionManager.SubscribePerformedEvent(leftDirections, OnLeftPerformed);
      uiInputActionManager.SubscribeCanceledEvent(leftDirections, OnLeftCanceled);

      var rightDirections = UIInputDirectionTypeUtil.GetRights();
      uiInputActionManager.SubscribePerformedEvent(rightDirections, OnRightPerformed);
      uiInputActionManager.SubscribeCanceledEvent(rightDirections, OnRightCanceled);

      var space = UIInputDirection.Space;
      uiInputActionManager.SubscribePerformedEvent(space, OnSkipPerformed);
      uiInputActionManager.SubscribeCanceledEvent(space, OnSkipCanceled);

      isSubscribed = true;
    }

    public void UnsubscribeInputActions()
    {
      if (isSubscribed == false)
        return;

      var leftDirections = UIInputDirectionTypeUtil.GetLefts();
      uiInputActionManager.UnsubscribePerformedEvent(leftDirections, OnLeftPerformed);
      uiInputActionManager.UnsubscribeCanceledEvent(leftDirections, OnLeftCanceled);

      var rightDirections = UIInputDirectionTypeUtil.GetRights();
      uiInputActionManager.UnsubscribePerformedEvent(rightDirections, OnRightPerformed);
      uiInputActionManager.UnsubscribeCanceledEvent(rightDirections, OnRightCanceled);

      var space = UIInputDirection.Space;
      uiInputActionManager.UnsubscribePerformedEvent(space, OnSkipPerformed);
      uiInputActionManager.UnsubscribeCanceledEvent(space, OnSkipCanceled);

      isSubscribed = false;
    }

    private void OnLeftPerformed()
    {
      onLeftPerformed?.Invoke();

      isLeftPerformed = true;
      if (isLeftPerformed && isRightPerformed)
        onLeftRightPerformed?.Invoke();
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
        onLeftRightPerformed?.Invoke();
    }

    private void OnRightCanceled()
    {
      onRightCanceled?.Invoke();

      isRightPerformed = false;
    }

    private void OnSkipPerformed()
    {
      skipCTS.Dispose();
      skipCTS.Create();
      SkipAsync(skipCTS.token).Forget();
    }

    private void OnSkipCanceled()
    {
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
