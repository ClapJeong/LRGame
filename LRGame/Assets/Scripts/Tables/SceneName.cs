using UnityEngine;

public class SceneName : MonoBehaviour
{  
  [SerializeField] private string loading;
  public string Loading => loading;

  [SerializeField] private string lobby;
  public string Lobby => lobby;

  [SerializeField] private string game;
  public string Game => game;
}
