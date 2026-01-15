using LR.Stage.Player.Enum;

public static class PlayerTypeExtension
{
  public static PlayerType ParseOpposite(this PlayerType playerType)
    => playerType switch
    {
      PlayerType.Left => PlayerType.Right,
      PlayerType.Right => PlayerType.Left,
      _ => throw new System.NotImplementedException(),
    };
}