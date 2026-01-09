using LR.Stage.Player;

namespace LR.Stage.StageDataContainer
{
  [System.Serializable]
  public class PlayerEventData
  {
    public PlayerType targetPlayerType;
    public ChatCardEnum.PlayerEventType playerEventType;
    
    public float targetNormalizedValue;
    public IPlayerEnergySubscriber.OnChangedType valueType;

    public PlayerStateType targetPlayerState;
    public bool enter = true;
  }
}
