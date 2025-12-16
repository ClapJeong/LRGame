namespace LR.Stage.Player
{
  public interface IPlayerPresenter: IStageObjectController
  {
    public IPlayerMoveController GetMoveController();

    public IPlayerInputActionController GetInputActionController();

    public IPlayerEnergyController GetEnergyController();

    public IPlayerReactionController GetReactionController();

    public IPlayerEnergyUpdater GetEnergyUpdater();

    public IPlayerEnergySubscriber GetEnergySubscriber();

    public IPlayerEnergyProvider GetEnergyProvider();

    public IPlayerStateProvider GetPlayerStateProvider();

    public IPlayerStateSubscriber GetPlayerStateSubscriber();
  }
}