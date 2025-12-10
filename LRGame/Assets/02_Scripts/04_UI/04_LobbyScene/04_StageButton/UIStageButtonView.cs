using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIStageButtonView : BaseUIView
  {
    public BaseProgressSubmitView progressSubmitView;
    public BaseImageView backGroundImageView;
    public BaseImageView fillImageView;
    public BaseTMPView tmpView;
    public BaseRectView rectView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      backGroundImageView.SetAlpha(0.4f);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      backGroundImageView.SetAlpha(1.0f);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}