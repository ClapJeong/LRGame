using UnityEngine;

namespace LR.Table.TriggerTile
{
  [System.Serializable]
  public class SpikeTriggerData
  {
    [field: SerializeField] public float DamageValue { get; set; }
    [field: SerializeField] public BounceData BounceData { get; set; }
  }
}