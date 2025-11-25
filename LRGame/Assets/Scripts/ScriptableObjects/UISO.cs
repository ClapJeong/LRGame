using UnityEngine;

[CreateAssetMenu(fileName = "UISO", menuName = "SO/UI")]
public class UISO : ScriptableObject
{
  [SerializeField] private UIInputActionPaths inputPaths;
  public UIInputActionPaths InputPaths => inputPaths;

  [Space(5)]
  [SerializeField] private float indicatorDuration;
  public float IndicatorDuration => indicatorDuration;
}
