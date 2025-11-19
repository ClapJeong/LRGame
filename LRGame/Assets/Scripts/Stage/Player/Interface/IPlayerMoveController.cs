using System.Collections.Generic;
using UnityEngine;

public interface IPlayerMoveController
{
  public void CreateMoveInputAction(Dictionary<string, Direction> pathDirectionPairs);

  public void CreateMoveInputAction(string path, Direction direction);

  public void EnableInputAction(Direction direction, bool enable);

  public void EnableAllInputActions(bool enable);
}
