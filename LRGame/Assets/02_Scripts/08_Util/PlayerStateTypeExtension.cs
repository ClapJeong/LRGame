public static class PlayerStateTypeExtenstion
{
  public static bool IsCharging(this PlayerStateType playerStateType)
  {
    if (playerStateType == PlayerStateType.ChargingIdle || playerStateType == PlayerStateType.ChargingMove)
      return true;
    else
      return false;
  }
}