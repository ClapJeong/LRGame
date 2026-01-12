using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using System;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Dialogue.Root
{
  public class TalkingController
  {
    private readonly UITalkingCharacterPresenter leftCharacterPresenter;
    private readonly UITalkingCharacterPresenter centerCharacterPresenter;
    private readonly UITalkingCharacterPresenter rightCharacterPresenter;
    private readonly UITalkingInputsPresenter inputPresenter;
    private readonly DialogueInputActionController dialogueInputActionController;
    private readonly IDialogueStateController dialogueController;

    private readonly CTSContainer cts = new();
    private bool isTalkling = false;

    public TalkingController(
      GameObject attachTarget,
      TableContainer table,
      IResourceManager resourceManager,
      IUIInputActionManager uiInputActionManager,
      IDialogueStateController dialogueController,
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
      await UniTask.WhenAll(
        leftCharacterPresenter.ActivateAsync(isImmediately, token),
      centerCharacterPresenter.ActivateAsync(isImmediately, token),
      rightCharacterPresenter.ActivateAsync(isImmediately, token),
      inputPresenter.ActivateAsync(isImmediately, token));     
    }

    public async UniTask DeactivateAsync(bool isImmediately, CancellationToken token)
    {
      await UniTask.WhenAll(
        leftCharacterPresenter.DeactivateAsync(isImmediately, token),
      centerCharacterPresenter.DeactivateAsync(isImmediately, token),
      rightCharacterPresenter.DeactivateAsync(isImmediately, token),
      inputPresenter.DeactivateAsync(isImmediately, token));
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
