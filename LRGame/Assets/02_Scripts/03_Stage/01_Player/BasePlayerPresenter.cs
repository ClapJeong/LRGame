using Cysharp.Threading.Tasks;
using UniRx;
using UniRx.Triggers;

namespace LR.Stage.Player
{
  public class BasePlayerPresenter : IPlayerPresenter
  {
    private readonly BasePlayerView view;
    private readonly PlayerModel model;

    private readonly BasePlayerMoveController moveController;
    private readonly BasePlayerReactionController reactionController;
    private readonly BasePlayerInputActionController inputActionController;
    private readonly PlayerStateController stateController;
    private readonly BasePlayerEnergyService energyService;

    private CompositeDisposable disposables = new();

    public BasePlayerPresenter(PlayerModel model, BasePlayerView view)
    {
      this.view = view;
      this.model = model;

      view.SetWorldPosition(model.beginPosition);

      energyService = new BasePlayerEnergyService(model.so.Energy, view).AddTo(disposables);
      inputActionController = new BasePlayerInputActionController(model).AddTo(disposables);
      moveController = new BasePlayerMoveController(view, inputActionController: this.inputActionController, model).AddTo(disposables);

      stateController = new PlayerStateController().AddTo(disposables);
      reactionController = new BasePlayerReactionController(
        moveController: this.moveController,
        stateController: this.stateController).AddTo(disposables);

      stateController.AddState(PlayerStateType.Idle, new PlayerIdleState(
        moveController: this.moveController, 
        inputActionController: this.inputActionController, 
        stateController: this.stateController,
        energyUpdater: this.energyService,
        reactionController: reactionController));
      stateController.AddState(PlayerStateType.Move, new PlayerMoveState(
        moveController: this.moveController, 
        inputActionController: this.inputActionController, 
        stateController: this.stateController,
        energyUpdater: this.energyService,
        reactionController: reactionController));
      var bounceData = GlobalManager.instance.Table.TriggerTileModelSO.SpikeTrigger.BounceData;
      stateController.AddState(PlayerStateType.Bounce, new PlayerBounceState(
        moveController: this.moveController, 
        inputActionController: this.inputActionController, 
        stateController: this.stateController,
        energyUpdater: this.energyService,
        bounceData));
      stateController.AddState(PlayerStateType.Charging, new PlayerChargingState(
        stateController: stateController,
        inputActionController: inputActionController,
        moveController: moveController,
        playerGetter: model.playerGetter,
        energyChargerData: GlobalManager.instance.Table.TriggerTileModelSO.EnergyCharger,
        playerType: this.model.playerType));

      stateController.ChangeState(PlayerStateType.Idle);

      SubscribeEnergyService();
      SubscribeObservable();
    }

    private void SubscribeEnergyService()
    {
      energyService.SubscribeEvent(IPlayerEnergyController.EventType.OnExhausted, () =>
      {
        inputActionController.EnableAllInputActions(false);
        switch (model.playerType)
        {
          case PlayerType.Left:
            model.stageResultHandler.LeftExhausted();
            break;

          case PlayerType.Right:
            model.stageResultHandler.RightExhaused();
            break;
        }
      });
      energyService.SubscribeEvent(IPlayerEnergyController.EventType.OnRevived, () =>
      {
        inputActionController.EnableAllInputActions(true);

        switch (model.playerType)
        {
          case PlayerType.Left:
            model.stageResultHandler.LeftRevived();
            break;

          case PlayerType.Right:
            model.stageResultHandler.RightRevived();
            break;
        }
      });
    }

    private void SubscribeObservable()
    {
      view
        .FixedUpdateAsObservable()
        .Subscribe(_ => stateController.FixedUpdate()).AddTo(disposables);
      view
        .OnDestroyAsObservable()
        .Subscribe(_ => disposables.Dispose());
    }

    #region IStageObjectController
    public void Enable(bool enable)
    {
      GetInputActionController().
        EnableAllInputActions(enable);
    }

    public void Restart()
    {
      GetInputActionController().
        EnableAllInputActions(true);

      energyService.Restart();        

      view.SetWorldPosition(model.beginPosition);
    }
    #endregion

    public IPlayerMoveController GetMoveController()
      => moveController;

    public IPlayerInputActionController GetInputActionController()
      => inputActionController;

    public IPlayerEnergyController GetEnergyController()
      => energyService;

    public IPlayerReactionController GetReactionController()
      => reactionController;

    public IPlayerEnergyUpdater GetEnergyUpdater()
      => energyService;

    public void Dispose()
    {
      disposables.Dispose();
    }
  }
}