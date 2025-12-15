using LR.Stage.Player;

public interface IPlayerGetter
{
  public IPlayerPresenter GetPlayer(PlayerType playerType);

  public bool IsAllPlayerExist();
}