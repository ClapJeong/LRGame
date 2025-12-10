using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStageRootView : BaseUIView
  {    
    [Header("[ Else ]")]
    public UIStageBeginView beginViewContainer;
    public UIStageFailView failViewContainer;
    public UIStageSuccessView successViewContainer;
    public UIStagePauseView pauseViewContainer;

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