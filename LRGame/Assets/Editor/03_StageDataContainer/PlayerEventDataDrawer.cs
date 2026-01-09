using LR.Stage.StageDataContainer;
using UnityEditor;
using UnityEngine;

namespace LR.Editor.StageDataContainer
{
  [CustomPropertyDrawer(typeof(PlayerEventData))]
  public class PlayerEventDataDrawer : PropertyDrawer
  {
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
      float height = 0f;

      height += EditorGUIUtility.singleLineHeight; // playOnce
      height += EditorGUIUtility.singleLineHeight; // delay
      height += EditorGUIUtility.singleLineHeight; // targetPlayerType
      height += EditorGUIUtility.singleLineHeight; // playerEventType

      var eventType = property.FindPropertyRelative("playerEventType");

      switch ((ChatCardEnum.PlayerEventType)eventType.enumValueIndex)
      {
        case ChatCardEnum.PlayerEventType.OnEnergyChanged:
          height += EditorGUIUtility.singleLineHeight;
          break;

        case ChatCardEnum.PlayerEventType.OnStateChanged:
          height += EditorGUIUtility.singleLineHeight;
          break;
      }

      return height + 8;
    }

    public override void OnGUI(Rect rect, SerializedProperty property, GUIContent label)
    {
      rect.height = EditorGUIUtility.singleLineHeight;

      EditorGUI.PropertyField(rect, property.FindPropertyRelative("playOnce"));
      rect.y += rect.height + 2;

      EditorGUI.PropertyField(rect, property.FindPropertyRelative("delay"));
      rect.y += rect.height + 2;

      EditorGUI.PropertyField(rect, property.FindPropertyRelative("targetPlayerType"));
      rect.y += rect.height + 2;

      var eventTypeProp = property.FindPropertyRelative("playerEventType");
      EditorGUI.PropertyField(rect, eventTypeProp);
      rect.y += rect.height + 2;

      switch ((ChatCardEnum.PlayerEventType)eventTypeProp.enumValueIndex)
      {
        case ChatCardEnum.PlayerEventType.OnEnergyChanged:
          EditorGUI.PropertyField(
              rect,
              property.FindPropertyRelative("targetNormalizedValue")
          );
          break;

        case ChatCardEnum.PlayerEventType.OnStateChanged:
          EditorGUI.PropertyField(
              rect,
              property.FindPropertyRelative("targetPlayerState")
          );
          break;
      }
    }
  }
}