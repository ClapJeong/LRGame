using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIChapterButtonView : BaseUIView
  {
    public BaseTMPView tmpView;
    public BaseProgressSubmitView progressSubmitView;
    public BaseImageView leftProgressImageView;
    public BaseImageView rightProgressImageView;
    public BaseNavigationView navigationView;
    public BaseRectView rectView;

    public override UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hidden;
      return UniTask.CompletedTask;
    }

    public override UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showen;
      return UniTask.CompletedTask;
    }
  }
}