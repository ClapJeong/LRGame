using Cysharp.Threading.Tasks;
using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

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

  public async UniTask HideAsync(bool isImmediately = false)
  {
    await UniTask.CompletedTask;
  }

  public async UniTask ShowAsync(bool isImmediately = false)
  {
    await UniTask.CompletedTask;
  }

  public void SetVisibleState(UIVisibleState visibleState)
    => throw new System.NotImplementedException();

  public UIVisibleState GetVisibleState()
    => UIVisibleState.Showed;

  public void Dispose()
  {
    IUIPresenterContainer presenterContainer = GlobalManager.instance.UIManager;
    presenterContainer.Remove(this);
    if(view)
      GameObject.Destroy(view.gameObject);
  }

  public IDisposable AttachOnDestroy(GameObject target)
    => target
    .OnDestroyAsObservable()
    .Subscribe(_=>Dispose());
}
