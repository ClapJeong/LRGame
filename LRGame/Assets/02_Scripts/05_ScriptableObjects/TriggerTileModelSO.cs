using UnityEngine;

[CreateAssetMenu(fileName = "TriggerTileSO", menuName = "SO/TriggerTile")]
public class TriggerTileModelSO : ScriptableObject
{
  [field: SerializeField] public ClearTriggerData ClearTrigger {  get; set; }

  [field: SerializeField] public SpikeTriggerData SpikeTrigger { get; set; }

  [field: SerializeField] public EnergyItemData EnergyItem { get; set; }
}
