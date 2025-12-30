using System.Collections.Generic;

public static class UIInputDirectionTypeUtil
{
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
