using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage.SuccessPanel
{
  public class BaseButtonView : BaseUIView
  {
    public BaseRectView rectView;
    public BaseImageView backgroundImageView;
    public BaseImageView fillImageView;
    public BaseProgressSubmitView progressSubmitView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      progressSubmitView.Enable(false);
      backgroundImageView.SetAlpha(0.4f);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      progressSubmitView.Enable(true);
      backgroundImageView.SetAlpha(1.0f);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}