using LR.Table.Input;
using UnityEngine;

namespace LR.Table.TriggerTile
{
  [System.Serializable]
  public class RightEnergyItemTriggerData
  {    
    [field: SerializeField] public float RestoreValue { get; private set; }
    [field: SerializeField] public InputProgressData InputProgressData {  get; private set; }
  }
}
