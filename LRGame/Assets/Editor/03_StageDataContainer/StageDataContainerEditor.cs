using LR.Stage;
using LR.Stage.StageDataContainer;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace LR.Editor.StageDataContainer
{
  [CustomEditor(typeof(LR.Stage.StageDataContainer.StageDataContainer))]
  public class StageDataContainerEditor : UnityEditor.Editor
  {
    private const string FolderPath = "Assets/08_DialogueData/";
    private readonly List<string> dialogueDataNames = new();

    private SerializedProperty beforeDialogueIndex;
    private SerializedProperty afterDialogueIndex;

    private SerializedProperty cameraSize;

    private SerializedProperty leftPlayerBeginTransform;
    private SerializedProperty rightPlayerBeginTransform;

    private SerializedProperty staticObstacle;

    private SerializedProperty otherObjectsRoot;

    private SerializedProperty scoreData;

    private ReorderableList chatCardEvents;

    private void OnEnable()
    {
      beforeDialogueIndex = serializedObject.FindProperty(nameof(beforeDialogueIndex));
      afterDialogueIndex = serializedObject.FindProperty(nameof(afterDialogueIndex));

      cameraSize = serializedObject.FindProperty(nameof(cameraSize));

      leftPlayerBeginTransform = serializedObject.FindProperty(nameof(leftPlayerBeginTransform));
      rightPlayerBeginTransform = serializedObject.FindProperty(nameof(rightPlayerBeginTransform));

      staticObstacle = serializedObject.FindProperty(nameof(staticObstacle));

      otherObjectsRoot = serializedObject.FindProperty(nameof(otherObjectsRoot));
      scoreData = serializedObject.FindProperty(nameof(scoreData));
      var chatCardEventList = serializedObject.FindProperty(nameof(chatCardEvents));
      chatCardEvents = new(
        serializedObject,
        chatCardEventList)
      {
        drawHeaderCallback = rect =>
        {
          GUI.Label(rect, "Chat Card Events");
        },

        drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
        {
          var element = chatCardEventList.GetArrayElementAtIndex(index);

          float line = EditorGUIUtility.singleLineHeight;
          float space = 6f;

          float y = rect.y + 2;

          var idProp = element.FindPropertyRelative("id");
          var eventTypeProp = element.FindPropertyRelative("eventType");
          var playOnceProp = element.FindPropertyRelative("playOnce");
          var delayProp = element.FindPropertyRelative("delay");

          float half = rect.width * 0.5f;

          // ───── 1줄: id / eventType ─────
          EditorGUI.PropertyField(
              new Rect(rect.x, y, half - 4, line),
              idProp,
              GUIContent.none
          );

          EditorGUI.PropertyField(
              new Rect(rect.x + half, y, half, line),
              eventTypeProp,
              GUIContent.none
          );

          y += line + space;

          // ───── 2줄: playOnce / delay (라벨 + 필드) ─────
          float labelHeight = EditorGUIUtility.singleLineHeight;
          float fieldHeight = EditorGUIUtility.singleLineHeight;
          float spacing = 2f;

          float playOnceWidth = rect.width * 0.3f;
          float delayWidth = rect.width - playOnceWidth - 4;

          // 라벨 줄
          EditorGUI.LabelField(
              new Rect(rect.x, y, playOnceWidth, labelHeight),
              "Play Once"
          );

          EditorGUI.LabelField(
              new Rect(rect.x + playOnceWidth + 4, y, delayWidth, labelHeight),
              "Delay"
          );

          y += labelHeight + spacing;

          // 필드 줄
          EditorGUI.PropertyField(
              new Rect(rect.x, y, playOnceWidth, fieldHeight),
              playOnceProp,
              GUIContent.none
          );

          EditorGUI.PropertyField(
              new Rect(rect.x + playOnceWidth + 4, y, delayWidth, fieldHeight),
              delayProp,
              GUIContent.none
          );

          y += fieldHeight + 6;

          // ───── EventData ─────
          SerializedProperty dataProp = eventTypeProp.enumValueIndex switch
          {
            (int)ChatCardEnum.EventType.Stage => element.FindPropertyRelative("stageEventData"),
            (int)ChatCardEnum.EventType.Player => element.FindPropertyRelative("playerEventData"),
            (int)ChatCardEnum.EventType.Trigger => element.FindPropertyRelative("triggerTileEventData"),
            (int)ChatCardEnum.EventType.Signal => element.FindPropertyRelative("signalEventData"),
            _ => null
          };

          if (dataProp != null)
          {
            float dataHeight = EditorGUI.GetPropertyHeight(dataProp, true);

            EditorGUI.PropertyField(
                new Rect(rect.x, y, rect.width, dataHeight),
                dataProp,
                includeChildren: true
            );
          }
        },

        elementHeightCallback = index =>
        {
          var element = chatCardEventList.GetArrayElementAtIndex(index);
          var eventTypeProp = element.FindPropertyRelative("eventType");

          float height = 0f;
          float line = EditorGUIUtility.singleLineHeight;
          float space = 6f;

          // id / eventType
          height += line + space;

          // playOnce / delay (라벨 + 필드)
          height += (EditorGUIUtility.singleLineHeight * 2) + 6;


          SerializedProperty dataProp = eventTypeProp.enumValueIndex switch
          {
            (int)ChatCardEnum.EventType.Stage => element.FindPropertyRelative("stageEventData"),
            (int)ChatCardEnum.EventType.Player => element.FindPropertyRelative("playerEventData"),
            (int)ChatCardEnum.EventType.Trigger => element.FindPropertyRelative("triggerTileEventData"),
            (int)ChatCardEnum.EventType.Signal => element.FindPropertyRelative("signalEventData"),
            _ => null
          };

          if (dataProp != null)
            height += EditorGUI.GetPropertyHeight(dataProp, true);

          return height + 8;
        },
      };
      LoadAllDatas();
    }

    public override void OnInspectorGUI()
    {
      serializedObject.Update();

      var currentBeforeDialogueIndex = beforeDialogueIndex.intValue + 1;
      var beforeDialoguePopupIndex = EditorGUILayout.Popup("Before Dialogue Data", currentBeforeDialogueIndex, dialogueDataNames.ToArray());
      beforeDialogueIndex.intValue = beforeDialoguePopupIndex - 1;

      var currentAfterDialogueIndex = afterDialogueIndex.intValue + 1;
      var afterDialoguePopupIndex = EditorGUILayout.Popup("After Dialogue Data", currentAfterDialogueIndex, dialogueDataNames.ToArray());
      afterDialogueIndex.intValue = afterDialoguePopupIndex - 1;

      EditorGUILayout.Space(5);
      EditorGUILayout.PropertyField(cameraSize);
      EditorGUILayout.Space(5);
      EditorGUILayout.PropertyField(leftPlayerBeginTransform);
      EditorGUILayout.PropertyField(rightPlayerBeginTransform);
      EditorGUILayout.Space(5);
      EditorGUILayout.PropertyField(staticObstacle);
      EditorGUILayout.PropertyField(otherObjectsRoot);
      EditorGUILayout.Space(5);
      EditorGUILayout.PropertyField(scoreData);
      EditorGUILayout.Space(10);
      DrawChatCardEvents();
      serializedObject.ApplyModifiedProperties();
    }

    private void DrawChatCardEvents()
    {
      chatCardEvents.DoLayoutList();
    }

    private void LoadAllDatas()
    {
      dialogueDataNames.Clear();
      dialogueDataNames.Add("None");

      string[] guids = AssetDatabase.FindAssets("t:TextAsset", new[] { FolderPath });

      foreach (string guid in guids)
      {
        var path = AssetDatabase.GUIDToAssetPath(guid);
        var textAsset = AssetDatabase.LoadAssetAtPath<TextAsset>(path);

        if (textAsset == null)
          continue;

        var fileName = Path.GetFileNameWithoutExtension(path);
        dialogueDataNames.Add(fileName);
      }
    }
  }
}
