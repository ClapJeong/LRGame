using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;
using System;

namespace LR.UI.Lobby
{
  public class UIMainPanelView : BaseUIView
  {
    [System.Serializable]
    public class ButtonSet
    {
      [field: SerializeField] public RectTransform RectTransform {  get; set; }
      [field: SerializeField] public BaseProgressSubmitView ProgressSubmit { get; private set; }
      [field: SerializeField] public Image FillImage { get; private set; }
    }
    [field: SerializeField] public ButtonSet OptionButtonSet { get; private set; }
    [field: SerializeField] public ButtonSet LocalizeButtonSet { get; private set; }
    [field: SerializeField] public ButtonSet StageButtonSet { get; private set; }

    [field: Space(5)]
    [field: SerializeField] public BaseProgressSubmitView QuitProgressSubmit { get; private set; }
    [field: SerializeField] public RectTransform QuitRect { get; private set; }
    [field: SerializeField] public RectTransform QuitRectFillImage {  get; private set; }

    [field: Header("[ Positions ]")]
    [field: SerializeField] public Vector2 IdlePosition {  get; private set; }
    [field: SerializeField] public Vector2 OptionPosition { get; private set; }
    [field: SerializeField] public Vector2 LocalizePosition { get; private set; }
    [field: SerializeField] public Vector2 StagePosition { get; private set; }

    [Space(5)]
    [SerializeField] private CanvasGroup canvasGroup;

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Showing;
      try
      {
        gameObject.SetActive(true);
        await DOTween
          .Sequence()
          .Join(canvasGroup.DOFade(1.0f, isImmediately ? 0.0f : UISO.LobbyPanelMoveDuration))
          .OnComplete(() =>
          {
            visibleState = VisibleState.Showen;
          })
          .ToUniTask(TweenCancelBehaviour.Kill, token);        
      }
      catch (OperationCanceledException) { }
    }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Hiding;            
      try
      {
        await DOTween
          .Sequence()
          .Join(canvasGroup.DOFade(0.0f, isImmediately ? 0.0f : UISO.LobbyPanelMoveDuration))
          .OnComplete(() =>
          {
            visibleState = VisibleState.Hidden;
            gameObject.SetActive(false);
          })
        .ToUniTask(TweenCancelBehaviour.Kill, token);
      }
      catch (OperationCanceledException) { }
    }
  }
}
