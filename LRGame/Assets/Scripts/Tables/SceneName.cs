using UnityEngine;

[System.Serializable]
public class SceneName
{  
  [SerializeField] private string preloading;
  public string Preloading => preloading;

  [SerializeField] private string lobby;
  public string Lobby => lobby;

  [SerializeField] private string game;
  public string Game => game;
}
