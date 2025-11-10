using UnityEngine;

[System.Serializable]
public class UIName
{
  [SerializeField] private string preloadingFirst;
  public string PreloadingFirst => preloadingFirst;

  [SerializeField] private string lobbyFirst;
  public string LobbyFirst=>lobbyFirst;

  [SerializeField] private string gameFirst;
  public string GameFirst => gameFirst;
}
