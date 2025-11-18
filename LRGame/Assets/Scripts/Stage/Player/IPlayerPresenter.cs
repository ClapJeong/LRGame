using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public interface IPlayerMoveController
{
  public void CreateMoveInputAction(Dictionary<string,Direction> pathDirectionPairs);

  public void CreateMoveInputAction(string path, Direction direction);

  public void EnableInputAction(Direction direction, bool enable);

  public void EnableAllInputActions(bool enable);
}

public interface IPlayerMoveSubscriber
{
  public void SubscribeOnPerformed(UnityAction<Direction> performed);

  public void SubscribeOnCanceled(UnityAction<Direction> canceled);

  public void UnsubscribePerfoemd(UnityAction<Direction> perfoemd);

  public void UnsubscribeCanceled(UnityAction<Direction> canceled);
}

public interface IPlayerPresenter: IPlayerMoveController, IPlayerMoveSubscriber, IStageObjectController
{
  public void Initialize(IPlayerView view, PlayerModel model);
}
