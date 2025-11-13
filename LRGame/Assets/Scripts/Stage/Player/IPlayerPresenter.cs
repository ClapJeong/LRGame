using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public interface IMoveController
{
  public void CreateMoveInputAction(Dictionary<string,Direction> pathDirectionPairs);

  public void CreateMoveInputAction(string path, Direction direction);

  public void EnableInputAction(Direction direction, bool enable);

  public void EnableAllInputActions(bool enable);
}

public interface IPlayerPresenter: IMoveController, IGameObjectController, IPositionController, IStageObjectEnabler
{
  public void Initialize(IPlayerView view, PlayerModel model);
}
