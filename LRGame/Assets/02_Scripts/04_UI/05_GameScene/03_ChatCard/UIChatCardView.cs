using Cysharp.Threading.Tasks;
using DG.Tweening;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

namespace LR.UI.GameScene.ChatCard
{
  public class UIChatCardView : BaseUIView
  {
    [SerializeField] private CanvasGroup canvasGroup;
    [field: SerializeField] public Image PortraitImage { get; private set; }
    [field: SerializeField] public LocalizeStringEvent LocalizeStringEvent { get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {      
      visibleState = UIVisibleState.Hiding;
      await canvasGroup.DOFade(0.0f, isImmediately ? 0.0f : UISO.ChatCardHideDuration).ToUniTask(TweenCancelBehaviour.Kill, token);
      visibleState = UIVisibleState.Hidden;
      if(!token.IsCancellationRequested)
        gameObject.SetActive(false);
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showing;
      await canvasGroup.DOFade(1.0f, isImmediately ? 0.0f : UISO.ChatCardShowDuration).ToUniTask(TweenCancelBehaviour.Kill, token);
      visibleState = UIVisibleState.Showen;      
    }
  }
}
