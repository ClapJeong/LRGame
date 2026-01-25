namespace LR.Stage.TriggerTile.Enum
{
  public enum TriggerTileType
  {
    LeftClearTrigger,
    RightClearTrigger,
    Spike,
    RightEnergyItem,
    LeftEnergyItem,
    Signal,
  }

  public enum SignalInput
  {
    None,
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
