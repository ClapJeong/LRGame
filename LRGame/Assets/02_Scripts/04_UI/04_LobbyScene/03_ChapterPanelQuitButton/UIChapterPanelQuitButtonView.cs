using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIChapterPanelQuitButtonView : BaseUIView
  {
    public BaseProgressSubmitView quitProgressSubmitView;
    public BaseImageView backgroundImageView;
    public BaseImageView fillImageView;
    public BaseRectView rectView;

    public override UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      backgroundImageView.SetAlpha(0.4f);
      quitProgressSubmitView.Enable(false);
      visibleState = UIVisibleState.Hidden;
      return UniTask.CompletedTask;
    }

    public override UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      backgroundImageView.SetAlpha(1.0f);
      quitProgressSubmitView.Enable(true);
      visibleState = UIVisibleState.Showen;
      return UniTask.CompletedTask;
    }
  }
}