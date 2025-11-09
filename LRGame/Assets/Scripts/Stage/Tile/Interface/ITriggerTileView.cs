using UnityEngine;

public interface ITriggerTileView: ITriggerEventSubscriber, IStageObjectEnabler
{
  public TriggerTileType GetTriggerType();
}
