using Cysharp.Threading.Tasks;
using UniRx;
using UniRx.Triggers;
using LR.Stage.Player.Enum;

namespace LR.Stage.Player
{
  public class BasePlayerPresenter : IPlayerPresenter
  {
    private readonly PlayerModel model;
    private readonly BasePlayerView view;

    private readonly PlayerAnimatorController animatorController;
    private readonly PlayerMoveController moveController;
    private readonly PlayerReactionController reactionController;
    private readonly PlayerInputActionController inputActionController;
    private readonly PlayerStateService stateService;
    private readonly PlayerEnergyService energyService;
    private readonly PlayerEffectController effectController;

    private CompositeDisposable disposables = new();

    public BasePlayerPresenter(PlayerModel model, BasePlayerView view)
    {
      this.view = view;
      this.model = model;

      view.transform.position = model.beginPosition;

      effectController = new(view.ParticleSet);
      animatorController = new(view.Animator);
      energyService = new PlayerEnergyService(model.so.Energy, view.SpriteRenderer).AddTo(disposables);
      inputActionController = new PlayerInputActionController(model.inputActionFactory).AddTo(disposables);
      moveController = new PlayerMoveController(view.Rigidbody2D, inputActionController: this.inputActionController, model).AddTo(disposables);

      stateService = new PlayerStateService().AddTo(disposables);

      reactionController = new PlayerReactionController(
        moveController,
        stateService).AddTo(disposables);

      stateService.AddState(PlayerState.Idle, new PlayerIdleState(
        moveController, 
        inputActionController, 
        stateService,
        energyService,
        reactionController,
        animatorController));
      stateService.AddState(PlayerState.Move, new PlayerMoveState(
        moveController, 
        inputActionController, 
        stateService,
        energyService,
        reactionController,
        animatorController,
        effectController));      
      stateService.AddState(PlayerState.Stun, new PlayerStunState(
        moveController,
        stateService,
        energyService,
        animatorController,
        inputActionController,
        effectController,
        model.so.Stun));
      stateService.AddState(PlayerState.Inputting, new PlayerInputState(
        moveController,
        stateService,
        reactionController,
        energyService ,
        animatorController,
        model.inputSequenceStopController,
        effectController));

      stateService.ChangeState(PlayerState.Idle);

      SubscribeEnergyService();
      SubscribeObservable();
    }

    private void SubscribeEnergyService()
    {
      energyService.SubscribeEvent(IPlayerEnergySubscriber.EventType.OnExhausted, () =>
      {
        inputActionController.EnableAllInputActions(false);
        model.inputSequenceStopController.Stop();
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
      stateService.ChangeState(PlayerState.Idle);
    }
    #endregion

    public IPlayerAnimatorController GetAnimatorController()
      => animatorController;

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

    public IPlayerStateProvider GetStateProvider()
      => stateService;

    public IPlayerStateSubscriber GetStateSubscriber()
      => stateService;

    public void Dispose()
    {
      disposables.Dispose();
    }
  }
}