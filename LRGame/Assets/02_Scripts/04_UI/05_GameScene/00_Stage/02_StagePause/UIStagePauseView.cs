using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;
using System;

namespace LR.UI.GameScene.Stage
{
  public class UIStagePauseView : BaseUIView
  {
    [SerializeField] private Vector2 hidePosition;
    [SerializeField] private Vector2 showPosition;
    [SerializeField] private CanvasGroup canvasGroup;
    [field: SerializeField] public RectTransform IndicatorRoot { get; private set; }
    [field: SerializeField] public UIProgressSubmitViewFillSet ResumeProgressFillSubmit {  get; private set; }
    [field: SerializeField] public UIProgressSubmitViewFillSet RestartProgressFillSubmit { get; private set; }
    [field: SerializeField] public UIProgressSubmitViewFillSet QuitProgressFillSubmit { get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {      
      visibleState = VisibleState.Hiding;

      RectTransform.anchoredPosition = hidePosition;
      canvasGroup.alpha = 0.0f;

      visibleState = VisibleState.Hidden;
      gameObject.SetActive(false);
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = VisibleState.Showing;

      try
      {
        var duration = isImmediately ? 0.0f : UISO.StageUIMoveDefaultDuration;
        await DOTween.Sequence()
          .Join(RectTransform.DOAnchorPos(showPosition, duration))
          .Join(canvasGroup.DOFade(1.0f, duration))
          .ToUniTask(TweenCancelBehaviour.Kill, token);

        visibleState = VisibleState.Showing;
      }
      catch (OperationCanceledException) { }      
    }
  }
}