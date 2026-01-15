using UnityEngine;

namespace LR.Stage.StageDataContainer
{
  [System.Serializable]
  public class ScoreData
  {
    [Range(0.0f, 1.0f)] public float Left;
    [Range(0.0f, 1.0f)] public float Right;
  }
}
