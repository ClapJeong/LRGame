using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.GameScene.InputProgress
{
  public class UIRightEnergyItemView : BaseUIView
  {
    [field: SerializeField] public Image fillImage { get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hiding;
      await UniTask.CompletedTask;
      visibleState = UIVisibleState.Showen;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hiding;
      await UniTask.CompletedTask;
      visibleState = UIVisibleState.Showen;
    }
  }
}
