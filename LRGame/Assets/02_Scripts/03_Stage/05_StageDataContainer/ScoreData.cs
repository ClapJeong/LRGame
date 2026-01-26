using LR.Stage.Player.Enum;
using UnityEngine;

namespace LR.Stage.StageDataContainer
{
  [System.Serializable]
  public class ScoreData
  {
    [Range(0.0f, 1.0f)] public float Left = 0.5f;
    [Range(0.0f, 1.0f)] public float Right = 0.5f;

    public float GetValue(PlayerType playerType)
      => playerType switch
      {
        PlayerType.Left => Left,
        PlayerType.Right => Right,
        _ => throw new System.NotImplementedException(),
      };
  }
}
