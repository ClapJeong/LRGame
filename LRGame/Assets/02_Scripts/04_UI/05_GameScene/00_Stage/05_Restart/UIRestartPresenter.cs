using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.GameScene.Stage
{
  public class UIRestartPresenter : IUIPresenter
  {
    public class Model
    {
      public UISO uiSO;

      public Model(UISO uiSO)
      {
        this.uiSO = uiSO;
      }
    }

    private readonly Model model;
    private readonly UIRestartView view;

    public UIRestartPresenter(Model model, UIRestartView view)
    {
      this.model = model;
      this.view = view;
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.ShowAsync(isImmedieately, token);
      await UniTask.WaitForSeconds(isImmedieately ? 0.0f : model.uiSO.RestartDelay, false, PlayerLoopTiming.Update, token);
    }

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.HideAsync(isImmedieately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if (view)
        view.DestroySelf();
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();
  }
}