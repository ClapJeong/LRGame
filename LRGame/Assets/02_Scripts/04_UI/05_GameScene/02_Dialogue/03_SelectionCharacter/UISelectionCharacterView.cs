using Cysharp.Threading.Tasks;
using DG.Tweening;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace LR.UI.GameScene.Dialogue
{
  public class UISelectionCharacterView : BaseUIView
  {
    [SerializeField] private Vector2 beforeShowPosition;
    [SerializeField] private Vector2 idlePosition;
    [SerializeField] private Vector2 afterHidePosition;
    [SerializeField] private CanvasGroup canvasGroup;

    public LocalizeStringEvent upLocalize;
    public LocalizeStringEvent rightLocalize;
    public LocalizeStringEvent downLocalize;
    public LocalizeStringEvent leftLocalize;
    public RectTransform idleRect;
    public RectTransform outlineRect;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hiding;

      var duration = isImmediately ? 0.0f : UISO.SelectionHideDuration;
      try
      {
        RectTransform.anchoredPosition = idlePosition;
        await DOTween.Sequence()
                .Join(RectTransform.DOAnchorPos(afterHidePosition, duration))
                .Join(canvasGroup.DOFade(0.0f, duration))
                .ToUniTask(TweenCancelBehaviour.Kill, token);
        gameObject.SetActive(false);
        visibleState = UIVisibleState.Hidden; 
      }
      catch (OperationCanceledException) { }
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showing;

      var duration = isImmediately ? 0.0f : UISO.SelectionShowDuration;
      try
      {
        RectTransform.anchoredPosition = beforeShowPosition;
        await DOTween.Sequence()
                .Join(RectTransform.DOAnchorPos(idlePosition, duration))
                .Join(canvasGroup.DOFade(1.0f, duration))
                .ToUniTask(TweenCancelBehaviour.Kill, token);
        
        visibleState = UIVisibleState.Showen;
      }
      catch (OperationCanceledException) { }
    }
  }
}
