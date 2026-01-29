using UnityEngine;

[System.Serializable]
public class PlayerEnergyData
{
  [field: SerializeField] public float MaxEnergy { get; private set; }

  [field: SerializeField] public float DecreasingValue {  get; private set; }

  [field: SerializeField] public float DecayDecreasingValue { get; private set; }

  [field: SerializeField] public float InvincibleDuration {  get; private set; }

  [field: SerializeField] public float InvincibleBlinkAlphaMax { get; private set; }

  [field: SerializeField] public float InvincibleBlinkAlphaMin {  get; private set; }
}