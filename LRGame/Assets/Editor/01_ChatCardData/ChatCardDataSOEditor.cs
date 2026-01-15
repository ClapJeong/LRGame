using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace LR.EditorP
{
  [CustomEditor(typeof(ChatCardDatasSO))]
  public class ChatCardDatasSOEditor : UnityEditor.Editor
  {
    private const string PortraitPath = "Assets/01_Art/00_Sprites/01_ChatPortrait/";
    private const float TypeLabelWidth = 90f;
    private const float PortraitSize = 100f;

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

        var id = element.FindPropertyRelative("id");
        var portraitType = element.FindPropertyRelative("portraitType");
        var localizeKey = element.FindPropertyRelative("localizeKey");

        using (new GUILayout.HorizontalScope(GUI.skin.box))
        {
          EditorGUILayout.LabelField(
              id.enumDisplayNames[id.enumValueIndex],
              GUILayout.Width(TypeLabelWidth)
          );

          GUILayout.FlexibleSpace();

          using (new GUILayout.VerticalScope())
          {
            var portraitAssetName = ((ChatCardEnum.PortraitType)portraitType.enumValueIndex).ToString();
            var portraitAssetPath = PortraitPath + portraitAssetName + ".png";
            var texture = AssetDatabase.AssetPathExists(portraitAssetPath) ? AssetDatabase.LoadAssetAtPath<Texture2D>(portraitAssetPath)
                                                                           : null;
            var rect = GUILayoutUtility.GetRect(PortraitSize, PortraitSize);
            GUI.DrawTexture(rect, texture, ScaleMode.ScaleToFit);

            EditorGUILayout.PropertyField(
              portraitType,
              GUIContent.none,
              GUILayout.Width(PortraitSize));
          }

          GUILayout.FlexibleSpace();

          EditorGUILayout.PropertyField(localizeKey, GUIContent.none);
        }
      }
    }

    private void SyncEnumEntries()
    {
      serializedObject.Update();

      var so = (ChatCardDatasSO)target;

      foreach (ChatCardEnum.ID type in System.Enum.GetValues(typeof(ChatCardEnum.ID)))
      {
        bool exists = so.datas.Any(d => d.id == type);
        if (exists)
          continue;

        Undo.RecordObject(so, "Add ChatCardData");

        so.datas.Add(new ChatCardData(type));
        EditorUtility.SetDirty(so);
      }

      serializedObject.ApplyModifiedProperties();
    }
  }
}