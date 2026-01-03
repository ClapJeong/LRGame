using System;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ChatCardDatasSO))]
public class ChatCardDataSOEditor : Editor
{
  private const float TypeLabelWidth = 80.0f;
  private const float PortraitPopupWidth = 80.0f;

  private ChatCardDatasSO so;

  private void OnEnable()
  {
    so = target as ChatCardDatasSO;
    UpdateDictionary();
  }

  private void UpdateDictionary()
  {
    foreach(var value in Enum.GetValues(typeof(ChatCardType)))
    {
      var type = (ChatCardType)value;
      if (so.datas.ContainsKey(type) == false)
        so.datas[type] = new();
    }
  }

  public override void OnInspectorGUI()
  {
    foreach (var value in Enum.GetValues(typeof(ChatCardType)))
    {
      var type = (ChatCardType)value;
      DrawChatCardData(type, so.datas[type]);
      EditorGUILayout.Space(10.0f);
    }
  }

  private void DrawChatCardData(ChatCardType type, ChatCardData data)
  {
    using (new GUILayout.HorizontalScope(GUI.skin.box))
    {
      EditorGUILayout.LabelField(type.ToString(), GUILayout.Width(TypeLabelWidth));
      GUILayout.FlexibleSpace();
      data.portraitType = (ChatCardPortraitType)EditorGUILayout.EnumPopup(data.portraitType, GUILayout.Width(PortraitPopupWidth));
      GUILayout.FlexibleSpace();
      data.key = EditorGUILayout.TextField(data.key);
    }
  }
}
