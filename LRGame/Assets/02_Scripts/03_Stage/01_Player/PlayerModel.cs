using UnityEngine;

namespace LR.Stage.Player
{
  public class PlayerModel
  {
    public PlayerModelSO so;

    public PlayerType playerType;
    public Vector3 beginPosition;    
    public IStageStateHandler stageService;
    public IStageResultHandler stageResultHandler;
    public IPlayerGetter playerGetter;
    public InputActionFactory inputActionFactory;
    public IInputSequenceStopController inputSequenceStopController;

    public PlayerModel(
      PlayerModelSO so, 
      PlayerType playerType, 
      Vector3 beginPosition, 
      IStageStateHandler stageService,
      IStageResultHandler stageResultHandler,
      IPlayerGetter playerGetter,
      InputActionFactory inputActionFactory,
      IInputSequenceStopController inputSequenceStopController)
    {
      this.so = so;
      this.playerType = playerType;
      this.beginPosition = beginPosition;
      this.stageService = stageService;
      this.stageResultHandler = stageResultHandler;
      this.playerGetter = playerGetter;
      this.inputActionFactory = inputActionFactory;
      this.inputSequenceStopController = inputSequenceStopController;
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