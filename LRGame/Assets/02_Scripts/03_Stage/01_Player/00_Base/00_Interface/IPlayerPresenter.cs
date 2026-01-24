namespace LR.Stage.Player
{
  public interface IPlayerPresenter: IStageObjectController
  {
    public IPlayerMoveController GetMoveController();

    public IPlayerInputActionController GetInputActionController();

    public IPlayerReactionController GetReactionController();

    public IPlayerEnergyUpdater GetEnergyUpdater();

    public IPlayerEnergySubscriber GetEnergySubscriber();

    public IPlayerEnergyProvider GetEnergyProvider();

    public IPlayerStateProvider GetStateProvider();

    public IPlayerStateSubscriber GetStateSubscriber();

    public IPlayerAnimatorController GetAnimatorController();
  }
}