using Cysharp.Threading.Tasks;
using System.Threading;
using LR.UI.Enum;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerRootView : BaseUIView
  {
    public UIPlayerInputView inputView;
    public UIPlayerEnergyView energyView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}