using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace LR.Stage.SignalListener
{
  public class SignalListener : MonoBehaviour
  {
    [field: Header("[ Key ]")]
    [field: SerializeField] public string RequireKey { get; private set; }

    [Header("[ Events ]")]
    [SerializeField] private UnityEvent onActivate = new();
    [SerializeField] private UnityEvent onDeactivate = new();

    [Header("[ Preview ]")]
    [SerializeField] private int countPreview = 3;
    [SerializeField] private Vector3 previewPosition = Vector3.up;
    [SerializeField] private float previewSpace = 0.15f;
    [SerializeField] private float prevSize = 0.4f;
    public Color previewColor;

    private bool IsKeyExist
      => string.IsNullOrEmpty(RequireKey) == false;

    public void OnActivate()
      => onActivate.Invoke();

    public void OnDeactivate()
      => onDeactivate.Invoke();

    public List<Vector3> GetPreviewPositions(int count)
    {
      if (count == 0)
        return new List<Vector3>();

      var lists = new List<Vector3>();
      var totalLength = prevSize * count + previewSpace * (count - 1);
      var currentLength = 0.0f;
      for (int i = 0; i < count; i++)
      {
        var sizeHalf = prevSize * 0.5f;
        currentLength += sizeHalf;
        lists.Add(transform.TransformPoint(previewPosition + new Vector3(currentLength - totalLength * 0.5f, 0.0f, 0.0f)));
        currentLength += sizeHalf;
        if (i < count - 1)
          currentLength += previewSpace;
      }

      return lists;
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
      if (IsKeyExist)
      {
        var labelCenterStyle = new GUIStyle(EditorStyles.label)
        {
          alignment = TextAnchor.MiddleCenter
        };
        labelCenterStyle.normal.textColor = Color.red;
        Handles.Label(transform.position + Vector3.up, "[ " + RequireKey + " ]", labelCenterStyle);

        if (countPreview > 0)
        {
          Gizmos.color = Color.red;
          var positions = GetPreviewPositions(countPreview);
          foreach(var position in positions)
          {
            var sizeHalf = prevSize * 0.5f;
            var leftUp = position + new Vector3(-sizeHalf, sizeHalf);
            var leftDown = position + new Vector3(-sizeHalf, -sizeHalf);
            var rightUp = position + new Vector3(sizeHalf, sizeHalf);
            var rightDown = position + new Vector3(sizeHalf, -sizeHalf);

            Gizmos.DrawLine(leftUp, rightUp);
            Gizmos.DrawLine(leftUp, leftDown);
            Gizmos.DrawLine(rightDown, rightUp);
            Gizmos.DrawLine(rightDown, leftDown);
          }
        }        
      }
    }
#endif
  }
}
