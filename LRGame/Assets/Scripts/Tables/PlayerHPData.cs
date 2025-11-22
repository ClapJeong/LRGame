using UnityEngine;

[System.Serializable]
public class PlayerHPData
{
  [SerializeField] private int maxHP;
  public int MaxHP => maxHP;

  [SerializeField] private float invincibleDuration;
  public float InvincibleDuration => invincibleDuration;

  [SerializeField] private float invincibleBlinkAlphaMax;
  public float InvincibleBlinkAlphaMax => invincibleBlinkAlphaMax;

  [SerializeField] private float invincibleBlinkAlphaMin;
  public float InvincibleBlinkAlphaMin => invincibleBlinkAlphaMin;
}