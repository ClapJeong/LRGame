using LR.Table.Dialogue;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueDataSO", menuName = "SO/DialogueData")]
public class DialogueUIDataSO : ScriptableObject
{
  [field: SerializeField] public PortraitData PortraitData { get; private set; }
  [field: SerializeField] public TextPresentationData TextPresentationData { get; private set; }
}