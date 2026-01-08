
public static class ChatCardEnum
{
  public enum ID
  {
    LeftTest,
    CenterTest,
    RightTest,
    LeftTest2,
    CenterTest2,
    RightTest2,
  }

  public enum PortraitType
  {
    None,
    LeftTest,
    CenterTest,
    RightTest,
    LeftTest2,
    CenterTest2,
    RightTest2,
  }

  public enum EventType
  {
    Stage,
    Player,
    Trigger,
    Signal,
  }

  public enum StageEventType
  {
    OnAfterBeginTime,
    OnFail,
    OnComplete,
    OnRestart,
  }

  public enum PlayerEventType
  {
    OnEnergyChanged,
    OnStateChanged,
  }

  public enum TriggerEventType
  {
    OnEnter,
    OnExit,
  }

  public enum SignalEventType
  {
    OnActivate,
    OnDeactivate,
  }
}
