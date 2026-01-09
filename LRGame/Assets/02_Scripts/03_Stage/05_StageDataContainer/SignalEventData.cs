namespace LR.Stage.StageDataContainer
{
  [System.Serializable]
  public class SignalEventData: EventDataBase
  {
    public string targetKey;
    public ChatCardEnum.SignalEventType signalEventType;
  }
}
