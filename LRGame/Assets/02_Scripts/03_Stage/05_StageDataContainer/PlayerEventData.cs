namespace LR.Stage.StageDataContainer
{
  [System.Serializable]
  public class PlayerEventData : EventDataBase
  {
    public PlayerType targetPlayerType;
    public ChatCardEnum.PlayerEventType playerEventType;
    public float targetNormalizedValue;
    public PlayerStateType targetPlayerState;
  }
}
