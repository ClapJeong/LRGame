using UnityEngine;

public class TableContainer : MonoBehaviour
{
  [SerializeField] private PlayerModelSO leftPlayerModelSO;

  [SerializeField] private PlayerModelSO rightPlayerModelSO;

  [field: SerializeField] public AddressableKeySO AddressableKeySO {  get; set; }

  [field: SerializeField] public TriggerTileModelSO TriggerTileModelSO {  get; set; }

  [field: SerializeField] public UISO UISO {  get; set; }

  [field: SerializeField] public LocalizationSO LocalizationSO { get; set; }

  [field: SerializeField] public DialogueUIDataSO DialogueUIDataSO { get; set; }

  public PlayerModelSO GetPlayerModelSO(PlayerType playerType)
    => playerType switch
    {
      PlayerType.Left => leftPlayerModelSO,
      PlayerType.Right => rightPlayerModelSO,
      _ => throw new System.NotImplementedException(),
    };
}
