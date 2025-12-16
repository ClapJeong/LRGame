using Cysharp.Threading.Tasks;
using System.Threading;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerChargingView : BaseUIView
  {
    public BaseImageView imageView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      imageView.SetEnable(false);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      imageView.SetEnable(true);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}