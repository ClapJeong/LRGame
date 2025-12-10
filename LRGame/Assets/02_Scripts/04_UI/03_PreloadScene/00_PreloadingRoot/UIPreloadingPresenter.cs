using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;

namespace LR.UI.Preloading
{
  public class UIPreloadingPresenter : IUIPresenter
  {
    public class Model
    {
    }

    private readonly Model model;
    private readonly UIPreloadingView view;

    public UIPreloadingPresenter(Model model, UIPreloadingView view)
    {
      this.model = model;
      this.view = view;
    }

    public UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    public void Dispose()
    {
      if (view)
        view.DestroySelf();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);
  }
}