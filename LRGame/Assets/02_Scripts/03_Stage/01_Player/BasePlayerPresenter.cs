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
    private readonly PlayerStateService stateService;
    private readonly BasePlayerEnergyService energyService;

    private CompositeDisposable disposables = new();

    public BasePlayerPresenter(PlayerModel model, BasePlayerView view)
    {
      this.view = view;
      this.model = model;

      view.transform.position = model.beginPosition;

      energyService = new BasePlayerEnergyService(model.so.Energy, view.SpriteRenderer).AddTo(disposables);
      inputActionController = new BasePlayerInputActionController(model).AddTo(disposables);
      moveController = new BasePlayerMoveController(view, inputActionController: this.inputActionController, model).AddTo(disposables);

      stateService = new PlayerStateService().AddTo(disposables);
      reactionController = new BasePlayerReactionController(
        moveController: this.moveController,
        stateController: this.stateService).AddTo(disposables);

      stateService.AddState(PlayerStateType.Idle, new PlayerIdleState(
        moveController: this.moveController, 
        inputActionController: this.inputActionController, 
        stateController: this.stateService,
        energyUpdater: this.energyService,
        reactionController: reactionController));
      stateService.AddState(PlayerStateType.Move, new PlayerMoveState(
        moveController: this.moveController, 
        inputActionController: this.inputActionController, 
        stateController: this.stateService,
        energyUpdater: this.energyService,
        reactionController: reactionController));
      var bounceData = GlobalManager.instance.Table.TriggerTileModelSO.SpikeTrigger.BounceData;
      stateService.AddState(PlayerStateType.Bounce, new PlayerBounceState(
        moveController: this.moveController, 
        inputActionController: this.inputActionController, 
        stateController: this.stateService,
        energyUpdater: this.energyService,
        bounceData));
      stateService.AddState(PlayerStateType.ChargingIdle, new PlayerChargingIdleState(
        moveController: this.moveController,
        inputActionController: this.inputActionController,
        stateController: this.stateService,
        reactionController: this.reactionController));
      stateService.AddState(PlayerStateType.ChargingMove, new PlayerChargingMoveState(
        stateController: stateService,
        inputActionController: inputActionController,
        moveController: moveController,
        reactionController: reactionController,
        playerGetter: model.playerGetter,
        energyChargerData: GlobalManager.instance.Table.TriggerTileModelSO.EnergyCharger,
        playerType: this.model.playerType));

      stateService.ChangeState(PlayerStateType.Idle);

      SubscribeEnergyService();
      SubscribeObservable();
    }

    private void SubscribeEnergyService()
    {
      energyService.SubscribeEvent(IPlayerEnergySubscriber.EventType.OnExhausted, () =>
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
      energyService.SubscribeEvent(IPlayerEnergySubscriber.EventType.OnRevived, () =>
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
        .Subscribe(_ => stateService.FixedUpdate()).AddTo(disposables);
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

      view.transform.position = model.beginPosition;
      stateService.ChangeState(PlayerStateType.Idle);
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

    public IPlayerEnergySubscriber GetEnergySubscriber()
      => energyService;

    public IPlayerEnergyProvider GetEnergyProvider()
      => energyService;

    public IPlayerStateProvider GetPlayerStateProvider()
      => stateService;

    public IPlayerStateSubscriber GetPlayerStateSubscriber()
      => stateService;

    public void Dispose()
    {
      disposables.Dispose();
    }
  }
}