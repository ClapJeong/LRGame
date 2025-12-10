using Cysharp.Threading.Tasks;
using LR.UI.GameScene.Stage.PausePanel;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStagePauseView : BaseUIView
  {
    [Header("[ Base ]")]
    public Transform IndicatorRoot;

    [Header("[ ResumeButton ]")]
    public ResumeButtonView resumeButtonViewContainer;

    [Header("[ RestartButton ]")]
    public BaseButtonView restartButtonViewContainer;

    [Header("[ QuitButton ]")]
    public BaseButtonView quitButtonViewContainer;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}