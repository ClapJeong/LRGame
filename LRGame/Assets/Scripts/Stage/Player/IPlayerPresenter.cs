using UnityEngine;
using UnityEngine.InputSystem;

public interface IMoveController
{
  public void CreateMoveInputAction(string path, Direction direction);

  public void EnableInputAction(Direction direction, bool enable);

  public void EnableAllInputActions(bool enable);
}

public interface IPlayerPresenter: IMoveController, ITransformController
{
  public void Initialize(IPlayerView view, PlayerModel model);

  public void SetEnable(bool isEnable);
}
