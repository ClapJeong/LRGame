using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
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
        onSkipPressed: null,
        onSkipCanceled: null,
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
      leftCharacterPresenter.PlayCharacterDataAsync(talkingData.left).Forget();
      centerCharacterPresenter.PlayCharacterDataAsync(talkingData.center).Forget();
      rightCharacterPresenter.PlayCharacterDataAsync(talkingData.right).Forget();
    }

    public void EnableTalkingInputs()
    {
      dialogueInputActionController.SubscribeInputActions();
    }

    public void DisalbeTalkingInputs()
    {
      dialogueInputActionController.UnsubscribeInputActions();
    }
  }
}
