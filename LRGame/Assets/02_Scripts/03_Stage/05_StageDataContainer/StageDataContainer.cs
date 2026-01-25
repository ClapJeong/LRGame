using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using LR.Stage.TriggerTile;
using LR.Stage.InteractiveObject;
using LR.Stage.SignalListener;

namespace LR.Stage.StageDataContainer
{
  public class StageDataContainer : MonoBehaviour
  {
    public int beforeDialogueIndex = -1;
    public int afterDialogueIndex = -1;
    public float cameraSize;
    public Transform leftPlayerBeginTransform;
    public Transform rightPlayerBeginTransform;
    public GameObject staticObstacle;
    public Transform otherObjectsRoot;
    public List<ChatCardEventSet> chatCardEvents = new();
    public ScoreData scoreData;

    public List<ITriggerTileView> TriggerTiles => otherObjectsRoot.GetComponentsInChildren<ITriggerTileView>().ToList();
    public List<SignalListener.SignalListener> SignalListeners => otherObjectsRoot.GetComponentsInChildren<SignalListener.SignalListener>().ToList();
    public List<IInteractiveObject> InteractiveObject => otherObjectsRoot.GetComponentsInChildren<IInteractiveObject>().ToList();

    private void OnDrawGizmos()
    {
      if (cameraSize <= 0.0f)
        return;

      Gizmos.color = Color.aquamarine;
      var widthRatio = 16.0f / 9.0f;
      var widthHalf = cameraSize * widthRatio;
      var heightHalf = cameraSize;

      var leftTop = new Vector2(-widthHalf, heightHalf);
      var rightTop = new Vector2(widthHalf, heightHalf);
      var leftBottom = new Vector2(-widthHalf, -heightHalf);
      var rightBottom = new Vector2(widthHalf, -heightHalf);

      Gizmos.DrawLine(leftTop, rightTop);
      Gizmos.DrawLine(leftTop, leftBottom);
      Gizmos.DrawLine(rightBottom, rightTop);
      Gizmos.DrawLine(rightBottom, leftBottom);

      Gizmos.color = Color.yellow;
      Gizmos.DrawLine(Vector2.up * (heightHalf + 2.0f), Vector2.down * (heightHalf + 2.0f));
    }
  }
}