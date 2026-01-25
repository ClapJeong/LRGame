using UnityEngine;
using LR.Stage.Player.Enum;

[System.Serializable]
public class GameObjectName
{
  [field: SerializeField] public string LeftPlayer { get; private set; }
  [field: SerializeField] public string RightPlayer { get; private set; }

  public string GetPlayerName(PlayerType playerType)
    => playerType switch
    {
      PlayerType.Left => LeftPlayer,
      PlayerType.Right => RightPlayer,
      _ => throw new System.NotImplementedException()
    };
  [field: SerializeField] public string ACSignalPreview {  get; private set; }
  [field: SerializeField] public string ACDCSignalPreview { get; private set; }
}
