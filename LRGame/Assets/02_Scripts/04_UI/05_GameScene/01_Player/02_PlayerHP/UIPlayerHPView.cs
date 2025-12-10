using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerHPView : BaseUIView
  {
    public List<BaseGameObjectView> hpObjects;

    public override UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hidden;
      return UniTask.CompletedTask;
    }

    public override UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showen;
      return UniTask.CompletedTask;
    }
  }
}