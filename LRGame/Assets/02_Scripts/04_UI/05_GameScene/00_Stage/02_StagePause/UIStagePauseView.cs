using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;

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
      visibleState = UIVisibleState.Hiding;

      RectTransform.anchoredPosition = hidePosition;
      canvasGroup.alpha = 0.0f;

      visibleState = UIVisibleState.Hidden;
      gameObject.SetActive(false);
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showing;

      var duration = isImmediately ? 0.0f : UISO.StageUIMoveDefaultDuration;
      await DOTween.Sequence()
        .Join(RectTransform.DOAnchorPos(showPosition, duration))
        .Join(canvasGroup.DOFade(1.0f, duration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);

      visibleState = UIVisibleState.Showing;
    }
  }
}