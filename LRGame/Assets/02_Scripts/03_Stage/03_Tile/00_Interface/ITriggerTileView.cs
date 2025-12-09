using UnityEngine;

public interface ITriggerTileView: ITriggerEventSubscriber
{
  public TriggerTileType GetTriggerType();
}
