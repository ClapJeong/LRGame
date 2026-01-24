using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerStatePortraitView : BaseUIView
  {
    [field: SerializeField] public Image PortraitImage { get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = Enum.VisibleState.Hiding;
      await UniTask.CompletedTask;
      visibleState = Enum.VisibleState.Hidden;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = Enum.VisibleState.Showing;
      await UniTask.CompletedTask;
      visibleState = Enum.VisibleState.Showen;
    }
  }
}
