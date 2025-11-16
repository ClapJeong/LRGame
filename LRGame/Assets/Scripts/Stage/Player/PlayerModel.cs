using UnityEngine;

public class PlayerModel
{
  private readonly Vector3 up;
  private readonly Vector3 down;
  private readonly Vector3 left;
  private readonly Vector3 right;

  public readonly Vector3 beginPosition;

  public PlayerModel(
    Vector3 up,
    Vector3 down,
    Vector3 left,
    Vector3 right,
    Vector3 beginPosition)
  {
    this.up = up;
    this.down = down;
    this.left = left;
    this.right = right;
    this.beginPosition = beginPosition;
  }

  public Vector3 ParseDirection(Direction direction)
    => direction switch
    {
      Direction.Up => up,
      Direction.Down => down,
      Direction.Left => left,
      Direction.Right => right,
      _ => throw new System.NotImplementedException(),
    };
}
