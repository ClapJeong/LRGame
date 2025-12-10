using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage.PausePanel
{
  public class ResumeButtonView : BaseUIView
  {
    public BaseProgressSubmitView progressSubmitView;
    public BaseScaleView fillScaleView;
    public BaseRectView rectView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      progressSubmitView.Enable(false);
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      progressSubmitView.Enable(true);
      gameObject.SetActive(true);
      fillScaleView.SetLocalScale(Vector3.zero);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}