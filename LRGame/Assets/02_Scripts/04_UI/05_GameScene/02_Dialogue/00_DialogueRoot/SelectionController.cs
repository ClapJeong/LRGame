using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UniRx;
using UnityEngine;

namespace LR.UI.GameScene.Dialogue.Root
{
  public class SelectionController
  {
    private readonly UISelectionTimerPresenter selectionTimerPresenter;
    private readonly UISelectionCharacterPresenter leftSelectionPresenter;
    private readonly UISelectionCharacterPresenter rightSelectionPresenter;

    private readonly List<Direction> leftSelections = new();
    private readonly List<Direction> rightSelections = new();
    private bool isSelecting = false;   

    public SelectionController(
      GameObject attachTarget,
      TableContainer table,
      IUIInputActionManager uiInputManager,
      UISelectionTimerView timerview,
      UISelectionCharacterView leftView,
      UISelectionCharacterView rightView)
    {
      var timerModel = new UISelectionTimerPresenter.Model();
      selectionTimerPresenter = new UISelectionTimerPresenter(timerModel, timerview);
      selectionTimerPresenter.AttachOnDestroy(attachTarget);

      var leftModel = new UISelectionCharacterPresenter.Model(
        PlayerType.Left,
        table.DialogueUIDataSO.TextPresentationData,
        uiInputManager,
        OnLeftSelect,
        OnLeftCanceled);
      leftSelectionPresenter = new(leftModel, leftView);
      leftSelectionPresenter.AttachOnDestroy(attachTarget);

      var rightModel = new UISelectionCharacterPresenter.Model(
        PlayerType.Right,
        table.DialogueUIDataSO.TextPresentationData,
        uiInputManager,
        OnRightSelect,
        OnRightCanceled);
      rightSelectionPresenter = new(rightModel, rightView);
      rightSelectionPresenter.AttachOnDestroy(attachTarget);
    }

    public async UniTask ActivateAsync(bool isImmediately, CancellationToken token)
    {
      await UniTask.WhenAll(
      selectionTimerPresenter.ActivateAsync(isImmediately, token),
      leftSelectionPresenter.ActivateAsync(isImmediately, token),
      rightSelectionPresenter.ActivateAsync(isImmediately, token));
    }

    public async UniTask DeactivateAsync(bool isImmediately, CancellationToken token)
    {
      await UniTask.WhenAll(
      selectionTimerPresenter.DeactivateAsync(isImmediately, token),
      leftSelectionPresenter.DeactivateAsync(isImmediately, token),
      rightSelectionPresenter.DeactivateAsync(isImmediately, token));
    }

    public void SetString(DialogueSelectionData selectionData)
    {
      selectionTimerPresenter.SetString(selectionData.DescriptionKey);
      leftSelectionPresenter.SetStrings(selectionData);
      rightSelectionPresenter.SetStrings(selectionData);
    }

    public IDisposable SubscribeTimer( FloatReactiveProperty time)
      => selectionTimerPresenter.SubscribeTimer(time);

    public void BeginSelecting()
    {
      isSelecting = true;
      leftSelections.Clear();
      rightSelections.Clear();
    }

    public void StopSelecting()
    {
      isSelecting = false;
    }

    public void GetSelectionResults(out Direction leftResult, out Direction rightResult)
    {
      leftResult = leftSelections.Count > 0 ? leftSelections.Last() : DirectionExtension.Random();
      rightResult = rightSelections.Count > 0 ? rightSelections.Last() : DirectionExtension.Random();

      leftSelectionPresenter.SetOutlinePosition(leftResult);
      rightSelectionPresenter.SetOutlinePosition(rightResult);
    }

    private void OnLeftSelect(Direction direction)
    {
      if (isSelecting == false)
        return;

      leftSelections.Add(direction);
      leftSelectionPresenter.SetOutlinePosition(direction);
    }

    private void OnLeftCanceled(Direction direction)
    {
      if (isSelecting == false)
        return;

      if (leftSelections.Contains(direction))
      {
        leftSelections.Remove(direction);
        var targetDirection = leftSelections.Count > 0 ? leftSelections.Last()
                                                       : Direction.Space;
        leftSelectionPresenter.SetOutlinePosition(targetDirection);
      }
    }

    private void OnRightSelect(Direction direction)
    {
      if (isSelecting == false)
        return;

      rightSelections.Add(direction);
      rightSelectionPresenter.SetOutlinePosition(direction);
    }

    private void OnRightCanceled(Direction direction) 
    {
      if (isSelecting == false)
        return;

      if (rightSelections.Contains(direction))
      {
        rightSelections.Remove(direction);
        var targetDirection = rightSelections.Count > 0 ? rightSelections.Last()
                                                        : Direction.Space;
        rightSelectionPresenter.SetOutlinePosition(targetDirection);
      }
    }
  }
}
