using UnityEngine;
using LR.Stage.Player.Enum;

namespace LR.Stage.Player
{
  public class PlayerStartPositionGizmo : MonoBehaviour
  {
    public PlayerType playerType;

    private void OnDrawGizmos()
    {
      var position = transform.position;
      var leftTop = position + new Vector3(-0.5f, 0.5f, 0.0f);
      var rightTop = position + new Vector3(0.5f, 0.5f, 0.0f);
      var leftBottom = position + new Vector3(-0.5f, -0.5f, 0.0f);
      var rightBottom = position + new Vector3(0.5f, -0.5f, 0.0f);

      var color = playerType switch
      {
        PlayerType.Left => Color.red,
        PlayerType.Right => Color.blue,
        _ => throw new System.NotImplementedException()
      };
      Gizmos.color = color;
      Gizmos.DrawLine(leftTop, rightTop);
      Gizmos.DrawLine(rightTop, rightBottom);
      Gizmos.DrawLine(rightBottom, leftBottom);
      Gizmos.DrawLine(leftBottom, leftTop);
    }
  }
}