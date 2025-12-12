using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UnityEngine;
using LR.Stage.Player;

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
    private UIPlayerEnergyPresenter leftEnergyPresenter;

    private UIPlayerInputPresenter rightInputActionPresenter;
    private UIPlayerEnergyPresenter rightEnergyPresenter;

    public UIPlayerRootPresenter(Model model, UIPlayerRootView view)
    {
      this.model = model;
      this.view = view;

      UniTask.WhenAll(
        CreateLeftInputPresenterAsync(),
        CreateLeftEnergyPresenterAsync(),
        CreateRightInputPresenterAsync(),
        CreateRightEnergyPresenterAsync())
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
      await leftEnergyPresenter.DeactivateAsync(isImmediately, token);

      await rightInputActionPresenter.DeactivateAsync(isImmediately, token);
      await rightEnergyPresenter.DeactivateAsync(isImmediately, token);
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      if (isAllPresentersCreated == false)
        await UniTask.WaitUntil(() => isAllPresentersCreated);

      await leftInputActionPresenter.ActivateAsync(isImmediately, token);
      await leftEnergyPresenter.ActivateAsync(isImmediately, token);

      await rightInputActionPresenter.ActivateAsync(isImmediately, token);
      await rightEnergyPresenter.ActivateAsync(isImmediately, token);
    }

    private async UniTask CreateLeftInputPresenterAsync()
    {
      IPlayerPresenter leftPlayerPresenter = await LocalManager.instance.StageManager.GetPresenterAsync(PlayerType.Left);

      var model = new UIPlayerInputPresenter.Model(leftPlayerPresenter.GetInputActionController());
      var view = this.view.leftInputViewContainer;

      leftInputActionPresenter = new UIPlayerInputPresenter(model, view);
      leftInputActionPresenter.AttachOnDestroy(view.gameObject);
    }

    private async UniTask CreateRightInputPresenterAsync()
    {
      IPlayerPresenter leftPlayerPresenter = await LocalManager.instance.StageManager.GetPresenterAsync(PlayerType.Right);

      var model = new UIPlayerInputPresenter.Model(leftPlayerPresenter.GetInputActionController());
      var view = this.view.rightInputViewContainer;

      rightInputActionPresenter = new UIPlayerInputPresenter(model, view);
      rightInputActionPresenter.AttachOnDestroy(view.gameObject);
    }

    private async UniTask CreateLeftEnergyPresenterAsync()
    {
      var leftPlayerTable = GlobalManager.instance.Table.LeftPlayerModelSO;
      IPlayerPresenter leftPresenter = await this.model.stageManager.GetPresenterAsync(PlayerType.Left);

      var model = new UIPlayerEnergyPresenter.Model(
        playerEnergyController: leftPresenter.GetEnergyController(),
        leftPlayerTable.Energy);
      var view = this.view.leftEnergyView;

      leftEnergyPresenter = new UIPlayerEnergyPresenter(model, view);
      leftEnergyPresenter.AttachOnDestroy(view.gameObject);
    }

    private async UniTask CreateRightEnergyPresenterAsync()
    {
      var RightPlayerTable = GlobalManager.instance.Table.RightPlayerModelSO;
      IPlayerPresenter RightPresenter = await this.model.stageManager.GetPresenterAsync(PlayerType.Right);

      var model = new UIPlayerEnergyPresenter.Model(
        playerEnergyController: RightPresenter.GetEnergyController(),
        RightPlayerTable.Energy);
      var view = this.view.rightEnergyView;

      rightEnergyPresenter = new UIPlayerEnergyPresenter(model, view);
      rightEnergyPresenter.AttachOnDestroy(view.gameObject);
    }
  }
}