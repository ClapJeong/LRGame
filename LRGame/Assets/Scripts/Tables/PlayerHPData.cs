using UnityEngine;

[System.Serializable]
public class PlayerHPData
{
  [SerializeField] private int maxHP;
  public int MaxHP => maxHP;

  [SerializeField] private float invincibleDuration;
  public float InvincibleDuration => invincibleDuration;
}