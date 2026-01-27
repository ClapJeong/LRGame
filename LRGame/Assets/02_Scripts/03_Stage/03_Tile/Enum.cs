namespace LR.Stage.TriggerTile.Enum
{
  public enum TriggerTileType
  {
    LeftClearTrigger,
    RightClearTrigger,
    Spike,
    DefaultSignal,
    InputSignal,
    DefaultEnergy,
    InputtingEnergy,
  }

  public enum SignalInput
  {
    QTE,
    Progress,
  }

  public enum SignalInputFail
  {
    Bounce,
    BounceAndStun,
  }

  public enum SignalLife
  {
    OnlyActivate,
    ActivateAndDeactivate,
  }
}
