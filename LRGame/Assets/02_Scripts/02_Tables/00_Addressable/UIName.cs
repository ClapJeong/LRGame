using UnityEngine;

[System.Serializable]
public class UIName
{
  [field: Header("[ Prealoading ]")]
  [field: SerializeField] public string PreloadingRoot {  get; set; }

  [field: Space(10)]
  [field: Header("[ Lobby ]")]
  [field: SerializeField] public string LobbyRoot {  get; set; }
  [field: SerializeField] public string LobbyChapterButton {  get; set; }
  [field: SerializeField] public string LobbyChapterPanel {  get; set; }

  [field: Space(10)]
  [field: Header("[ Stage ]")]
  [field: SerializeField] public string StageRoot {  get; set; }
  [field: SerializeField] public string PlayerRoot {  get; set; }

  [field: Space(10)]
  [field: Header("[ General ]")]
  [field: SerializeField] public string Indicator {  get; set; }
}
