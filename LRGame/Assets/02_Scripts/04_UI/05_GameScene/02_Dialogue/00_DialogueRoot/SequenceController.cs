using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using LR.UI.GameScene.Dialogue.Character;
using System;
using System.Linq;
using System.Threading;
using UniRx;
using UnityEngine;

namespace LR.UI.GameScene.Dialogue.Root
{
  public class SequenceController : IDisposable
  {
    private enum StateType
    {
      Before,
      After,
      Complete,
    }

    private readonly IGameDataService gameDataService;
    private readonly IDialogueDataProvider dialogueDataProvider;
    private readonly IDialogueSubscriber dialogueSubscriber;
    private readonly IDialogueController dialogueController;
    private readonly IStageStateHandler stageStateHandler;

    private readonly UIDialogueRootPresenter rootPresenter;

    private readonly TalkingSequenceController talkingController;
    private readonly SelectionSequenceController selectionController;

    private readonly UISelectionData selectionTableData;
    private readonly CTSContainer selectionCTS = new();
    private IDialogueSequence.Type prevSequenceType;
    private DialogueData currentDialogueData;
    private StateType dialogueState = StateType.Before;
    private int sequenceIndex = 0;

    public SequenceController(
      GameObject attachTarget,
      TableContainer table,
      IGameDataService gameDataService,
      IResourceManager resourceManager,
      IUIInputActionManager uiInputActionManager,    
      IDialogueDataProvider dialogueDataProvider,
      IDialogueSubscriber dialogueSubscriber, 
      IDialogueController dialogueController,
      IStageStateHandler stageStateHandler,
      UIDialogueRootPresenter rootPresenter,
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
      this.dialogueSubscriber = dialogueSubscriber;
      this.dialogueController = dialogueController;
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
        talkingInputView);
      talkingController.DeactivateAsync(true, default).Forget();

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
      dialogueSubscriber.SubscribeEvent(IDialogueSubscriber.EventType.OnPlay, OnPlayDialogue);
      dialogueSubscriber.SubscribeEvent(IDialogueSubscriber.EventType.OnNextSequence, OnNextSequence);
      dialogueSubscriber.SubscribeEvent(IDialogueSubscriber.EventType.OnSkip, OnSkipDialogue);
      dialogueSubscriber.SubscribeEvent(IDialogueSubscriber.EventType.OnComplete, OnCompleteDialogue);
    }

    private void UnSubscribeService()
    {
      dialogueSubscriber.UnsubscribeEvent(IDialogueSubscriber.EventType.OnPlay, OnPlayDialogue);
      dialogueSubscriber.UnsubscribeEvent(IDialogueSubscriber.EventType.OnNextSequence, OnNextSequence);
      dialogueSubscriber.UnsubscribeEvent(IDialogueSubscriber.EventType.OnSkip, OnSkipDialogue);
      dialogueSubscriber.UnsubscribeEvent(IDialogueSubscriber.EventType.OnComplete, OnCompleteDialogue);
    }

    private async void OnPlayDialogue()
    {
      switch (dialogueState)
      {
        case StateType.Before:
          {
            if (dialogueDataProvider.TryGetBeforeDialogueData(out var beforeDialogueData))
              PlayFirstSequence(beforeDialogueData);
            else
              dialogueController.Complete();
          }
          break;

        case StateType.After:
          {
            if(dialogueDataProvider.TryGetAfterDialogueData(out var afterDialogueData))
              PlayFirstSequence(afterDialogueData);
            else
              dialogueController.Complete();
          }
          break;

        case StateType.Complete:
          {
            dialogueController.Complete();
          }
          break;
      }
    }

    private void OnNextSequence()
    {
      if (prevSequenceType == IDialogueSequence.Type.Talking)
        talkingController.ResetInputs();

      if(currentDialogueData.SequenceSets.Count > sequenceIndex)
      {
        PlaySequence(currentDialogueData.SequenceSets[sequenceIndex]);
      }
      else
      {
        dialogueController.Complete();
      }
    }

    private void OnSkipDialogue()
    {
      selectionCTS.Cancel();
      selectionCTS.Dispose();
      dialogueController.Complete();
    }

    private void OnCompleteDialogue()
    {
      dialogueController.SetState(DialogueState.None);
      sequenceIndex = 0;      

      rootPresenter.DeactivateAsync().Forget();
      talkingController.DeactivateAsync(false, default).Forget();
      talkingController.DisalbeTalkingInputs();
      selectionController.DeactivateAsync(false, default).Forget();

      switch (dialogueState)
      {
        case StateType.Before:
          {
            dialogueState = StateType.After;
            stageStateHandler.SetState(StageEnum.State.Ready);
          }
          break;

        case StateType.After:
          {
            dialogueState = StateType.Complete;
          }
          break;

      }
    }
    #endregion

    private void PlayFirstSequence(DialogueData dialogueData)
    {
      currentDialogueData = dialogueData;
      rootPresenter.ActivateAsync().Forget();

      talkingController.ActivateAsync(false, default).Forget();

      prevSequenceType = IDialogueSequence.Type.Talking;
      var targetSequenceSet = currentDialogueData.SequenceSets[sequenceIndex];      
      PlaySequence(targetSequenceSet);
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

    private void PlayTalkingSequence(DialogueTalkingData talkingData)
    {
      if (prevSequenceType == IDialogueSequence.Type.Selection)
        selectionController.DeactivateAsync(false, default).Forget();
      
      dialogueController.SetState(DialogueState.Talking);
      prevSequenceType = IDialogueSequence.Type.Talking;
      
      talkingController.PlayCharacterDataAsync(talkingData).Forget();
      talkingController.EnableTalkingInputs();
    }

    private async UniTask PlaySelectionSeqeuenceAsync(DialogueSelectionData selectionData, CancellationToken token)
    {
      talkingController.DisalbeTalkingInputs();
      
      dialogueController.SetState(DialogueState.Selecting);
      var prev = prevSequenceType;
      prevSequenceType = IDialogueSequence.Type.Selection;

      selectionController.SetString(selectionData);      

      var duration = new FloatReactiveProperty(selectionTableData.Duration);
      var timerDisposable = selectionController.SubscribeTimer(duration);
      try
      {
        if (prev == IDialogueSequence.Type.Talking)
          await selectionController.ActivateAsync(false, default);

        selectionController.BeginSelecting();
        while(duration.Value > 0.0f)
        {
          duration.Value -= UnityEngine.Time.deltaTime;
          await UniTask.Yield(PlayerLoopTiming.Update);
        }
        duration.Value = 0.0f;
        selectionController.StopSelecting();
        selectionController.GetSelectionResults(out var leftResult, out var rightResult);

        gameDataService.SetDialogueCondition(selectionData.SubName, (int)leftResult, (int)rightResult);
        gameDataService.SaveDataAsync().Forget();

        await UniTask.WaitForSeconds(1.5f);
        dialogueController.NextSequence();
      }
      catch (OperationCanceledException)
      {
        
      }
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
