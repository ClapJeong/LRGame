using LR.Stage.Player.Enum;
using UnityEngine;

[System.Serializable]
public class AtlasName
{
  [field: SerializeField] public string ChatPortrait { get; private set; }

  [field: Header("[ Dialogue Atlas ]")]
  [field: SerializeField] public string LeftDialoguePortrait { get; private set; }
  [field: SerializeField] public string CenterDialoguePortrait { get; private set; }
  [field: SerializeField] public string RightDialoguePortrait { get; private set; }

  public string GetDialoguePortrait(CharacterPositionType characterPositionType)
    => characterPositionType switch
    {
      CharacterPositionType.Left => LeftDialoguePortrait,
      CharacterPositionType.Center => CenterDialoguePortrait,
      CharacterPositionType.Right => RightDialoguePortrait,
      _ => throw new System.NotImplementedException(),
    };

  [field: SerializeField] public string DialogueBackgroundPortrait { get; private set; }

  [field: Header("[ State Portrait Atlas ]")]
  [field: SerializeField] public string LeftStatePortrait { get; private set; }
  [field: SerializeField] public string RightStatePortrait { get; private set; }

  public string GetStatePortrait(PlayerType playerType)
    => playerType switch
    {
      PlayerType.Left => LeftStatePortrait,
      PlayerType.Right => RightStatePortrait,
      _ => throw new System.NotImplementedException(),
    };  
}
