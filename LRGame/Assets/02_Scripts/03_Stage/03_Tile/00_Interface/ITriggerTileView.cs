namespace LR.Stage.TriggerTile
{
  public interface ITriggerTileView : ITriggerEventSubscriber
  {
    public TriggerTileType GetTriggerType();
  }
}