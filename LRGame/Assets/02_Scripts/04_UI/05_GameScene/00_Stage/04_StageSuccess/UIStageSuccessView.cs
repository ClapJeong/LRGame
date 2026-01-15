using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;

namespace LR.UI.GameScene.Stage
{
  public class UIStageSuccessView : BaseUIView
  {
    [SerializeField] private Vector2 hidePosition;
    [SerializeField] private Vector2 showPosition;
    [SerializeField] private CanvasGroup canvasGroup;

    [field: SerializeField] public RectTransform IndicatorRoot { get; private set; }
    [field: Space(5)]
    [field: SerializeField] public UIProgressSubmitViewFillSet NextProgressFillSubmit { get; private set; }
    [field: Space(5)]
    [field: SerializeField] public RectTransform RestartRect {  get; private set; }
    [field: SerializeField] public BaseProgressSubmitView RestartProgressSubmit { get; private set; }
    [field: SerializeField] public Image RestartFillImage { get; private set; }
    [field: SerializeField] public Selectable RestartSelectable { get; private set; }

    [field: Space(5)]
    [field: SerializeField] public BaseProgressSubmitView QuitProgressSubmit { get; private set; }
    [field: SerializeField] public Image QuitFillImage { get; private set; }
    [field: SerializeField] public Selectable QuitSelectable { get; private set; }

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

      visibleState = VisibleState.Showing;
    }
  }
}