using Cysharp.Threading.Tasks;
using System;
using UnityEngine;
using System.Threading;
using DG.Tweening;
using UnityEngine.UI;

namespace LR.UI.Lobby
{
  public class UIStageButtonSetView : BaseUIView
  {
    [field: SerializeField] public Selectable Selectable { get; private set; }
    [field: Header("[ Stage Buttons ]")] 
    [field: SerializeField] public UIStageButtonView UpStageButtonView;
    [field: SerializeField] public UIStageButtonView RightStageButtonView;
    [field: SerializeField] public UIStageButtonView DownStageButtonView;
    [field: SerializeField] public UIStageButtonView LeftStageButtonView;    

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hiding;

      var duration = isImmediately ? 0.0f : UISO.StageButtonMoveDuration;
      await DOTween.Sequence()
        .Join(RectTransform.DOScale(UISO.StageButtonHideScale, duration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);
      
      visibleState = UIVisibleState.Hiding;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hiding;

      var duration = isImmediately ? 0.0f : UISO.StageButtonMoveDuration;
      await DOTween.Sequence()
        .Join(RectTransform.DOScale(UISO.StageButtonShowScale, duration))
        .ToUniTask(TweenCancelBehaviour.Kill, token);

      visibleState = UIVisibleState.Hiding;
    }
  }
}
