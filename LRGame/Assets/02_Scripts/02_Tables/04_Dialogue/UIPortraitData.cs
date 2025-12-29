using UnityEngine;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class UIPortraitData
  {
    [field: Header("ChangeType")]
    [field: SerializeField] public float ChangeFadeDuration { get; private set; }

    [field: Space(10)]
    [field: Header("AnimationType")]

    [field: Space(10)]
    [field: Header("AlphaType")]
    [field: SerializeField] public float AlphaMax { get; private set; }
    [field: SerializeField] public float AlphaHalfHidden { get; private set; }
    [field: SerializeField] public float AlphaMin { get; private set; }

    public float GetAlphaValue(PortraitEnum.AlphaType type)
      => type switch
      {
        PortraitEnum.AlphaType.Max => AlphaMax,
        PortraitEnum.AlphaType.HalfHidden => AlphaHalfHidden,
        PortraitEnum.AlphaType.Min => AlphaMin,
        _ => throw new System.NotImplementedException()
      };
  }
}