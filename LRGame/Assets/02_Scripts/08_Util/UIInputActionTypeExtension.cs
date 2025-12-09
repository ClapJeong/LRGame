public static class UIinputDirectionTypeExtension
{
  public static Direction ParseToDirection(this UIInputDirectionType inputActionDirection)
    => inputActionDirection switch
    {
      UIInputDirectionType.LeftUp => Direction.Up,
      UIInputDirectionType.LeftRight => Direction.Right,
      UIInputDirectionType.LeftDown => Direction.Down,
      UIInputDirectionType.LeftLeft => Direction.Left,

      UIInputDirectionType.RightUP => Direction.Up,
      UIInputDirectionType.RightRight => Direction.Right,
      UIInputDirectionType.RightDown => Direction.Down,
      UIInputDirectionType.RightLeft => Direction.Left,

      UIInputDirectionType.Space => Direction.Space,

      _ => throw new System.NotImplementedException(),
    };
}