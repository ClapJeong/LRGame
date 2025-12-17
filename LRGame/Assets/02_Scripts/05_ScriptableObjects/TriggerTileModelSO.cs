using UnityEngine;
using LR.Table.TriggerTile;

[CreateAssetMenu(fileName = "TriggerTileSO", menuName = "SO/TriggerTile")]
public class TriggerTileModelSO : ScriptableObject
{
  [field: SerializeField] public ClearTriggerData ClearTrigger {  get; set; }

  [field: SerializeField] public SpikeTriggerData SpikeTrigger { get; set; }

  [field: SerializeField] public EnergyItemData EnergyItem { get; set; }

  [field: SerializeField] public EnergyChargerData EnergyCharger { get; set; }
}
