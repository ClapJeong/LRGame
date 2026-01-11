using System.Collections.Generic;

public static class UIinputDirectionTypeExtension
{
  public static Direction ParseToDirection(this UIInputDirection inputActionDirection)
    => inputActionDirection switch
    {
      UIInputDirection.LeftUp => Direction.Up,
      UIInputDirection.LeftRight => Direction.Right,
      UIInputDirection.LeftDown => Direction.Down,
      UIInputDirection.LeftLeft => Direction.Left,

      UIInputDirection.RightUp => Direction.Up,
      UIInputDirection.RightRight => Direction.Right,
      UIInputDirection.RightDown => Direction.Down,
      UIInputDirection.RightLeft => Direction.Left,

      UIInputDirection.Space => Direction.Space,

      _ => throw new System.NotImplementedException(),
    };
}