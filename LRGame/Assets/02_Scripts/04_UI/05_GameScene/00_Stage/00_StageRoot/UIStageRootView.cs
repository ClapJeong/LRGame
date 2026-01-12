using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStageRootView : BaseUIView
  {    
    [field: SerializeField] public UIStageBeginView BeginView { get; private set; }
    [field: SerializeField] public UIStageFailView FailView { get; private set; }
    [field: SerializeField] public UIStageSuccessView SuccessView { get; private set; }
    [field: SerializeField] public UIStagePauseView PauseView { get; private set; }
    [field: SerializeField] public UIRestartView RestartView { get; private set; }

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