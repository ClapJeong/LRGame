namespace LR.Stage.StageDataContainer
{
  [System.Serializable]
  public class TriggerTileEventData: EventDataBase
  {
    public TriggerTileType targetTriggerTileType;
    public ChatCardEnum.TriggerEventType triggerEventType;
  }
}
