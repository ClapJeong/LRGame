using LR.Stage.Player;
using LR.Stage.Player.Enum;

namespace LR.Stage.StageDataContainer
{
  [System.Serializable]
  public class PlayerEventData
  {
    public PlayerType targetPlayerType;
    public ChatCardEnum.PlayerEventType playerEventType;
    
    public float targetNormalizedValue;
    public IPlayerEnergySubscriber.OnChangedType valueType;

    public PlayerState targetPlayerState;
    public bool enter = true;
  }
}
