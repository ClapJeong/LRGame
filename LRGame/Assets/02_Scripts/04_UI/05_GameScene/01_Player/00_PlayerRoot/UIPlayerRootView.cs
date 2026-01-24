using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerRootView : BaseUIView
  {
    [field: SerializeField] public UIPlayerInputView InputView { get; private set; }
    [field: SerializeField] public UIPlayerEnergyView EnergyView { get; private set; }
    [field: SerializeField] public UIPlayerScoreView ScoreView { get; private set; }
    [field: SerializeField] public UIPlayerStatePortraitView StatePortraitView { get; private set; }

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