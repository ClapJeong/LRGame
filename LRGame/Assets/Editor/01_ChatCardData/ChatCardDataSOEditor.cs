using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ChatCardDatasSO))]
public class ChatCardDatasSOEditor : Editor
{
  private const float TypeLabelWidth = 90f;
  private const float PortraitPopupWidth = 100f;

  private SerializedProperty durationProp;
  private SerializedProperty datasProp;

  private void OnEnable()
  {
    durationProp = serializedObject.FindProperty("Duration");
    datasProp = serializedObject.FindProperty("datas");

    SyncEnumEntries();
  }

  public override void OnInspectorGUI()
  {
    serializedObject.Update();

    DrawDuration();
    EditorGUILayout.Space(10f);

    DrawDatas();

    serializedObject.ApplyModifiedProperties();
  }

  private void DrawDuration()
  {
    EditorGUILayout.PropertyField(durationProp);
  }

  private void DrawDatas()
  {
    for (int i = 0; i < datasProp.arraySize; i++)
    {
      var element = datasProp.GetArrayElementAtIndex(i);

      var typeProp = element.FindPropertyRelative("type");
      var portraitProp = element.FindPropertyRelative("portraitType");
      var keyProp = element.FindPropertyRelative("key");

      using (new GUILayout.HorizontalScope(GUI.skin.box))
      {
        EditorGUILayout.LabelField(
            typeProp.enumDisplayNames[typeProp.enumValueIndex],
            GUILayout.Width(TypeLabelWidth)
        );

        GUILayout.FlexibleSpace();

        EditorGUILayout.PropertyField(
            portraitProp,
            GUIContent.none,
            GUILayout.Width(PortraitPopupWidth)
        );

        GUILayout.FlexibleSpace();

        EditorGUILayout.PropertyField(keyProp, GUIContent.none);
      }
    }
  }

  private void SyncEnumEntries()
  {
    serializedObject.Update();

    var so = (ChatCardDatasSO)target;

    foreach (ChatCardType type in Enum.GetValues(typeof(ChatCardType)))
    {
      bool exists = so.datas.Any(d => d.type == type);
      if (exists)
        continue;

      Undo.RecordObject(so, "Add ChatCardData");

      so.datas.Add(new ChatCardData(type));
      EditorUtility.SetDirty(so);
    }

    serializedObject.ApplyModifiedProperties();
  }
}
