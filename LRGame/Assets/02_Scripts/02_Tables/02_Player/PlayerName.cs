using UnityEngine;

[System.Serializable]
public class PlayerName
{
  [SerializeField] private string leftPlayer;
  public string LeftPlayer => leftPlayer;

  [SerializeField] private string rightPlayer;
  public string RightPlayer => rightPlayer;

}
