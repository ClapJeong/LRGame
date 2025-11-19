using UnityEngine.Events;

public interface IPlayerPresenter: IPlayerMoveController, IPlayerMoveSubscriber, IStageObjectController, IPlayerHPController
{
  public void Initialize(IPlayerView view, PlayerModel model);
}
