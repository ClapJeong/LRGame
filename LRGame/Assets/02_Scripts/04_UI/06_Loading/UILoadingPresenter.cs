using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;

namespace LR.UI.Loading
{
  public class UILoadingPresenter : IUIPresenter
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
    private readonly UILoadingView view;

    public UILoadingPresenter(Model model, UILoadingView view)
    {
      this.model = model;
      this.view = view;

      view.InjectUISO(model.uiSO);
      view.HideAsync(true).Forget();
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.ShowAsync(isImmedieately, token);
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

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();
  }
}