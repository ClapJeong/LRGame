using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerInputView : BaseUIView
  {
    [field: SerializeField] public Animator UpAnimator { get; private set; }
    [field: SerializeField] public Animator RightAnimator { get; private set; }
    [field: SerializeField] public Animator DownAnimator { get; private set; }
    [field: SerializeField] public Animator LeftAnimator { get; private set; }    

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