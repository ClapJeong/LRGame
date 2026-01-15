using System.Collections.Generic;
using LR.UI.Enum;

public static class UIInputDirectionTypeUtil
{
  public static List<InputDirection> GetLefts()
    => new()
    {
      InputDirection.LeftUp,
      InputDirection.LeftRight,
      InputDirection.LeftDown,
      InputDirection.LeftLeft,
    };

  public static List<InputDirection> GetRights()
    => new()
    {
      InputDirection.RightUp,
      InputDirection.RightRight,
      InputDirection.RightDown,
      InputDirection.RightLeft,
    };

  public static Direction ParseToDirection(this InputDirection inputActionDirection)
  => inputActionDirection switch
  {
    InputDirection.LeftUp => Direction.Up,
    InputDirection.LeftRight => Direction.Right,
    InputDirection.LeftDown => Direction.Down,
    InputDirection.LeftLeft => Direction.Left,

    InputDirection.RightUp => Direction.Up,
    InputDirection.RightRight => Direction.Right,
    InputDirection.RightDown => Direction.Down,
    InputDirection.RightLeft => Direction.Left,

    InputDirection.Space => Direction.Space,

    _ => throw new System.NotImplementedException(),
  };
}
