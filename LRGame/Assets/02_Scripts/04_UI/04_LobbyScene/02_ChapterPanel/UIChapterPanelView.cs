using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIChapterPanelView : BaseUIView
  {
    [Header("[ Base ]")]
    public Transform indicatorRoot;

    [Header("[ StageButtons ]")]
    public UIStageButtonView upStageButtonView;
    public UIStageButtonView rightStageButtonView;
    public UIStageButtonView downStageButtonView;
    public UIStageButtonView leftStageButtonView;

    [Header("[ Quit ]")]
    public UIChapterPanelQuitButtonView quitButtonView;

    public override UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
      return UniTask.CompletedTask;
    }

    public override UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showen;
      return UniTask.CompletedTask;
    }
  }
}