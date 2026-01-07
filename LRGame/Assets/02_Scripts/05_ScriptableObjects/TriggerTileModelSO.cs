using UnityEngine;
using LR.Table.TriggerTile;

[CreateAssetMenu(fileName = "TriggerTileSO", menuName = "SO/TriggerTile")]
public class TriggerTileModelSO : ScriptableObject
{
  [field: SerializeField] public ClearTriggerData ClearTrigger {  get; private set; }

  [field: Space(15)]
  [field: SerializeField] public SpikeTriggerData SpikeTrigger { get; private set; }

  [field: Space(15)]
  [field: SerializeField] public RightEnergyItemTriggerData RightEnergyItemTrigger { get; set; }
  [field: Space(15)]
  [field: SerializeField] public LeftEnergyItemTriggerData LeftEnergyItemTrigger { get; set; }
  [field: Space(15)]
  [field: SerializeField] public SignalTriggerData DefaultSignalTriggerData {  get; set; }
}
