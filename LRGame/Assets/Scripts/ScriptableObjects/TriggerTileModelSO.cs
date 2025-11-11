using UnityEngine;

[CreateAssetMenu(fileName = "TriggerTileSO", menuName = "SO/TriggerTile")]
public class TriggerTileModelSO : ScriptableObject
{
  [System.Serializable]
  public class ClearTriggerData
  {

  }
  [SerializeField] private ClearTriggerData clearTrigger;
  public ClearTriggerData ClearTrigger => clearTrigger;
}
