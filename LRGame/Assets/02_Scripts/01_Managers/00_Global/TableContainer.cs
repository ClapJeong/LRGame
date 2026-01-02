using UnityEngine;

public class TableContainer : MonoBehaviour
{
  [SerializeField] private PlayerModelSO leftPlayerModelSO;

  [SerializeField] private PlayerModelSO rightPlayerModelSO;

  [field: SerializeField] public AddressableKeySO AddressableKeySO {  get; private set; }

  [field: SerializeField] public TriggerTileModelSO TriggerTileModelSO {  get; private set; }

  [field: SerializeField] public UISO UISO {  get; private set; }

  [field: SerializeField] public LocalizationSO LocalizationSO { get; private set; }

  [field: SerializeField] public DialogueUIDataSO DialogueUIDataSO { get; private set; }

  [field: SerializeField] public EffectTableSO EffectTableSO { get; private set; }

  public PlayerModelSO GetPlayerModelSO(PlayerType playerType)
    => playerType switch
    {
      PlayerType.Left => leftPlayerModelSO,
      PlayerType.Right => rightPlayerModelSO,
      _ => throw new System.NotImplementedException(),
    };
}
