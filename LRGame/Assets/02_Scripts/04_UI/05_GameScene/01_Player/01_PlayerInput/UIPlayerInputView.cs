using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerInputView : BaseUIView
  {
    public BaseAnimatorView upAnimator;
    public BaseAnimatorView downAnimator;
    public BaseAnimatorView leftAnimator;
    public BaseAnimatorView rightAnimator;

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