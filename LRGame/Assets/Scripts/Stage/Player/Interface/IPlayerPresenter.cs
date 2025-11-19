using UnityEngine.Events;

public interface IPlayerPresenter: IPlayerMoveController, IPlayerMoveSubscriber, IStageObjectController
{
  public void Initialize(IPlayerView view, PlayerModel model);
}
