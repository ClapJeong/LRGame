using UnityEngine;

public class TableContainer : MonoBehaviour
{
  [SerializeField] private PlayerModelSO leftPlayerModelSO;

  [SerializeField] private PlayerModelSO rightPlayerModelSO;

  [SerializeField] private AddressableKeySO addressableKeySO;
  public AddressableKeySO AddressableKeySO => addressableKeySO;

  [SerializeField] private TriggerTileModelSO triggerTileModelSO;
  public TriggerTileModelSO TriggerTileModelSO => triggerTileModelSO;

  [SerializeField] private UISO uiSO;
  public UISO UISO => uiSO;

  public PlayerModelSO GetPlayerModelSO(PlayerType playerType)
    => playerType switch
    {
      PlayerType.Left => leftPlayerModelSO,
      PlayerType.Right => rightPlayerModelSO,
      _ => throw new System.NotImplementedException(),
    };
}
