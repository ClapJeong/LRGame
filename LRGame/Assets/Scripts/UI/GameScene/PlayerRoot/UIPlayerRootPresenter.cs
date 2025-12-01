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

    private UIPlayerInputPresenter inputPresenter;
    private UIPlayerHPPresenter hpPresenter;

    public UIPlayerRootPresenter(Model model, UIPlayerRootViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      CreateInputPresenterAsync().Forget();
      CreateHPPresenterAsync().Forget();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public void Dispose()
    {
      IUIPresenterContainer presenterContainer = GlobalManager.instance.UIManager;
      presenterContainer.Remove(this);
      if (viewContainer)
        GameObject.Destroy(viewContainer.gameObject);
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

    private async UniTask CreateInputPresenterAsync()
    {
      var model = new UIPlayerInputPresenter.Model();

      var leftView = viewContainer.leftInputViewContainer;
      IPlayerPresenter leftPresenter = await LocalManager.instance.StageManager.GetPresenterAsync(PlayerType.Left);

      var rightView = viewContainer.rightInputViewContainer;
      IPlayerPresenter rightPresenter = await LocalManager.instance.StageManager.GetPresenterAsync(PlayerType.Right);

      inputPresenter = new UIPlayerInputPresenter(
        model,
        leftView,
        leftInputController: leftPresenter,
        rightView,
        rightInputController: rightPresenter);
      inputPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private async UniTask CreateHPPresenterAsync()
    {
      var table = GlobalManager.instance.Table;

      var model = new UIPlayerHPPresenter.Model(table.LeftPlayerModelSO.HP.MaxHP,table.RightPlayerModelSO.HP.MaxHP);

      var leftView = viewContainer.leftHPViewContainer;
      IPlayerPresenter leftPresenter = await LocalManager.instance.StageManager.GetPresenterAsync(PlayerType.Left);

      var rightView = viewContainer.rightHPViewContainer;
      IPlayerPresenter rightPresenter = await LocalManager.instance.StageManager.GetPresenterAsync(PlayerType.Right);

      hpPresenter = new UIPlayerHPPresenter(
        model,
        leftView,
        leftHPController: leftPresenter,
        rightView,
        rightHPController: rightPresenter);
      hpPresenter.AttachOnDestroy(viewContainer.gameObject);
    }
  }
}