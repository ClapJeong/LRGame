using System;
using System.Collections.Generic;
using UnityEngine.Events;

public interface IPlayerInputActionController: IDisposable
{
  public void CreateMoveInputAction(Dictionary<string, Direction> pathDirectionPairs);

  public void CreateMoveInputAction(string path, Direction direction);

  public void EnableInputAction(Direction direction, bool enable);

  public void EnableAllInputActions(bool enable);

  public void SubscribeOnPerformed(UnityAction<Direction> performed);

  public void SubscribeOnCanceled(UnityAction<Direction> canceled);

  public void UnsubscribePerfoemd(UnityAction<Direction> performed);

  public void UnsubscribeCanceled(UnityAction<Direction> canceled);

  public bool IsAnyInput();
}