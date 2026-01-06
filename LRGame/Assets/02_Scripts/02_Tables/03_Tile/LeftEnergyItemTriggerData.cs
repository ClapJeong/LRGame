using LR.Table.Input;
using UnityEngine;

namespace LR.Table.TriggerTile
{
  [System.Serializable]
  public class LeftEnergyItemTriggerData
  {
    [field: SerializeField] public InputQTEData QTEData { get; private set; }
    [field: SerializeField] public float RestoreValue {  get; private set; }
  }
}
