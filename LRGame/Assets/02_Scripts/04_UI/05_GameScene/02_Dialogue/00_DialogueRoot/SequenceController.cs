using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using System;
using System.Linq;

namespace LR.UI.GameScene.Dialogue.Root
{
  public class SequenceController : IDisposable
  {
    private readonly IGameDataService gameDataService;
    private readonly IDialogueDataProvider dialogueDataProvider;
    private readonly IDialogueSubscriber subscriber;
    private readonly IDialogueController controller;
    private readonly IStageStateHandler stageStateHandler;

    private readonly UIDialogueRootPresenter rootPresenter;
    private readonly UIDialogueCharacterPresenter leftPresenter;
    private readonly UIDialogueCharacterPresenter centerPresenter;
    private readonly UIDialogueCharacterPresenter rightPresenter;
    private readonly UIDialogueInputsPresenter inputPresenter;
    private readonly DialogueInputActionController dialogueInputActionController;

    private DialogueData currentDialogueData;
    private bool isPlayedBeforeDialogue = false;
    private int sequenceIndex = 0;

    public SequenceController(
      TableContainer table,
      IGameDataService gameDataService,
      IUIInputActionManager uiInputActionManager,    
      IDialogueDataProvider dialogueDataProvider,
      IDialogueSubscriber subscriber, 
      IDialogueController controller,
      IStageStateHandler stageStateHandler,
      UIDialogueRootPresenter rootPresenter,
      UIDialogueCharacterPresenter leftPresenter,
      UIDialogueCharacterPresenter centerPresenter,
      UIDialogueCharacterPresenter rightPresenter,
      UIDialogueInputsPresenter inputPresenter)
    {
      this.gameDataService = gameDataService;
      this.dialogueDataProvider = dialogueDataProvider;
      this.subscriber = subscriber;
      this.controller = controller;
      this.stageStateHandler = stageStateHandler;
      this.rootPresenter = rootPresenter;
      this.leftPresenter = leftPresenter;
      this.centerPresenter = centerPresenter;
      this.rightPresenter = rightPresenter;
      this.inputPresenter = inputPresenter;

      dialogueInputActionController = new(
        controller,
        uiInputActionManager,
        table.DialogueDataSO.TextPresentationData,
        onLeftPerformed: inputPresenter.ActivateLeftInput,
        onLeftCanceled: inputPresenter.DeactivateLeftInput,
        onRightPerformed: inputPresenter.ActivateRightInput,
        onRightCanceled: inputPresenter.DeactivateRightInput,
        onSkipPressed: null,
        onSkipCanceled: null,
        onSkipProgress: inputPresenter.SkipProgress);

      SubscribeService();
    }

    #region Dialogue Events&Subscribe
    private void SubscribeService()
    {
      subscriber.SubscribeEvent(IDialogueSubscriber.EventType.OnPlay, OnPlayDialogue);
      subscriber.SubscribeEvent(IDialogueSubscriber.EventType.OnNextSequence, OnNextSequence);
      subscriber.SubscribeEvent(IDialogueSubscriber.EventType.OnSkip, OnSkipDialogue);
      subscriber.SubscribeEvent(IDialogueSubscriber.EventType.OnComplete, OnCompleteDialogue);
    }

    private void UnSubscribeService()
    {
      subscriber.UnsubscribeEvent(IDialogueSubscriber.EventType.OnPlay, OnPlayDialogue);
      subscriber.UnsubscribeEvent(IDialogueSubscriber.EventType.OnNextSequence, OnNextSequence);
      subscriber.UnsubscribeEvent(IDialogueSubscriber.EventType.OnSkip, OnSkipDialogue);
      subscriber.UnsubscribeEvent(IDialogueSubscriber.EventType.OnComplete, OnCompleteDialogue);
    }

    private async void OnPlayDialogue()
    {
      if (!isPlayedBeforeDialogue &&
          dialogueDataProvider.TryGetBeforeDialogueData(out var beforeDialogueData))
      {
        PlayFirstSequence(beforeDialogueData);        
      }
      else if(isPlayedBeforeDialogue &&
              dialogueDataProvider.TryGetAfterDialogueData(out var afterDialogueData))
      {
        PlayFirstSequence(afterDialogueData);
      }
      else
      {
        controller.Complete();
      }
    }

    private void OnNextSequence()
    {
      dialogueInputActionController.ResetLeftRightPeformed();
      inputPresenter.DeactivateLeftInput();
      inputPresenter.DeactivateRightInput();

      if(currentDialogueData.SequenceSets.Count > sequenceIndex)
      {
        PlaySequence(currentDialogueData.SequenceSets[sequenceIndex]);
      }
      else
      {
        controller.Complete();
      }
    }

    private void OnSkipDialogue()
    {
      controller.Complete();
    }

    private void OnCompleteDialogue()
    {
      controller.SetState(DialogueState.None);
      sequenceIndex = 0;
      isPlayedBeforeDialogue = true;

      rootPresenter.DeactivateAsync().Forget();
      leftPresenter.DeactivateAsync().Forget();
      rightPresenter.DeactivateAsync().Forget();
      centerPresenter.DeactivateAsync().Forget();
      inputPresenter.DeactivateAsync().Forget();
      dialogueInputActionController.UnsubscribeInputActions();

      stageStateHandler.SetState(IStageStateHandler.State.Ready);
    }
    #endregion

    private void PlayFirstSequence(DialogueData dialogueData)
    {
      currentDialogueData = dialogueData;
      rootPresenter.ActivateAsync().Forget();
      leftPresenter.ActivateAsync().Forget();
      centerPresenter.ActivateAsync().Forget();
      rightPresenter.ActivateAsync().Forget();
      inputPresenter.ActivateAsync().Forget();
      dialogueInputActionController.SubscribeInputActions();

      PlaySequence(currentDialogueData.SequenceSets[sequenceIndex]);      
    }

    private void PlaySequence(DialogueData.SequenceSet sequenceSet)
    {
      DialogueSequenceBase targetSequence = null;
      if(sequenceSet.Sequences.Count == 1)
      {
        targetSequence = sequenceSet.Sequences[0];
      }
      else
      {
        targetSequence = sequenceSet.Sequences.FirstOrDefault(sequence =>
        {
          var targetCondition = sequence.GetCondition();
          return gameDataService.IsContainsCondition(targetCondition.TargetSubName, targetCondition.LeftKey, targetCondition.RightKey);
        });
        targetSequence ??= sequenceSet.Sequences[0];
      }

      switch (sequenceSet.SequenceType)
      {
        case IDialogueSequence.Type.Talking:
          PlayTalkingSequence(targetSequence as DialogueTalkingData);
          break;

        case IDialogueSequence.Type.Selection:
          PlaySelectionSeqeuence(targetSequence as DialogueSelectionData);
          break;

        default: throw new System.NotImplementedException();
      }
      sequenceIndex++;
    }

    private void PlayTalkingSequence(DialogueTalkingData talkingData)
    {
      controller.SetState(DialogueState.Talking);
      leftPresenter.PlayCharacterDataAsync(talkingData.left).Forget();
      centerPresenter.PlayCharacterDataAsync(talkingData.center).Forget();
      rightPresenter.PlayCharacterDataAsync(talkingData.right).Forget();
    }

    private void PlaySelectionSeqeuence(DialogueSelectionData selectionData)
    {
      controller.SetState(DialogueState.Selecting);
      //TODO: Selection
    }

    public void Dispose()
    {
      UnSubscribeService();
    }
  }
}
