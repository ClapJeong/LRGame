using UnityEngine;

public class PlayerName : MonoBehaviour
{
  [SerializeField] private string leftPlayer;
  public string LeftPlayer => leftPlayer;

  [SerializeField] private string rightPlayer;
  public string RightPlayer => rightPlayer;

}
