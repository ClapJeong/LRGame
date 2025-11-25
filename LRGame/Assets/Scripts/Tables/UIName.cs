using UnityEngine;

[System.Serializable]
public class UIName
{
  [Header("[ Prealoading ]")]
  [SerializeField] private string preloadingRoot;
  public string PreloadingRoot => preloadingRoot;

  [Header("[ Lobby ]")]
  [SerializeField] private string lobbyRoot;
  public string LobbyRoot => lobbyRoot;

  [SerializeField] private string lobbyStageButton;
  public string LobbyStageButton => lobbyStageButton;

  [Header("[ Stage ]")]
  [SerializeField] private string stageRoot;
  public string StageRoot => stageRoot;

  [SerializeField] private string playerRoot;
  public string PlayerRoot => playerRoot;

  [Header("[ General ]")]
  [SerializeField] private string indicator;
  public string Indicator => indicator;
}
