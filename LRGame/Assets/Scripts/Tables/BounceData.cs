using UnityEngine;

[System.Serializable]
public class BounceData
{
  [SerializeField] private float force;
  public float Force => force;

  [SerializeField] private float deceleration;
  public float Deceleration => deceleration;
}