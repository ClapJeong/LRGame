using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage.PausePanel
{
  public class BaseButtonView : BaseUIView
  {
    [Header("[ Base ]")]
    public BaseRectView baseRectView;

    [Header("[ Min ]")]
    public BaseProgressSubmitView minProgressSubmitView;
    public BaseImageView minImageView;

    [Header("[ Max ]")]
    public BaseProgressSubmitView maxProgressSubmitView;
    public BaseImageView maxImageView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      minProgressSubmitView.Enable(false);
      maxProgressSubmitView.Enable(false);
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      minProgressSubmitView.Enable(true);
      maxProgressSubmitView.Enable(true);
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}