using Cysharp.Threading.Tasks;
using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class UIPreloadingPresenter : IUIPresenter
{
  public class Model
  {
    public readonly string loadingText;

    public Model(string loadingText)
    {
      this.loadingText = loadingText;
    }
  }

  private readonly Model model;
  private readonly UIPreloadingView view;
  private readonly ITMPController loadingTextController;

  public UIPreloadingPresenter(Model model, UIPreloadingView view)
  {
    this.model = model;
    this.view = view;
    this.loadingTextController = view;

    loadingTextController.SetText(model.loadingText);
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
    GameObject.Destroy(view.gameObject);
  }

  public IDisposable AttachOnDestroy(GameObject target)
    => target
    .OnDestroyAsObservable()
    .Subscribe(_=>Dispose());
}
