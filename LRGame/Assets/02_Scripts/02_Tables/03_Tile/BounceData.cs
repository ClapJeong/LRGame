using UnityEngine;

namespace LR.Table.TriggerTile
{
  [System.Serializable]
  public class BounceData
  {
    [SerializeField] private float force;
    public float Force => force;

    [SerializeField] private float stunDuration;
    public float StunDuration => stunDuration;
  }
}