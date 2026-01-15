using Cysharp.Threading.Tasks;
using DG.Tweening;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;
using LR.UI.Enum;

namespace LR.UI.GameScene.ChatCard
{
  public class UIChatCardView : BaseUIView
  {
    [field: SerializeField] public CanvasGroup CanvasGroup {  get; private set; }
    [field: SerializeField] public Image PortraitImage { get; private set; }
    [field: SerializeField] public LocalizeStringEvent LocalizeStringEvent { get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {      
      visibleState = VisibleState.Hiding;
      try
      {
        await CanvasGroup.DOFade(0.0f, isImmediately ? 0.0f : UISO.ChatCardHideDuration).ToUniTask(TweenCancelBehaviour.Kill, token);
        visibleState = VisibleState.Hidden;
        gameObject.SetActive(false);
      }
      catch (OperationCanceledException) { }
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = VisibleState.Showing;
      await CanvasGroup.DOFade(1.0f, isImmediately ? 0.0f : UISO.ChatCardShowDuration).ToUniTask(TweenCancelBehaviour.Kill, token);
      visibleState = VisibleState.Showen;      
    }
  }
}
