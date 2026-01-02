using UnityEngine;

namespace LR.Table.TriggerTile
{
  [System.Serializable]
  public class EnergyItemData
  {
    [field: SerializeField] public float RestoreValue { get; private set; }
    [field: SerializeField] public EffectType EffectType { get; private set; }
  }
}