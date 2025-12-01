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

  [SerializeField] private string chapterButton;
  public string ChapterButton => chapterButton;

  [SerializeField] private string chapterPanel;
  public string ChapterPanel => chapterPanel;

  [SerializeField] private string stageButton;
  public string StageButton => stageButton;

  [Header("[ Stage ]")]
  [SerializeField] private string stageRoot;
  public string StageRoot => stageRoot;

  [SerializeField] private string playerRoot;
  public string PlayerRoot => playerRoot;

  [Header("[ General ]")]
  [SerializeField] private string indicator;
  public string Indicator => indicator;
}
