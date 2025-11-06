using UnityEngine;

public interface ITriggerTileView: ITriggerEventSubscriber, ITriggerTileEnabler
{
  public TriggerTileType GetTriggerType();
}
