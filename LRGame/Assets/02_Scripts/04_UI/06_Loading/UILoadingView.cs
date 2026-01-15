using Cysharp.Threading.Tasks;
using DG.Tweening;
using System;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.Loading
{
  public class UILoadingView : BaseUIView
  {
    [SerializeField] private CanvasGroup canvasGroup;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Hiding;
      try
      {
        await canvasGroup.DOFade(0.0f, isImmediately ? 0.0f : UISO.LoadingFaceDuraton).ToUniTask(TweenCancelBehaviour.Kill, token);
      }
      catch (OperationCanceledException) 
      {
        canvasGroup.alpha = 0.0f;
      }
      visibleState = VisibleState.Hidden;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Showing;
      try
      {
        await canvasGroup.DOFade(1.0f, isImmediately ? 0.0f : UISO.LoadingFaceDuraton).ToUniTask(TweenCancelBehaviour.Kill, token);
      }
      catch (OperationCanceledException)
      {
        canvasGroup.alpha = 1.0f;
      }
      visibleState = VisibleState.Showen;
    }
  }
}
