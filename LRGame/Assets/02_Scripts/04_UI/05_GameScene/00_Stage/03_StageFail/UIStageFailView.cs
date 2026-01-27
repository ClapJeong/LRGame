using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;
using System;

namespace LR.UI.GameScene.Stage
{
  public class UIStageFailView : BaseUIView
  {
    [SerializeField] private Vector2 hidePosition;
    [SerializeField] private Vector2 showPosition;
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private RectTransform content;

    [field: SerializeField] public Transform IndicatorRoot { get; private set; }
    [field: SerializeField] public UIProgressSubmitViewFillSet RestartProgressSubmitSet { get; private set; }
    [field: SerializeField] public UIProgressSubmitViewFillSet QuitProgressSubmitSet { get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Hiding;

      var duration = isImmediately ? 0.0f : UISO.StageUIMoveDefaultDuration;
      try
      {
        await DOTween.Sequence()
                .Join(content.DOAnchorPos(hidePosition, duration))
                .Join(canvasGroup.DOFade(0.0f, duration))
                .OnComplete(() =>
                {
                  visibleState = VisibleState.Hidden;
                  gameObject.SetActive(false);
                })
                .ToUniTask(TweenCancelBehaviour.Kill, token);
      }
      catch (OperationCanceledException) { }
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = VisibleState.Showing;

      var duration = isImmediately ? 0.0f : UISO.StageUIMoveDefaultDuration;
      try
      {
        await DOTween.Sequence()
                .Join(content.DOAnchorPos(showPosition, duration))
                .Join(canvasGroup.DOFade(1.0f, duration))
                .OnComplete(() =>
                {
                  visibleState = VisibleState.Showen;
                })
                .ToUniTask(TweenCancelBehaviour.Kill, token);
      }
      catch (OperationCanceledException) { }
    }
  }
}