using LR.Stage.Player.Enum;
using UnityEngine;

[System.Serializable]
public class AddresasblePath
{
  [field: SerializeField] public string Player {  get; private set; }
  [field: SerializeField] public string UI {  get; private set; }
  [field: SerializeField] public string Scene {  get; private set; }
  [field: SerializeField] public string Stage {  get; private set; }
  [field: SerializeField] public string LeftDialoguePortrait {  get; private set; }
  [field: SerializeField] public string CenterDialoguePortrait { get; private set; }
  [field: SerializeField] public string RightDialoguePortrait { get; private set; }
  [field: SerializeField] public string Effect {  get; private set; }
  [field: SerializeField] public string ChatCardPortrait { get; private set; }
  [field: SerializeField] public string DialogueBackground { get; private set; }
  [field: SerializeField] public string LeftStatePortrait { get; private set; }
  [field: SerializeField] public string RightStatePortrait { get; private set; }
  public string GetStatePortraitLabel(PlayerType playerType)
    => playerType switch
    {
      PlayerType.Left => LeftStatePortrait,
      PlayerType.Right => RightStatePortrait,
      _ => throw new System.NotImplementedException(),
    };

}
