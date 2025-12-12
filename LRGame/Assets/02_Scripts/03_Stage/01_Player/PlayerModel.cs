using UnityEngine;

namespace LR.Stage.Player
{
  public class PlayerModel
  {
    public readonly Vector3 beginPosition;

    public PlayerModelSO so;

    public PlayerModel(
      PlayerModelSO so,
      Vector3 beginPosition)
    {
      this.so = so;
      this.beginPosition = beginPosition;
    }

    public Vector3 ParseDirection(Direction direction)
      => direction switch
      {
        Direction.Up => so.Movement.UpVector,
        Direction.Down => so.Movement.DownVector,
        Direction.Left => so.Movement.LeftVector,
        Direction.Right => so.Movement.RightVector,
        _ => throw new System.NotImplementedException(),
      };
  }
}