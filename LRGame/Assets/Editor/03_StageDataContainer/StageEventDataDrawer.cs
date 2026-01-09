using LR.Stage.StageDataContainer;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace LR.Editor.StageDataContainer
{
  [CustomPropertyDrawer(typeof(StageEventData))]
  public class StageEventDataDrawer : PropertyDrawer
  {
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
      float height = 0f;

      height += EditorGUIUtility.singleLineHeight; // stageEventType

      var stageEventType = property.FindPropertyRelative("stageEventType");
      switch ((ChatCardEnum.StageEventType)stageEventType.enumValueIndex)
      {
        case ChatCardEnum.StageEventType.OnAfterBeginTime:
          height += EditorGUIUtility.singleLineHeight;
          break;
      }

      return height + 8;
    }

    public override void OnGUI(Rect rect, SerializedProperty property, GUIContent label)
    {
      rect.height = EditorGUIUtility.singleLineHeight;

      var eventTypeProp = property.FindPropertyRelative("stageEventType");
      EditorGUI.PropertyField(rect, eventTypeProp);
      rect.y += rect.height + 2;

      switch ((ChatCardEnum.StageEventType)eventTypeProp.enumValueIndex)
      {
        case ChatCardEnum.StageEventType.OnAfterBeginTime:
          EditorGUI.PropertyField(
              rect,
              property.FindPropertyRelative("time")
          );
          break;
      }
    }
  }
}
