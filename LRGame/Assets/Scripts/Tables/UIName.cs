using UnityEngine;

[System.Serializable]
public class UIName
{
  [SerializeField] private string preloadingRoot;
  public string PreloadingRoot => preloadingRoot;

  [SerializeField] private string lobbyRoot;
  public string LobbyRoot=>lobbyRoot;

  [SerializeField] private string stageRoot;
  public string StageRoot => stageRoot;

  [SerializeField] private string playerRoot;
  public string PlayerRoot => playerRoot;

  [SerializeField] private string lobbyStageButton;
  public string LobbyStageButton => lobbyStageButton;
}
