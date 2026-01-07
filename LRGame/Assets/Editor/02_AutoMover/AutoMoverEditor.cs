using LR.Stage.InteractiveObject.AutoMover;
using UnityEditor;
using UnityEngine;

namespace LR.Editor
{
  [CustomEditor(typeof(AutoMover))]
  public class AutoMoverEditor : UnityEditor.Editor
  {
    private SerializedProperty type;
    private SerializedProperty animationCurve;
    private SerializedProperty duration;
    private SerializedProperty startOnAwake;
    private SerializedProperty waypoints;
    private SerializedProperty radius;
    private SerializedProperty angle;

    private void OnEnable()
    {
      type = serializedObject.FindProperty(nameof(type));
      animationCurve = serializedObject.FindProperty(nameof(animationCurve));
      duration = serializedObject.FindProperty(nameof(duration));
      startOnAwake = serializedObject.FindProperty(nameof(startOnAwake));
      waypoints = serializedObject.FindProperty(nameof(waypoints));
      radius = serializedObject.FindProperty(nameof(radius));
      angle = serializedObject.FindProperty(nameof(angle));
    }

    public override void OnInspectorGUI()
    {
      serializedObject.Update();

      EditorGUILayout.PropertyField(type);
      EditorGUILayout.PropertyField(animationCurve);
      EditorGUILayout.PropertyField(startOnAwake);
      EditorGUILayout.PropertyField(duration);

      switch ((AutoMover.Type)type.enumValueIndex)
      {
        case AutoMover.Type.Straight:
        case AutoMover.Type.Repeat:
          EditorGUILayout.PropertyField(waypoints, true);
          break;

        case AutoMover.Type.CircleLoop:
          EditorGUILayout.PropertyField(radius);
          EditorGUILayout.PropertyField(angle);
          break;
      }

      serializedObject.ApplyModifiedProperties();
    }

    void OnSceneGUI()
    {
      var mover = (AutoMover)target;

      if (mover.type == AutoMover.Type.CircleLoop)
        return;

      serializedObject.Update();

      for (int i = 0; i < waypoints.arraySize; i++)
      {
        var posProp = waypoints.GetArrayElementAtIndex(i);

        EditorGUI.BeginChangeCheck();
        Vector3 worldPos =
            mover.transform.TransformPoint(posProp.vector3Value);

        Vector3 newPos = Handles.Slider2D(
            worldPos,
            Vector3.forward,   // plane normal
            Vector3.right,
            Vector3.up,
            0.35f,
            Handles.CircleHandleCap,
            0f
        );

        if (EditorGUI.EndChangeCheck())
        {
          Undo.RecordObject(target, "Move AutoMover Point");
          posProp.vector3Value =
              mover.transform.InverseTransformPoint(newPos);
        }
      }

      serializedObject.ApplyModifiedProperties();
    }
  }
}
