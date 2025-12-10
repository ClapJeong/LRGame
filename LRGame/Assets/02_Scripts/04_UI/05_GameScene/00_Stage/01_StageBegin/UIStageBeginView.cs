using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStageBeginView : BaseUIView
  {
    public BaseImageView leftImageView;
    public BaseImageView rightImageView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      leftImageView.SetAlpha(0.4f);
      rightImageView.SetAlpha(0.4f);
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}