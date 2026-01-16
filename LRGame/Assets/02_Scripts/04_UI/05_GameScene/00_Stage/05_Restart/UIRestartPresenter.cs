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
      public IUIPresenterContainer presenterContainer;

      public Model(UISO uiSO, IUIPresenterContainer presenterContainer)
      {
        this.uiSO = uiSO;
        this.presenterContainer = presenterContainer;
      }
    }

    private readonly Model model;
    private readonly UIRestartView view;

    public UIRestartPresenter(Model model, UIRestartView view)
    {
      this.model = model;
      this.view = view;

      model.presenterContainer.Add(this);
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
      model.presenterContainer.Remove(this);
      if (view)
        view.DestroySelf();
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();
  }
}