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
      public PlayerType playerType;
      public IPlayerGetter playerGetter;

      public Model(StageManager stageManager, PlayerType playerType, IPlayerGetter playerGetter)
      {
        this.stageManager = stageManager;
        this.playerType = playerType;
        this.playerGetter = playerGetter;
      }

      public IPlayerPresenter GetPlayer()
        => playerGetter.GetPlayer(playerType);
    }

    private readonly Model model;
    private readonly UIPlayerRootView view;

    private bool isAllPresentersCreated = false;

    private UIPlayerInputPresenter inputActionPresenter;
    private UIPlayerEnergyPresenter energyPresenter;
    private UIPlayerChargingPresenter chargingPresenter;

    public UIPlayerRootPresenter(Model model, UIPlayerRootView view)
    {
      this.model = model;
      this.view = view;

      UniTask.WhenAll(
        CreateLeftInputPresenterAsync(),
        CreateRightEnergyPresenterAsync(),
        CreateChargingPresenterAsync())
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

      await inputActionPresenter.DeactivateAsync(isImmediately, token);
      await energyPresenter.DeactivateAsync(isImmediately, token);
      await chargingPresenter.DeactivateAsync(isImmediately, token);
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      if (isAllPresentersCreated == false)
        await UniTask.WaitUntil(() => isAllPresentersCreated);

      await inputActionPresenter.ActivateAsync(isImmediately, token);
      await energyPresenter.ActivateAsync(isImmediately, token);
      await chargingPresenter.ActivateAsync(isImmediately, token);
    }

    private async UniTask CreateLeftInputPresenterAsync()
    {
      await UniTask.WaitUntil(() => this.model.playerGetter.IsAllPlayerExist());

      var inputController = this.model.GetPlayer().GetInputActionController();

      var model = new UIPlayerInputPresenter.Model(inputController);
      var view = this.view.inputView;

      inputActionPresenter = new UIPlayerInputPresenter(model, view);
      inputActionPresenter.AttachOnDestroy(view.gameObject);
    }

    private async UniTask CreateRightEnergyPresenterAsync()
    {
      await UniTask.WaitUntil(() => this.model.playerGetter.IsAllPlayerExist());

      var playerTable = GlobalManager.instance.Table.GetPlayerModelSO(this.model.playerType);
      var energyController = this.model.GetPlayer().GetEnergyController();

      var model = new UIPlayerEnergyPresenter.Model(
        playerEnergyController: energyController,
        playerTable.Energy);
      var view = this.view.energyView;

      energyPresenter = new UIPlayerEnergyPresenter(model, view);
      energyPresenter.AttachOnDestroy(view.gameObject);
    }

    private async UniTask CreateChargingPresenterAsync()
    {
      await UniTask.WaitUntil(() => this.model.playerGetter.IsAllPlayerExist());

      var stateProvider = this.model.GetPlayer().GetPlayerStateProvider();
      var stateSubscriber = this.model.GetPlayer().GetPlayerStateSubscriber();

      var model = new UIPlayerChargingPresenter.Model(
        stateProvider,
        stateSubscriber);
      var view = this.view.chargingView;
     
      chargingPresenter = new UIPlayerChargingPresenter(model, view);
      chargingPresenter.AttachOnDestroy(view.gameObject);
    }
  }
}