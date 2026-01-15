using Cysharp.Threading.Tasks;
using DG.Tweening;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.Lobby
{
  public abstract class UIBaseLobbyPanelView : BaseUIView
  {
    [SerializeField] private Vector2 hideAnchoredPosition;
    [SerializeField] private Vector2 showAnchoredPosition;
    [SerializeField] private CanvasGroup canvasGroup;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Hiding;

      var duration = isImmediately ? 0.0f : UISO.LobbyPanelMoveDuration;
      await DOTween
        .Sequence()
        .Join(RectTransform.DOAnchorPos(hideAnchoredPosition, duration))
        .Join(canvasGroup.DOFade(0.0f, duration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);

      visibleState = VisibleState.Hidden;
      gameObject.SetActive(false);
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Showing;
      gameObject.SetActive(true);

      var duration = isImmediately ? 0.0f : UISO.LobbyPanelMoveDuration;
      await DOTween
        .Sequence()
        .Join(RectTransform.DOAnchorPos(showAnchoredPosition, duration))
        .Join(canvasGroup.DOFade(1.0f, duration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);

      visibleState = VisibleState.Showen;
    }
  }
}
