using System.Collections.Generic;

public static class UIinputDirectionTypeExtension
{
  public static Direction ParseToDirection(this UIInputDirectionType inputActionDirection)
    => inputActionDirection switch
    {
      UIInputDirectionType.LeftUp => Direction.Up,
      UIInputDirectionType.LeftRight => Direction.Right,
      UIInputDirectionType.LeftDown => Direction.Down,
      UIInputDirectionType.LeftLeft => Direction.Left,

      UIInputDirectionType.RightUp => Direction.Up,
      UIInputDirectionType.RightRight => Direction.Right,
      UIInputDirectionType.RightDown => Direction.Down,
      UIInputDirectionType.RightLeft => Direction.Left,

      UIInputDirectionType.Space => Direction.Space,

      _ => throw new System.NotImplementedException(),
    };

  public static List<UIInputDirectionType> GetLefts()
    => new()
    {
      UIInputDirectionType.LeftUp,
      UIInputDirectionType.LeftRight,
      UIInputDirectionType.LeftDown,
      UIInputDirectionType.LeftLeft,
    };

  public static List<UIInputDirectionType> GetRights()
    => new()
    {
      UIInputDirectionType.RightUp,
      UIInputDirectionType.RightRight,
      UIInputDirectionType.RightDown,
      UIInputDirectionType.RightLeft,
    };
}