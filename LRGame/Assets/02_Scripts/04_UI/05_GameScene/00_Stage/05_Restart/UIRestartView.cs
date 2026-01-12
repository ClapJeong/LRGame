using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIRestartView : BaseUIView
  {
    [SerializeField] private CanvasGroup canvasGroup;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hiding;
      await DOTween.Sequence()
        .Join(canvasGroup.DOFade(0.0f, UISO.RestartUIFadeDuration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);
      visibleState = UIVisibleState.Hidden;

      gameObject.SetActive(false);
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);

      visibleState = UIVisibleState.Hiding;
      await DOTween.Sequence()
        .Join(canvasGroup.DOFade(1.0f, UISO.RestartUIFadeDuration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);
      visibleState = UIVisibleState.Hidden;      
    }
  }
}