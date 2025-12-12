using Cysharp.Threading.Tasks;
using System.Threading;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerEnergyView : BaseUIView
  {
    public BaseImageView fillImageView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}