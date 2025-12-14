using UnityEngine;

namespace LR.Stage.Player
{
  public class PlayerModel
  {
    public PlayerModelSO so;

    public PlayerType playerType;
    public Vector3 beginPosition;    
    public IStageService stageService;

    public PlayerModel(PlayerModelSO so, PlayerType playerType, Vector3 beginPosition, IStageService stageService)
    {
      this.so = so;
      this.playerType = playerType;
      this.beginPosition = beginPosition;
      this.stageService = stageService;
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