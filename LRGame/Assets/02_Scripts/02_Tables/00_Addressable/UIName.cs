using UnityEngine;

[System.Serializable]
public class UIName
{
  [field: Header("[ Prealoading ]")]
  [field: SerializeField] public string PreloadingRoot {  get; private set; }
  [field: SerializeField] public string VeryFirstCutscene { get; private set; }
  [field: SerializeField] public string VeryFirstLocale { get; private set; }

  [field: Space(10)]
  [field: Header("[ Lobby ]")]
  [field: SerializeField] public string LobbyRoot {  get; private set; }
  [field: SerializeField] public string StageButtonSet {  get; private set; }

  [field: Space(10)]
  [field: Header("[ Stage ]")]
  [field: SerializeField] public string StageRoot {  get; private set; }
  [field: SerializeField] public string PlayerRoot {  get; private set; }
  [field: SerializeField] public string DialogueRoot { get; private set; }

  [field: Space(10)]
  [field: Header("[ ChatCard ]")]
  [field: SerializeField] public string LeftChatCard { get; private set; }
  [field: SerializeField] public string CenterChatCard { get; private set; }
  [field: SerializeField] public string RightChatCard { get; private set; }

  public string GetChatCardName(CharacterPositionType positionType)
    => positionType switch
    {
      CharacterPositionType.Left => LeftChatCard,
      CharacterPositionType.Center => CenterChatCard,
      CharacterPositionType.Right => RightChatCard,
      _ => throw new System.NotImplementedException(),
    };


  [field: Space(10)]
  [field: Header("[ General ]")]
  [field: SerializeField] public string Indicator {  get; private set; }
  [field: SerializeField] public string Loading { get; private set; }
}
