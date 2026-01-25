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
  }

  public enum SignalEnter
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
