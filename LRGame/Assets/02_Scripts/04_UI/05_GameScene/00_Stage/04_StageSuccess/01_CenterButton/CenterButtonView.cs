using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage.SuccessPanel
{
  public class CenterButtonView : BaseUIView
  {
    public BaseRectView rectView;
    public BaseImageView backgroundImageView;
    public BaseScaleView fillScaleView;
    public BaseProgressSubmitView progressSubmitView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      backgroundImageView.SetAlpha(0.4f);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      backgroundImageView.SetAlpha(1.0f);      
      fillScaleView.SetLocalScale(Vector3.zero);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}