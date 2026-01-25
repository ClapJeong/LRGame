namespace LR.Stage.TriggerTile.Enum
{
  public enum TriggerTileType
  {
    LeftClearTrigger,
    RightClearTrigger,
    Spike,
    RightEnergyItem,
    LeftEnergyItem,
    DefaultSignal,
    InputSignal,
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
