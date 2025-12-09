using UnityEngine;

public class TableContainer : MonoBehaviour
{
  [SerializeField] private PlayerModelSO leftPlayerModelSO;
  public PlayerModelSO LeftPlayerModelSO=>leftPlayerModelSO;

  [SerializeField] private PlayerModelSO rightPlayerModelSO;
  public PlayerModelSO RightPlayerModelSO =>rightPlayerModelSO;

  [SerializeField] private AddressableKeySO addressableKeySO;
  public AddressableKeySO AddressableKeySO => addressableKeySO;

  [SerializeField] private TriggerTileModelSO triggerTileModelSO;
  public TriggerTileModelSO TriggerTileModelSO => triggerTileModelSO;

  [SerializeField] private UISO uiSO;
  public UISO UISO => uiSO;
}
