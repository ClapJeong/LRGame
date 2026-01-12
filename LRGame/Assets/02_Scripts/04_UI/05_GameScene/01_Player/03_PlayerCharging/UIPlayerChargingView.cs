using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerChargingView : BaseUIView
  {
    [SerializeField] private Image chargeImage;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      chargeImage.enabled = false;
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      chargeImage.enabled = true;
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}