using UnityEngine;

[CreateAssetMenu(fileName = "UISO", menuName = "SO/UI")]
public class UISO : ScriptableObject
{
  [field: SerializeField] public UIInputActionPaths InputPaths {  get; set; }

  [field: SerializeField] public float IndicatorDuration {  get; set; }

  [field: SerializeField] public float ProgressSubmitDuration {  get; set; }
}
