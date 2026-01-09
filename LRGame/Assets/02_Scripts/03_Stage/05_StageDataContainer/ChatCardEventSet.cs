namespace LR.Stage.StageDataContainer
{
  [System.Serializable]
  public class ChatCardEventSet
  {
    public ChatCardEnum.ID id;
    public ChatCardEnum.EventType eventType;
    public bool playOnce = true;
    public float delay = 0.0f;

    public StageEventData stageEventData = new(); 
    public PlayerEventData playerEventData = new();    
    public SignalEventData signalEventData = new();
    public TriggerTileEventData triggerTileEventData = new();
  }
}
