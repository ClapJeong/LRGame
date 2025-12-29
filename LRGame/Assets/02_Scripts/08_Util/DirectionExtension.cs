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

  public static Direction Random(bool isInclusiveSpace = false)
  {
    var min = 0;
    var max = (int)Direction.Space;
    if (isInclusiveSpace == false)
      max--;

    return (Direction)UnityEngine.Random.Range(min, max + 1);
  }
}