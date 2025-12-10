using Cysharp.Threading.Tasks;
using LR.UI.GameScene.Stage.SuccessPanel;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStageSuccessView : BaseUIView
  {
    [Header("[ Base ]")]
    public Transform indicatorRoot;

    [Header("[ Quit ]")]
    public BaseButtonView quitView;

    [Header("[ Restart ]")]
    public CenterButtonView restartView;

    [Header("[ Next ]")]
    public BaseButtonView nextView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}