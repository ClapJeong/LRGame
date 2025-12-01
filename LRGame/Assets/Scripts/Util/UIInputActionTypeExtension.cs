public static class UIInputActionTypeExtension
{
  public static Direction ParseToDirection(this UIInputActionType inputActionDirection)
    => inputActionDirection switch
    {
      UIInputActionType.LeftUP => Direction.Up,
      UIInputActionType.LeftRight => Direction.Right,
      UIInputActionType.LeftDown => Direction.Down,
      UIInputActionType.LeftLeft => Direction.Left,

      UIInputActionType.RightUP => Direction.Up,
      UIInputActionType.RightRight => Direction.Right,
      UIInputActionType.RightDown => Direction.Down,
      UIInputActionType.RightLeft => Direction.Left,

      UIInputActionType.Space => Direction.Space,

      _ => throw new System.NotImplementedException(),
    };
}