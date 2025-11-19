using UnityEngine;
using UnityEngine.Events;

public interface IPlayerMoveSubscriber
{
  public void SubscribeOnPerformed(UnityAction<Direction> performed);

  public void SubscribeOnCanceled(UnityAction<Direction> canceled);

  public void UnsubscribePerfoemd(UnityAction<Direction> perfoemd);

  public void UnsubscribeCanceled(UnityAction<Direction> canceled);
}
