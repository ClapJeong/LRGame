using UnityEngine;

namespace LR.Table.TriggerTile
{
  [System.Serializable]
  public class RightEnergyItemTriggerData
  {
    [field: SerializeField] public InputProgressEnum.InputProgressUIType UIType { get; private set; }
    [field: SerializeField] public float RestoreValue { get; private set; }
    [field: SerializeField] public InputMashProgressData InputMashProgressData {  get; private set; }
  }
}
