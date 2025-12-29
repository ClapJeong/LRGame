using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Dialogue
{
  public class UIDialogueRootView : BaseUIView
  {
    [Header("[ Talking ]")]
    public UITalkingCharacterView leftTalkingCharacterView;
    public UITalkingCharacterView centerTalkingCharacterView;
    public UITalkingCharacterView rightTalkingCharacterView;
    public UITalkingInputsView talkingInputView;

    [Header("[ Selectoin ]")]
    public UISelectionCharacterView leftSelectionCharacterView;
    public UISelectionCharacterView rightSelectionCharacterView;
    public UISelectionTimerView selectionTimerView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}
