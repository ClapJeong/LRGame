using LR.Stage.Player;
using LR.Stage.Player.Enum;

public interface IPlayerGetter
{
  public IPlayerPresenter GetPlayer(PlayerType playerType);

  public bool IsAllPlayerExist();
}