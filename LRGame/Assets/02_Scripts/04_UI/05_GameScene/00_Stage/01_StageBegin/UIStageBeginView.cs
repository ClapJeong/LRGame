using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.GameScene.Stage
{
  public class UIStageBeginView : BaseUIView
  {
    [SerializeField] private CanvasGroup canvasGroup;

    [field: SerializeField] private RectTransform leftContainer;
    [field: SerializeField] public Image LeftReadyImage { get; private set; }
    [field: SerializeField] public Image LeftInputImage {  get; private set; }

    [field: Space(5)]
    [field: SerializeField] private RectTransform rightContainer;
    [field: SerializeField] public Image RightReadyImage { get; private set; }
    [field: SerializeField] public Image RightInputImage { get; private set; }

    [SerializeField] private float hideLength;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hiding;

      var duration = isImmediately ? 0.0f : UISO.BeginHideDuration;
      await DOTween.Sequence()
        .Join(leftContainer.DOAnchorPos(-hideLength * Vector2.right, duration))
        .Join(rightContainer.DOAnchorPos(hideLength * Vector2.right, duration))
        .Join(canvasGroup.DOFade(0.0f, duration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);
      gameObject.SetActive(false);

      visibleState = UIVisibleState.Hidden;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showing;

      var duration = isImmediately ? 0.0f : UISO.BeginHideDuration;
      await DOTween.Sequence()
        .Join(leftContainer.DOAnchorPos(Vector2.zero, duration))
        .Join(rightContainer.DOAnchorPos(Vector2.zero, duration))
        .Join(canvasGroup.DOFade(1.0f, duration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);

      visibleState = UIVisibleState.Showen;
    }
  }
}