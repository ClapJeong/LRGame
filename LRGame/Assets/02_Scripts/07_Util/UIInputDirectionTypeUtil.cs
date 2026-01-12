using System.Collections.Generic;

public static class UIInputDirectionTypeUtil
{
  public static List<UIInputDirection> GetLefts()
    => new()
    {
      UIInputDirection.LeftUp,
      UIInputDirection.LeftRight,
      UIInputDirection.LeftDown,
      UIInputDirection.LeftLeft,
    };

  public static List<UIInputDirection> GetRights()
    => new()
    {
      UIInputDirection.RightUp,
      UIInputDirection.RightRight,
      UIInputDirection.RightDown,
      UIInputDirection.RightLeft,
    };

}
