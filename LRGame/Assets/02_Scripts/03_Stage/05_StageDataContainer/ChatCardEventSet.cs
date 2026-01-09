namespace LR.Stage.StageDataContainer
{
  [System.Serializable]
  public class ChatCardEventSet : StageEventData
  {
    public ChatCardEnum.ID id;
    public ChatCardEnum.EventType eventType;

    public PlayerEventData playerEventData = new();
    public StageEventData stageEventData = new();
    public SignalEventData signalEventData = new();
    public TriggerTileEventData triggerTileEventData = new();
  }
}
