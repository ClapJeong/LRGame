using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using LR.Stage.TriggerTile;

namespace LR.Stage
{
  public class StageDataContainer : MonoBehaviour
  {
    public float CameraSize;

    [Space(5)]
    public Transform LeftPlayerBeginTransform;
    public Transform RightPlayerBeginTransform;

    [Space(5)]
    public GameObject StaticObstacle;

    [Space(5)]
    [SerializeField] private Transform triggerTileRoot;
    public List<ITriggerTileView> TriggerTiles => triggerTileRoot.GetComponentsInChildren<ITriggerTileView>().ToList();

    [Space(5)]
    [SerializeField] private Transform dynamicObstacleRoot;
    public List<DynamicObstacleBase> DynamicObstacles => dynamicObstacleRoot.GetComponentsInChildren<DynamicObstacleBase>().ToList();

    private void OnDrawGizmos()
    {
      if (CameraSize <= 0.0f)
        return;

      Gizmos.color = Color.aquamarine;
      var widthRatio = 16.0f / 9.0f;
      var widthHalf = CameraSize * widthRatio;
      var heightHalf = CameraSize;

      var leftTop = new Vector2(-widthHalf, heightHalf);
      var rightTop = new Vector2(widthHalf, heightHalf);
      var leftBottom = new Vector2(-widthHalf, -heightHalf);
      var rightBottom = new Vector2(widthHalf, -heightHalf);

      Gizmos.DrawLine(leftTop, rightTop);
      Gizmos.DrawLine(leftTop, leftBottom);
      Gizmos.DrawLine(rightBottom, rightTop);
      Gizmos.DrawLine(rightBottom, leftBottom);
    }
  }
}