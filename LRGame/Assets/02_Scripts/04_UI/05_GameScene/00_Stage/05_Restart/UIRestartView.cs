using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;
using System;

namespace LR.UI.GameScene.Stage
{
  public class UIRestartView : BaseUIView
  {
    [SerializeField] private CanvasGroup canvasGroup;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Hiding;
      try
      {
        await DOTween.Sequence()
                .Join(canvasGroup.DOFade(0.0f, UISO.RestartUIFadeDuration))
                .ToUniTask(TweenCancelBehaviour.Kill, token);
        visibleState = VisibleState.Hidden;

        gameObject.SetActive(false);
      }
      catch (OperationCanceledException) { }
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);

      try
      {
        visibleState = VisibleState.Hiding;
        await DOTween.Sequence()
          .Join(canvasGroup.DOFade(1.0f, UISO.RestartUIFadeDuration))
          .ToUniTask(TweenCancelBehaviour.Kill, token);
        visibleState = VisibleState.Hidden;
      }
      catch (OperationCanceledException) { }      
    }
  }
}