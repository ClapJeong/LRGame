using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerRootPresenter : IUIPresenter
  {
    public class Model
    {

    }

    private readonly Model model;
    private readonly UIPlayerRootViewContainer viewContainer;

    private UIPlayerInputPresenter inputUIPresenter;

    public UIPlayerRootPresenter(Model model, UIPlayerRootViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      CreateInputUIPresenterAsync().Forget();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public void Dispose()
    {
      IUIPresenterContainer presenterContainer = GlobalManager.instance.UIManager;
      presenterContainer.Remove(this);
    }

    public UIVisibleState GetVisibleState()
    {
      throw new NotImplementedException();
    }

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    private async UniTask CreateInputUIPresenterAsync()
    {
      var model = new UIPlayerInputPresenter.Model();
      var leftView = viewContainer.leftViewContainer;
      var leftSubscriber = await LocalManager.instance.StageManager.GetPresenterAsync(PlayerType.Left);
      var rightView = viewContainer.rightViewContainer;
      var rightSubscriber = await LocalManager.instance.StageManager.GetPresenterAsync(PlayerType.Right);
      IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
      presenterFactory.Register(() => new UIPlayerInputPresenter(model, leftView, leftSubscriber, rightView, rightSubscriber));
      inputUIPresenter = presenterFactory.Create<UIPlayerInputPresenter>();
      inputUIPresenter.AttachOnDestroy(viewContainer.gameObject);
    }
  }
}