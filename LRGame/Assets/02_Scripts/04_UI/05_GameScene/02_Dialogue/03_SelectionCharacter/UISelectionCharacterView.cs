using Cysharp.Threading.Tasks;
using DG.Tweening;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Localization.Components;
using LR.UI.Enum;

namespace LR.UI.GameScene.Dialogue
{
  public class UISelectionCharacterView : BaseUIView
  {
    [SerializeField] private CanvasGroup canvasGroup;

    public LocalizeStringEvent upLocalize;
    public LocalizeStringEvent rightLocalize;
    public LocalizeStringEvent downLocalize;
    public LocalizeStringEvent leftLocalize;
    public RectTransform idleRect;
    public RectTransform outlineRect;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Hiding;

      var duration = isImmediately ? 0.0f : UISO.SelectionHideDuration;
      try
      {
        await DOTween.Sequence()
                .Join(canvasGroup.DOFade(0.0f, duration))
                .ToUniTask(TweenCancelBehaviour.Kill, token);
        gameObject.SetActive(false);
        visibleState = VisibleState.Hidden; 
      }
      catch (OperationCanceledException) { }
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = VisibleState.Showing;

      var duration = isImmediately ? 0.0f : UISO.SelectionShowDuration;
      try
      {
        await DOTween.Sequence()
                .Join(canvasGroup.DOFade(1.0f, duration))
                .ToUniTask(TweenCancelBehaviour.Kill, token);
        
        visibleState = VisibleState.Showen;
      }
      catch (OperationCanceledException) { }
    }
  }
}
