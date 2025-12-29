using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using System;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Dialogue.Root
{
  public class TalkingSequenceController
  {
    private readonly UITalkingCharacterPresenter leftCharacterPresenter;
    private readonly UITalkingCharacterPresenter centerCharacterPresenter;
    private readonly UITalkingCharacterPresenter rightCharacterPresenter;
    private readonly UITalkingInputsPresenter inputPresenter;
    private readonly DialogueInputActionController dialogueInputActionController;
    private readonly IDialogueController dialogueController;

    private readonly CTSContainer cts = new();
    private bool isTalkling = false;

    public TalkingSequenceController(
      GameObject attachTarget,
      TableContainer table,
      IResourceManager resourceManager,
      IUIInputActionManager uiInputActionManager,
      IDialogueController dialogueController,
      UITalkingCharacterView leftView,
      UITalkingCharacterView centerView,
      UITalkingCharacterView rightView,
      UITalkingInputsView inputView)
    {
      this.dialogueController = dialogueController;

      var leftModel = new UITalkingCharacterPresenter.Model(
        table.AddressableKeySO.PortraitName,
        UITalkingCharacterPresenter.CharacterType.Left,
        resourceManager,
        table.AddressableKeySO.Path.LeftPortrait,
        table.DialogueUIDataSO.PortraitData,
        table.DialogueUIDataSO.TextPresentationData);
      this.leftCharacterPresenter = new (leftModel, leftView);
      leftCharacterPresenter.AttachOnDestroy(attachTarget);

      var centerModel = new UITalkingCharacterPresenter.Model(
        table.AddressableKeySO.PortraitName,
        UITalkingCharacterPresenter.CharacterType.Center,
        resourceManager,
        table.AddressableKeySO.Path.CenterPortrait,
        table.DialogueUIDataSO.PortraitData,
        table.DialogueUIDataSO.TextPresentationData);
      this.centerCharacterPresenter = new (centerModel, centerView);
      centerCharacterPresenter.AttachOnDestroy(attachTarget);

      var rightModel = new UITalkingCharacterPresenter.Model(
        table.AddressableKeySO.PortraitName,
        UITalkingCharacterPresenter.CharacterType.Right,
        resourceManager,
        table.AddressableKeySO.Path.RightPortrait,
        table.DialogueUIDataSO.PortraitData,
        table.DialogueUIDataSO.TextPresentationData);
      this.rightCharacterPresenter = new (rightModel, rightView);
      rightCharacterPresenter.AttachOnDestroy(attachTarget);

      var inputModel = new UITalkingInputsPresenter.Model(
        table.DialogueUIDataSO.TextPresentationData);
      this.inputPresenter = new (inputModel, inputView);
      inputPresenter.AttachOnDestroy(attachTarget);

      dialogueInputActionController = new(
        dialogueController,
        uiInputActionManager,
        table.DialogueUIDataSO.TextPresentationData,
        onLeftPerformed: inputPresenter.ActivateLeftInput,
        onLeftCanceled: inputPresenter.DeactivateLeftInput,
        onRightPerformed: inputPresenter.ActivateRightInput,
        onRightCanceled: inputPresenter.DeactivateRightInput,
        onLeftRightPerformed: OnLeftRightPerfomed,
        onSkipProgress: inputPresenter.SkipProgress);
    }

    public async UniTask ActivateAsync(bool isImmediately, CancellationToken token)
    {
      leftCharacterPresenter.ActivateAsync().Forget();
      centerCharacterPresenter.ActivateAsync().Forget();
      rightCharacterPresenter.ActivateAsync().Forget();
      inputPresenter.ActivateAsync().Forget();
    }

    public async UniTask DeactivateAsync(bool isImmediately, CancellationToken token)
    {
      leftCharacterPresenter.DeactivateAsync().Forget();
      centerCharacterPresenter.DeactivateAsync().Forget();
      rightCharacterPresenter.DeactivateAsync().Forget();
      inputPresenter.DeactivateAsync().Forget();
    }

    public void ResetInputs()
    {
      dialogueInputActionController.ResetLeftRightPeformed();
      inputPresenter.DeactivateLeftInput();
      inputPresenter.DeactivateRightInput();
    }

    public async UniTask PlayCharacterDataAsync(DialogueTalkingData talkingData)
    {
      cts.Cancel();
      cts.Create();
      var token = cts.token;
      try
      {
        isTalkling = true;
        await UniTask.WhenAll(
          leftCharacterPresenter.PlayCharacterDataAsync(talkingData.left),
          centerCharacterPresenter.PlayCharacterDataAsync(talkingData.center),
          rightCharacterPresenter.PlayCharacterDataAsync(talkingData.right))
          .AttachExternalCancellation(token);

        token.ThrowIfCancellationRequested();
      }
      catch (OperationCanceledException)
      {
        leftCharacterPresenter.CompleteDialogueImmedieately();
        centerCharacterPresenter.CompleteDialogueImmedieately();
        rightCharacterPresenter.CompleteDialogueImmedieately();
      }
      finally
      {
        isTalkling = false;
      }
    }

    public void EnableTalkingInputs()
    {
      dialogueInputActionController.SubscribeInputActions();
    }

    public void DisalbeTalkingInputs()
    {
      dialogueInputActionController.UnsubscribeInputActions();
    }

    private void OnLeftRightPerfomed()
    {
      if (isTalkling)
      {
        cts.Cancel();
      }
      else
      {
        dialogueController.NextSequence();
      }
    }
  }
}
