using LR.Stage;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace LR.Editor
{
  [CustomEditor(typeof(StageDataContainer))]
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
    

    private void OnEnable()
    {
      beforeDialogueIndex = serializedObject.FindProperty(nameof(beforeDialogueIndex));
      afterDialogueIndex = serializedObject.FindProperty(nameof(afterDialogueIndex));

      cameraSize = serializedObject.FindProperty(nameof(cameraSize));

      leftPlayerBeginTransform = serializedObject.FindProperty(nameof(leftPlayerBeginTransform));
      rightPlayerBeginTransform = serializedObject.FindProperty(nameof(rightPlayerBeginTransform));

      staticObstacle = serializedObject.FindProperty(nameof(staticObstacle));

      otherObjectsRoot = serializedObject.FindProperty(nameof(otherObjectsRoot));

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

      serializedObject.ApplyModifiedProperties();
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
