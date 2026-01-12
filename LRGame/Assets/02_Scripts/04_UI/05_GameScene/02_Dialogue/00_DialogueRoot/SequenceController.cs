using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using LR.UI.GameScene.Dialogue.Character;
using System;
using System.Linq;
using System.Threading;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using static LR.Table.Dialogue.DialogueData;

namespace LR.UI.GameScene.Dialogue.Root
{
  public class SequenceController : IDisposable
  {
    private enum TargetDialogueType
    {
      BeforeStage,
      AfterStage,
    }

    private readonly IGameDataService gameDataService;
    private readonly IDialogueDataProvider dialogueDataProvider;
    private readonly IDialogueStateSubscriber dialogueStateSubscriber;
    private readonly IDialogueStateController dialogueStateController;
    private readonly IStageStateHandler stageStateHandler;

    private readonly UIDialogueRootPresenter rootPresenter;

    private readonly TalkingController talkingController;
    private readonly SelectionController selectionController;

    private readonly UISelectionData selectionTableData;
    private readonly CTSContainer selectionCTS = new();
    private readonly CTSContainer backgroundCTS = new();
    private IDialogueSequence.Type prevSequenceType;
    private DialogueData currentDialogueData;
    private TargetDialogueType dialogueState = TargetDialogueType.BeforeStage;
    private int sequenceIndex = 0;

    public SequenceController(
      GameObject attachTarget,
      TableContainer table,
      IGameDataService gameDataService,
      IResourceManager resourceManager,
      IUIInputActionManager uiInputActionManager,    
      IDialogueDataProvider dialogueDataProvider,
      IDialogueStateSubscriber dialogueSubscriber, 
      IDialogueStateController dialogueController,
      IStageStateHandler stageStateHandler,
      UIDialogueRootPresenter rootPresenter,
      Image backgroundA,
      Image backgroundB,
      UITalkingCharacterView leftTalkingView,
      UITalkingCharacterView centerTalkingView,
      UITalkingCharacterView rightTalkingView,
      UITalkingInputsView talkingInputView,
      UISelectionCharacterView leftSelectionView,
      UISelectionCharacterView rightSelectionView,
      UISelectionTimerView selectionTimerView)
    {
      this.gameDataService = gameDataService;
      this.dialogueDataProvider = dialogueDataProvider;
      this.dialogueStateSubscriber = dialogueSubscriber;
      this.dialogueStateController = dialogueController;
      this.stageStateHandler = stageStateHandler;
      this.rootPresenter = rootPresenter;
      this.selectionTableData = table.DialogueUIDataSO.SelectionData;

      talkingController = new(
        attachTarget,
        table,
        resourceManager,
        uiInputActionManager,
        dialogueController,
        leftTalkingView,
        centerTalkingView,
        rightTalkingView,
        talkingInputView,
        backgroundA,
        backgroundB);
      talkingController.DeactivateAsync(true, default).Forget();

      if (dialogueDataProvider.TryGetBeforeDialogueData(out var beforeDialogueData))
      {
        var firstData = GetEnableSequence(beforeDialogueData.SequenceSets.First());
        if (firstData.SequenceType == IDialogueSequence.Type.Talking)
          talkingController.ChangeBackgroundAsync(((DialogueTalkingData)firstData).Background, true, default).Forget();
      }

      selectionController = new(
        attachTarget,
        table,
        uiInputActionManager,
        selectionTimerView,
        leftSelectionView,
        rightSelectionView);
      selectionController.DeactivateAsync(true, default).Forget();

      SubscribeService();
    }

    #region Dialogue Events&Subscribe
    private void SubscribeService()
    {
      dialogueStateSubscriber.SubscribeEvent(IDialogueStateSubscriber.EventType.OnPlay, OnPlayDialogue);
      dialogueStateSubscriber.SubscribeEvent(IDialogueStateSubscriber.EventType.OnNextSequence, OnNextSequence);
      dialogueStateSubscriber.SubscribeEvent(IDialogueStateSubscriber.EventType.OnSkip, OnSkipDialogue);
      dialogueStateSubscriber.SubscribeEvent(IDialogueStateSubscriber.EventType.OnComplete, OnCompleteDialogue);
    }

    private void UnSubscribeService()
    {
      dialogueStateSubscriber.UnsubscribeEvent(IDialogueStateSubscriber.EventType.OnPlay, OnPlayDialogue);
      dialogueStateSubscriber.UnsubscribeEvent(IDialogueStateSubscriber.EventType.OnNextSequence, OnNextSequence);
      dialogueStateSubscriber.UnsubscribeEvent(IDialogueStateSubscriber.EventType.OnSkip, OnSkipDialogue);
      dialogueStateSubscriber.UnsubscribeEvent(IDialogueStateSubscriber.EventType.OnComplete, OnCompleteDialogue);
    }

    private void OnPlayDialogue()
    {
      sequenceIndex = 0;

      switch (dialogueState)
      {
        case TargetDialogueType.BeforeStage:
          {
            if (dialogueDataProvider.TryGetBeforeDialogueData(out var beforeDialogueData))
              PlayFirstSequenceAsync(beforeDialogueData).Forget();
            else
              dialogueStateController.Complete();
          }
          break;

        case TargetDialogueType.AfterStage:
          {
            if(dialogueDataProvider.TryGetAfterDialogueData(out var afterDialogueData))
            {
              var firstData = GetEnableSequence(afterDialogueData.SequenceSets.First());
              if (firstData.SequenceType == IDialogueSequence.Type.Talking)
                talkingController.ChangeBackgroundAsync(((DialogueTalkingData)firstData).Background, true, default).Forget();

              rootPresenter.ActivateAsync().Forget();
              PlayFirstSequenceAsync(afterDialogueData).Forget();
            }              
            else
              dialogueStateController.Complete();
          }
          break;
      }
    }

    private void OnNextSequence()
    {
      if (prevSequenceType == IDialogueSequence.Type.Talking)
        talkingController.ResetInputs();

      var isLastSequence = currentDialogueData.SequenceSets.Count == sequenceIndex;
      if (isLastSequence == false)
        PlaySequence(currentDialogueData.SequenceSets[sequenceIndex]);
      else
        dialogueStateController.Complete();
    }

    private void OnSkipDialogue()
    {
      selectionCTS.Cancel();
      backgroundCTS.Cancel();

      dialogueStateController.Complete();
    }

    private void OnCompleteDialogue()
    {
      dialogueStateController.SetSequenceState(SequenceState.Complete);      

      rootPresenter.DeactivateAsync().Forget();
      talkingController.DeactivateAsync(false, default).Forget();
      talkingController.DisalbeTalkingInputs();
      selectionController.DeactivateAsync(false, default).Forget();

      if(dialogueState == TargetDialogueType.BeforeStage)
      {
        dialogueState = TargetDialogueType.AfterStage;
        stageStateHandler.SetState(StageEnum.State.Ready);
      }
    }
    #endregion

    private async UniTask PlayFirstSequenceAsync(DialogueData dialogueData)
    {
      currentDialogueData = dialogueData;
      
      await talkingController.ActivateAsync(false, default);

      prevSequenceType = IDialogueSequence.Type.Talking;
      var targetSequenceSet = currentDialogueData.SequenceSets[sequenceIndex];      
      PlaySequence(targetSequenceSet);
    }

    private void PlaySequence(DialogueData.SequenceSet sequenceSet)
    {
      var targetSequence = GetEnableSequence(sequenceSet);

      switch (sequenceSet.SequenceType)
      {
        case IDialogueSequence.Type.Talking:
          {
            PlayTalkingSequence(targetSequence as DialogueTalkingData);
          }          
          break;

        case IDialogueSequence.Type.Selection:
          {
            selectionCTS.Cancel();
            selectionCTS.Create();
            PlaySelectionSeqeuenceAsync(targetSequence as DialogueSelectionData, selectionCTS.token).Forget();
          }
          break;

        default: throw new System.NotImplementedException();
      }

      sequenceIndex++;
    }

    private DialogueSequenceBase GetEnableSequence(DialogueData.SequenceSet sequenceSet)
    {
      DialogueSequenceBase targetSequence = null;
      if (sequenceSet.Sequences.Count == 1)
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
      return targetSequence;
    }

    private async UniTask SetSequenceTypeAsync(IDialogueSequence.Type sequenceType)
    {
      switch (prevSequenceType)
      {
        case IDialogueSequence.Type.Talking:
          {
            if(sequenceType == IDialogueSequence.Type.Selection)
            {
              talkingController.DisalbeTalkingInputs();
              talkingController.ClearTexts();
              await selectionController.ActivateAsync(false, default);
            }
          }          
          break;

        case IDialogueSequence.Type.Selection:
          {
            if(sequenceType == IDialogueSequence.Type.Talking)
            {
              selectionController.DeactivateAsync(false, default).Forget();
            }
          }          
          break;
      }

      dialogueStateController.SetSequenceState(sequenceType switch
      {
        IDialogueSequence.Type.Talking => SequenceState.Talking,
        IDialogueSequence.Type.Selection => SequenceState.Selecting,
        _ => throw new System.NotImplementedException(),
      });
      prevSequenceType = sequenceType;
    }

    private void PlayTalkingSequence(DialogueTalkingData talkingData)
    {
      SetSequenceTypeAsync(IDialogueSequence.Type.Talking).Forget();

      backgroundCTS.Cancel();
      backgroundCTS.Create();
      talkingController.ChangeBackgroundAsync(talkingData.Background, false, backgroundCTS.token).Forget();
      talkingController.PlayCharacterDataAsync(talkingData).Forget();
      talkingController.EnableTalkingInputs();
    }

    private async UniTask PlaySelectionSeqeuenceAsync(DialogueSelectionData selectionData, CancellationToken token)
    {
      selectionController.SetString(selectionData);      

      var normalized = new FloatReactiveProperty(1.0f);
      var timerDisposable = selectionController.SubscribeTimer(normalized);
      try
      {
        await SetSequenceTypeAsync(IDialogueSequence.Type.Selection);

        selectionController.BeginSelecting();
        var duration = selectionTableData.Duration;
        while (duration > 0.0f)
        {
          duration -= Time.deltaTime;
          normalized.Value = duration / selectionTableData.Duration;
          await UniTask.Yield(PlayerLoopTiming.Update);
        }
        normalized.Value = 0.0f;
        selectionController.StopSelecting();

        selectionController.GetSelectionResults(out var leftResult, out var rightResult);

        gameDataService.SetDialogueCondition(selectionData.SubName, (int)leftResult, (int)rightResult);
        gameDataService.SaveDataAsync().Forget();

        await UniTask.WaitForSeconds(1.0f);
        dialogueStateController.NextSequence();
      }
      catch (OperationCanceledException) { }
      finally
      {
        selectionController.StopSelecting();
        timerDisposable.Dispose();
      }
    }

    public void Dispose()
    {
      UnSubscribeService();
    }
  }
}
