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

  [System.Serializable]
  public class SpikeTriggerData
  {
    [SerializeField] private BounceData bounceData;
    public BounceData BounceData => bounceData;
  }
  [SerializeField] private SpikeTriggerData spikeTrigger;
  public SpikeTriggerData SpikeTrigger => spikeTrigger;
}
