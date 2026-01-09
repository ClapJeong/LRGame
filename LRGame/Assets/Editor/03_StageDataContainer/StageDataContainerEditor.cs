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

      var chatCardEventList = serializedObject.FindProperty(nameof(chatCardEvents));
      chatCardEvents = new(
        serializedObject,
        chatCardEventList)
      {
        drawHeaderCallback = rect =>
        {
          GUI.Label(rect, "Chat Card Events");
        },

        elementHeightCallback = index =>
        {
          var element = chatCardEventList.GetArrayElementAtIndex(index);
          var eventTypeProp = element.FindPropertyRelative("eventType");

          float height = EditorGUIUtility.singleLineHeight + 6;

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

          return height + 6;
        },

        drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
        {
          var element = chatCardEventList.GetArrayElementAtIndex(index);

          rect.y += 2;
          rect.height = EditorGUIUtility.singleLineHeight;

          var idProp = element.FindPropertyRelative("id");
          var eventTypeProp = element.FindPropertyRelative("eventType");

          float half = rect.width * 0.5f;

          EditorGUI.PropertyField(
              new Rect(rect.x, rect.y, half - 4, rect.height),
              idProp,
              GUIContent.none
          );

          EditorGUI.PropertyField(
              new Rect(rect.x + half, rect.y, half, rect.height),
              eventTypeProp,
              GUIContent.none
          );

          rect.y += rect.height + 6;

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
            EditorGUI.PropertyField(
                rect,
                dataProp,
                includeChildren: true   // 🔥 핵심
            );
          }
        }
      };
      LoadAllDatas();
    }


    private void DrawStageEventData(
        Rect rect,
        SerializedProperty stageData,
        ref float height)
    {
      DrawBaseEventData(rect, stageData, ref height);

      rect.y += height;
      rect.height = EditorGUIUtility.singleLineHeight;

      EditorGUI.PropertyField(
          rect,
          stageData.FindPropertyRelative("stageEventType")
      );

      height += rect.height + 2;
    }

    private void DrawPlayerEventData(
        Rect rect,
        SerializedProperty playerData,
        ref float height)
    {
      DrawBaseEventData(rect, playerData, ref height);

      rect.y += height;
      rect.height = EditorGUIUtility.singleLineHeight;

      EditorGUI.PropertyField(
          rect,
          playerData.FindPropertyRelative("targetPlayerType")
      );
      height += rect.height + 2;

      rect.y += rect.height + 2;
      var playerEventType = playerData.FindPropertyRelative("playerEventType");
      EditorGUI.PropertyField(rect, playerEventType);
      height += rect.height + 2;

      rect.y += rect.height + 2;

      switch ((ChatCardEnum.PlayerEventType)playerEventType.enumValueIndex)
      {
        case ChatCardEnum.PlayerEventType.OnEnergyChanged:
          EditorGUI.PropertyField(
              rect,
              playerData.FindPropertyRelative("targetNormalizedValue")
          );
          height += rect.height + 2;
          break;

        case ChatCardEnum.PlayerEventType.OnStateChanged:
          EditorGUI.PropertyField(
              rect,
              playerData.FindPropertyRelative("targetPlayerState")
          );
          height += rect.height + 2;
          break;
      }
    }

    private void DrawTriggerEventData(
        Rect rect,
        SerializedProperty triggerData,
        ref float height)
    {
      DrawBaseEventData(rect, triggerData, ref height);

      rect.y += height;
      rect.height = EditorGUIUtility.singleLineHeight;

      EditorGUI.PropertyField(
          rect,
          triggerData.FindPropertyRelative("targetTriggerTileType")
      );
      height += rect.height + 2;

      rect.y += rect.height + 2;
      EditorGUI.PropertyField(
          rect,
          triggerData.FindPropertyRelative("triggerEventType")
      );
      height += rect.height + 2;
    }

    private void DrawSignalEventData(
        Rect rect,
        SerializedProperty signalData,
        ref float height)
    {
      DrawBaseEventData(rect, signalData, ref height);

      rect.y += height;
      rect.height = EditorGUIUtility.singleLineHeight;

      EditorGUI.PropertyField(
          rect,
          signalData.FindPropertyRelative("targetKey")
      );
      height += rect.height + 2;

      rect.y += rect.height + 2;
      EditorGUI.PropertyField(
          rect,
          signalData.FindPropertyRelative("signalEventType")
      );
      height += rect.height + 2;
    }

    private void DrawBaseEventData(
        Rect rect,
        SerializedProperty baseData,
        ref float height)
    {
      rect.y += height;
      rect.height = EditorGUIUtility.singleLineHeight;

      EditorGUI.PropertyField(rect, baseData.FindPropertyRelative("playOnce"));
      height += rect.height + 2;

      rect.y += rect.height + 2;
      EditorGUI.PropertyField(rect, baseData.FindPropertyRelative("delay"));
      height += rect.height + 4;
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
