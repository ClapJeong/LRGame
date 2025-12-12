using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerRootView : BaseUIView
  {
    [Header("Input")]
    public UIPlayerInputView leftInputViewContainer;
    public UIPlayerInputView rightInputViewContainer;

    [Header("Energy")]
    public UIPlayerEnergyView leftEnergyView;
    public UIPlayerEnergyView rightEnergyView;

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