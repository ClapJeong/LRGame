using Cysharp.Threading.Tasks;
using DG.Tweening;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerScoreView : BaseUIView
  {
    [SerializeField] private Vector2 hidePosition;
    [SerializeField] private Vector2 showPosition;
    [SerializeField] private CanvasGroup canvasGroup;
    [field: SerializeField] public Image FillImage { get; private set; }
    [field: SerializeField] public RectTransform ScoreMarkerRectTransform { get; private set; }
    [field: SerializeField] public Image ScoreMarkerImage {  get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = Enum.VisibleState.Hiding;

      try
      {
        var duration = isImmediately ? 0.0f : UISO.ScoreHideDuration;
        await DOTween.Sequence()
          .Join(RectTransform.DOAnchorPos(hidePosition, duration))
          .Join(canvasGroup.DOFade(0.0f, duration))
          .ToUniTask(TweenCancelBehaviour.Kill, token);

        gameObject.SetActive(false);
        visibleState = Enum.VisibleState.Hidden;
      }
      catch (OperationCanceledException) { }   
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = Enum.VisibleState.Showing;
      try
      {
        FillImage.fillAmount = 0.0f;
        gameObject.SetActive(true);
        var duration = isImmediately ? 0.0f : UISO.ScoreShowDuration;
        await DOTween.Sequence()
          .Join(RectTransform.DOAnchorPos(showPosition, duration))
          .Join(canvasGroup.DOFade(1.0f, duration))
          .ToUniTask(TweenCancelBehaviour.Complete, token);
        visibleState = Enum.VisibleState.Showen;
      }
      catch (OperationCanceledException) { }
    }
  }
}
