using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using LR.Stage.TriggerTile;
using LR.Stage.InteractiveObject;

namespace LR.Stage
{
  public class StageDataContainer : MonoBehaviour
  {
    [field: SerializeField] public int BeforeDialogueIndex { get; private set; } = -1;
    [field: SerializeField] public int AfterDialogueIndex { get; private set; } = -1;

    [Space(5)]
    public float CameraSize;

    [Space(5)]
    public Transform LeftPlayerBeginTransform;
    public Transform RightPlayerBeginTransform;

    [Space(5)]
    public GameObject StaticObstacle;

    [Space(5)]
    [SerializeField] private Transform otherObjectsRoot;
    public List<ITriggerTileView> TriggerTiles => otherObjectsRoot.GetComponentsInChildren<ITriggerTileView>().ToList();
    public List<SignalListener> SignalListeners => otherObjectsRoot.GetComponentsInChildren<SignalListener>().ToList();
    public List<IInteractiveObject> interactiveObject => otherObjectsRoot.GetComponentsInChildren<IInteractiveObject>().ToList();

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