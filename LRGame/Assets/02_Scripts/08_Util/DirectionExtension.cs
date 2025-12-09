public static class DirectionExtension
{
  public static Direction ParseOpposite(this Direction direction)
    => direction switch
    {
      Direction.Up => Direction.Down,
      Direction.Down => Direction.Up,
      Direction.Left => Direction.Right,
      Direction.Right => Direction.Left,
      Direction.Space => Direction.Space,
      _ => throw new System.NotImplementedException(),
    };
}