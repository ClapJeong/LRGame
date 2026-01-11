using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStageFailView : BaseUIView
  {
    public RectTransform noneRectTransform;
    public Transform indicatorRoot;

    [Header("[ Quit ]")]
    public RectTransform quitRectRectTransform;
    public BaseProgressSubmitView quitProgressSubmitView;
    public BaseImageView quitBackgroundImageView;
    public BaseImageView quitFillImageView;

    [Header("[ Restart ]")]
    public RectTransform restartRectTransform;
    public BaseProgressSubmitView restartProgressSubmitView;
    public BaseImageView restartBackgroundImageView;
    public BaseImageView restartFillImageView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      quitProgressSubmitView.Enable(false);
      restartProgressSubmitView.Enable(false);
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      quitProgressSubmitView.Enable(true);
      restartProgressSubmitView.Enable(true);
      quitBackgroundImageView.SetAlpha(0.4f);
      restartBackgroundImageView.SetAlpha(0.4f);
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}