using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;

namespace LR.UI.GameScene.Stage
{
  public class UIStageBeginView : BaseUIView
  {
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private RectTransform readyLabel;
    [SerializeField] private Vector2 labelHidePosition;

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
      visibleState = VisibleState.Hiding;

      var duration = isImmediately ? 0.0f : UISO.BeginHideDuration;
      await DOTween.Sequence()
        .Join(leftContainer.DOAnchorPos(-hideLength * Vector2.right, duration))
        .Join(rightContainer.DOAnchorPos(hideLength * Vector2.right, duration))
        .Join(canvasGroup.DOFade(0.0f, duration))
        .Join(readyLabel.DOAnchorPos(labelHidePosition, duration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);
      gameObject.SetActive(false);

      visibleState = VisibleState.Hidden;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = VisibleState.Showing;

      LeftReadyImage.SetAlpha(0.4f);
      RightReadyImage.SetAlpha(0.4f);

      var duration = isImmediately ? 0.0f : UISO.BeginHideDuration;
      await DOTween.Sequence()
        .Join(leftContainer.DOAnchorPos(Vector2.zero, duration))
        .Join(rightContainer.DOAnchorPos(Vector2.zero, duration))
        .Join(canvasGroup.DOFade(1.0f, duration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);

      visibleState = VisibleState.Showen;
    }
  }
}