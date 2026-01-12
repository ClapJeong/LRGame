using LR.Table.Dialogue;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueDataSO", menuName = "SO/DialogueData")]
public class DialogueUIDataSO : ScriptableObject
{
  [field: SerializeField] public float BackgroundChangeDuration { get; private set; }
  [field: Space(5)]
  [field: SerializeField] public UIPortraitData PortraitData { get; private set; }
  [field: Space(5)]
  [field: SerializeField] public UITextPresentationData TextPresentationData { get; private set; }
  [field: Space(5)]
  [field: SerializeField] public UISelectionData SelectionData { get; private set; }
}