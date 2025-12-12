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

    public BasePlayerPresenter(PlayerType playerType, BasePlayerView view, PlayerModel model)
    {
      this.view = view;
      this.model = model;

      view.SetWorldPosition(model.beginPosition);

      energyService = new BasePlayerEnergyService(model.so.Energy).AddTo(disposables);
      inputActionController = new BasePlayerInputActionController(model).AddTo(disposables);
      moveController = new BasePlayerMoveController(
        view, 
        inputActionController: this.inputActionController, 
        model).AddTo(disposables);
      reactionController = new BasePlayerReactionController(
        moveController: this.moveController, 
        stateController: this.stateController).AddTo(disposables);

      stateController = new PlayerStateController();
      disposables.Add(stateController);
      stateController.AddState(PlayerStateType.Idle, new PlayerIdleState(
        moveController: this.moveController, 
        inputActionController: this.inputActionController, 
        stateController: this.stateController,
        energyUpdater: this.energyService));
      stateController.AddState(PlayerStateType.Move, new PlayerMoveState(
        moveController: this.moveController, 
        inputActionController: this.inputActionController, 
        stateController: this.stateController,
        energyUpdater: this.energyService));
      var bounceData = GlobalManager.instance.Table.TriggerTileModelSO.SpikeTrigger.BounceData;
      stateController.AddState(PlayerStateType.Bounce, new PlayerBounceState(
        moveController: this.moveController, 
        inputActionController: this.inputActionController, 
        stateController: this.stateController,
        energyUpdater: this.energyService,
        bounceData));

      stateController.ChangeState(PlayerStateType.Idle);

      SubscribeObservable();
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

    public void Dispose()
    {
      disposables.Dispose();
    }
  }
}