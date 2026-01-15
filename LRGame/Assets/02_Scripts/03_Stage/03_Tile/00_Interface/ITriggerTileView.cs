using LR.Stage.TriggerTile.Enum;

namespace LR.Stage.TriggerTile
{
  public interface ITriggerTileView : ITriggerEventSubscriber
  {
    public TriggerTileType GetTriggerType();
  }
}