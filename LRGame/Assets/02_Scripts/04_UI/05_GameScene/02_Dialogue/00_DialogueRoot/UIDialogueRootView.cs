using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Dialogue
{
  public class UIDialogueRootView : BaseUIView
  {
    [field: SerializeField] private CanvasGroup backgroundCanvasGroup;
    [field: SerializeField] private RectTransform dialogueContainer;

    [Header("[ Talking ]")]
    public UITalkingCharacterView leftTalkingCharacterView;
    public UITalkingCharacterView centerTalkingCharacterView;
    public UITalkingCharacterView rightTalkingCharacterView;
    public UITalkingInputsView talkingInputView;

    [Header("[ Selectoin ]")]
    public UISelectionCharacterView leftSelectionCharacterView;
    public UISelectionCharacterView rightSelectionCharacterView;
    public UISelectionTimerView selectionTimerView;

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showing;
      gameObject.SetActive(true);
      dialogueContainer.gameObject.SetActive(false);      

      await DOTween.Sequence()
        .Join(backgroundCanvasGroup.DOFade(1.0f, UISO.DialogueRootShowDuratoin))
        .ToUniTask(TweenCancelBehaviour.Kill, token);

      dialogueContainer.gameObject.SetActive(true);
      visibleState = UIVisibleState.Showen;      
    }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hiding;
      dialogueContainer.gameObject.SetActive(false);
      await DOTween.Sequence()
        .Join(backgroundCanvasGroup.DOFade(0.0f, UISO.DialogueRootHideDuratoin))
        .ToUniTask(TweenCancelBehaviour.Kill, token);
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
    }
  }
}
