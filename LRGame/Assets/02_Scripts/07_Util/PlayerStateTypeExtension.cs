public static class PlayerStateTypeExtenstion
{
  public static bool IsCharging(this PlayerStateType playerStateType)
  {
    if (playerStateType == PlayerStateType.Inputting)
      return true;
    else
      return false;
  }
}