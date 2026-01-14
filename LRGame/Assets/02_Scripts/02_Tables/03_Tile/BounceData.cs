using UnityEngine;

namespace LR.Table.TriggerTile
{
  [System.Serializable]
  public class BounceData
  {
    [field: SerializeField] public bool IsStun { get; private set; }
    [field: SerializeField] public float Force { get; private set; }
  }
}