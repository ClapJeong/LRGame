using UnityEngine;

[System.Serializable]
public class PlayerName
{
  [SerializeField] private string leftPlayer;
  public string LeftPlayer => leftPlayer;

  [SerializeField] private string rightPlayer;
  public string RightPlayer => rightPlayer;

  public string GetPlayerName(PlayerType playerType)
    => playerType switch
    {
      PlayerType.Left => leftPlayer,
      PlayerType.Right => rightPlayer,
      _ => throw new System.NotImplementedException()
    };
}
