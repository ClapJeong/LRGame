using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

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

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
      => throw new System.NotImplementedException();

    public UIVisibleState GetVisibleState()
      => UIVisibleState.Showed;

    public void Dispose()
    {
      IUIPresenterContainer presenterContainer = GlobalManager.instance.UIManager;
      presenterContainer.Remove(this);
      if (view)
        GameObject.Destroy(view.gameObject);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target
      .OnDestroyAsObservable()
      .Subscribe(_ => Dispose());
  }
}