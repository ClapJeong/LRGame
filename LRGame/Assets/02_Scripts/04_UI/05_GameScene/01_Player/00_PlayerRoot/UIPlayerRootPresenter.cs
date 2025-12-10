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
      public StageManager stageManager;

      public Model(StageManager stageManager)
      {
        this.stageManager = stageManager;
      }
    }

    private readonly Model model;
    private readonly UIPlayerRootView view;

    private bool isAllPresentersCreated = false;

    private UIPlayerInputPresenter leftInputActionPresenter;
    private UIPlayerHPPresenter leftHPPresenter;

    private UIPlayerInputPresenter rightInputActionPresenter;
    private UIPlayerHPPresenter rightHPPresenter;

    public UIPlayerRootPresenter(Model model, UIPlayerRootView view)
    {
      this.model = model;
      this.view = view;

      UniTask.WhenAll(
        CreateLeftInputPresenterAsync(),
        CreateLeftHPPresenterAsync(),
        CreateRightInputPresenterAsync(),
        CreateRightHPPresenterAsync())
        .ContinueWith(() => isAllPresentersCreated = true)
        .Forget();
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

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      if (isAllPresentersCreated == false)
        await UniTask.WaitUntil(() => isAllPresentersCreated);

      await leftInputActionPresenter.DeactivateAsync(isImmediately, token);
      await leftHPPresenter.DeactivateAsync(isImmediately, token);

      await rightInputActionPresenter.DeactivateAsync(isImmediately, token);
      await rightHPPresenter.DeactivateAsync(isImmediately, token);
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      if (isAllPresentersCreated == false)
        await UniTask.WaitUntil(() => isAllPresentersCreated);

      await leftInputActionPresenter.ActivateAsync(isImmediately, token);
      await leftHPPresenter.ActivateAsync(isImmediately, token);

      await rightInputActionPresenter.ActivateAsync(isImmediately, token);
      await rightHPPresenter.ActivateAsync(isImmediately, token);
    }

    private async UniTask CreateLeftInputPresenterAsync()
    {
      IPlayerPresenter leftPlayerPresenter = await LocalManager.instance.StageManager.GetPresenterAsync(PlayerType.Left);

      var model = new UIPlayerInputPresenter.Model(leftPlayerPresenter);
      var view = this.view.leftInputViewContainer;

      leftInputActionPresenter = new UIPlayerInputPresenter(model, view);
      leftInputActionPresenter.AttachOnDestroy(view.gameObject);
    }

    private async UniTask CreateRightInputPresenterAsync()
    {
      IPlayerPresenter leftPlayerPresenter = await LocalManager.instance.StageManager.GetPresenterAsync(PlayerType.Right);

      var model = new UIPlayerInputPresenter.Model(leftPlayerPresenter);
      var view = this.view.rightInputViewContainer;

      rightInputActionPresenter = new UIPlayerInputPresenter(model, view);
      rightInputActionPresenter.AttachOnDestroy(view.gameObject);
    }

    private async UniTask CreateLeftHPPresenterAsync()
    {
      var leftPlayerTable = GlobalManager.instance.Table.LeftPlayerModelSO;
      IPlayerPresenter leftPresenter = await this.model.stageManager.GetPresenterAsync(PlayerType.Left);

      var model = new UIPlayerHPPresenter.Model(
        maxHP: leftPlayerTable.HP.MaxHP,
        stageService: this.model.stageManager,
        hpController: leftPresenter);
      var view = this.view.leftHPViewContainer;

      leftHPPresenter = new UIPlayerHPPresenter(model, view);
      leftHPPresenter.AttachOnDestroy(view.gameObject);
    }

    private async UniTask CreateRightHPPresenterAsync()
    {
      var rightPlayerTable = GlobalManager.instance.Table.RightPlayerModelSO;
      IPlayerPresenter rightPresenter = await this.model.stageManager.GetPresenterAsync(PlayerType.Right);

      var model = new UIPlayerHPPresenter.Model(
        maxHP: rightPlayerTable.HP.MaxHP,
        stageService: this.model.stageManager,
        hpController: rightPresenter);
      var view = this.view.rightHPViewContainer;

      rightHPPresenter = new UIPlayerHPPresenter(model, view);
      rightHPPresenter.AttachOnDestroy(view.gameObject);
    }
  }
}