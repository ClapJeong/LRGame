using UnityEngine;

[System.Serializable]
public class InputMashProgressData
{
  [field: SerializeField] [field:Range(0.0f, 1.0f)] public float BeginValue { get; private set; } = 0.5f;
  [field: SerializeField] public float DecreaseValuePerSecond { get; private set; }
  [field: SerializeField] public float IncreaseValueOnInput { get; private set; }
}
