#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Events;

namespace LR.Stage
{
  public class SignalListener : MonoBehaviour
  {
    [field: SerializeField] public string RequireKey { get; private set; }
    [SerializeField] private UnityEvent onActivate = new();
    [SerializeField] private UnityEvent onDeactivate = new();

    private bool IsKeyExist
      => string.IsNullOrEmpty(RequireKey) == false;

    public void OnActivate()
      => onActivate.Invoke();

    public void OnDeactivate()
      => onDeactivate.Invoke();


#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
      if (IsKeyExist)
      {
        var labelCenterStyle = new GUIStyle(EditorStyles.label)
        {
          alignment = TextAnchor.MiddleCenter
        };
        Handles.Label(transform.position + Vector3.up, "[ " + RequireKey +" ]", labelCenterStyle);
      }
    }
#endif
  }
}
