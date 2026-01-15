using LR.Stage.Player.Enum;
using LR.Stage.TriggerTile.Enum;

namespace LR.Stage.StageDataContainer
{
  [System.Serializable]
  public class TriggerTileEventData
  {
    public TriggerTileType targetTriggerTileType;
    public PlayerType targetPlayerType;
    public ChatCardEnum.TriggerEventType triggerEventType;
  }
}
