using LR.Table.Input;
using UnityEngine;

[CreateAssetMenu(fileName = "UISO", menuName = "SO/UI")]
public class UISO : ScriptableObject
{
  [field: SerializeField] public UIInputActionPaths InputPaths {  get; private set; }

  [field: Space(5)]
  [field: SerializeField] public float IndicatorDuration {  get; private set; }
  [field: Space(5)]
  [field: SerializeField] public float ProgressSubmitDuration {  get; private set; }
  [field: Space(5)]
  [field: SerializeField] public float LoadingFaceDuraton { get; private set; }
  [field: Space(5)]
  [field: SerializeField] public float ChatCardShowDuration { get; private set; }
  [field: SerializeField] public float ChatCardHideDuration { get; private set; }
}
