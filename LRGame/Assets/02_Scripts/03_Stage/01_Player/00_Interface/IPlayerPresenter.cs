namespace LR.Stage.Player
{
  public interface IPlayerPresenter: IStageObjectController
  {
    public IPlayerMoveController GetMoveController();

    public IPlayerInputActionController GetInputActionController();

    public IPlayerEnergyController GetEnergyController();

    public IPlayerReactionController GetReactionController();

    public IPlayerEnergyUpdater GetEnergyUpdater();
  }
}