using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.GameScene.Stage
{
  public class UIStageFailView : BaseUIView
  {
    [SerializeField] private Vector2 hidePosition;
    [SerializeField] private Vector2 showPosition;
    [SerializeField] private CanvasGroup canvasGroup;

    [field: SerializeField] public Transform IndicatorRoot { get; private set; }
    [field: SerializeField] public UIProgressSubmitViewFillSet RestartProgressSubmitSet { get; private set; }
    [field: SerializeField] public UIProgressSubmitViewFillSet QuitProgressSubmitSet { get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Hiding;

      var duration = isImmediately ? 0.0f : UISO.StageUIMoveDefaultDuration;
      await DOTween.Sequence()
        .Join(RectTransform.DOAnchorPos(hidePosition, duration))
        .Join(canvasGroup.DOFade(0.0f, duration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);
      
      visibleState = VisibleState.Hidden;
      gameObject.SetActive(false);
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = VisibleState.Showing;

      var duration = isImmediately ? 0.0f : UISO.StageUIMoveDefaultDuration;
      await DOTween.Sequence()
        .Join(RectTransform.DOAnchorPos(showPosition, duration))
        .Join(canvasGroup.DOFade(1.0f, duration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);

      visibleState = VisibleState.Showen;
    }
  }
}