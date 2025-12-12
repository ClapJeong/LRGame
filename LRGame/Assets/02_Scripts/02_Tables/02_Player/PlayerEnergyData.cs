using UnityEngine;

[System.Serializable]
public class PlayerEnergyData
{
  [field: SerializeField] public float MaxEnergy { get; set; }

  [field: SerializeField] public float DecreasingValue {  get; set; }

  [field: SerializeField] public float InvincibleDuration {  get; set; }

  [field: SerializeField] public float InvincibleBlinkAlphaMax { get; set; }

  [field: SerializeField] public float InvincibleBlinkAlphaMin {  get; set; }
}