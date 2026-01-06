using UnityEngine;

namespace LR.Table.Input
{
  [System.Serializable]
  public class CharacterMoveKeyCodeData
  {
    [field: SerializeField] public KeyCode UP { get; private set; }
    [field: SerializeField] public KeyCode Right { get; private set; }
    [field: SerializeField] public KeyCode Down { get; private set; }
    [field: SerializeField] public KeyCode Left { get; private set; }

    public KeyCode GetKeyCode(Direction direction)
      => direction switch
      {
        Direction.Up => UP,
        Direction.Right => Right,
        Direction.Down => Down,
        Direction.Left => Left,
        _ => throw new System.NotImplementedException()
      };
  }
}