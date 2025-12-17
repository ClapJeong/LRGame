using LR.Table.Dialogue;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

public class DialogueEditorWindow : EditorWindow
{
  [System.Serializable]
  private class DataSet
  {
    public bool IsDirty { get; private set; }

    public string guid;

    private int index;
    public int Index
    {
      get { return index; }
      set
      {
        index = value;
        IsDirty = true;
      }
    }

    private string name;
    public string Name
    {
      get { return name; }
      set
      {
        name = value;
        IsDirty = true;
      }
    }

    private DialogueData data;
    public DialogueData Data
    {
      get { return data; }
      set
      {
        data = value;
        IsDirty = true;
      }
    }

    public string FileName => $"{index}_{name}";

    public DataSet(int index, string name, DialogueData data)
    {
      this.index = index;
      this.name = name;
      this.data = data;
    }

    public void Reset()
    {
      name = NewDataSetName;
      data = new DialogueData();
      IsDirty = true;
    }

    public void ClearDirty()
    {
      IsDirty = false;
    }
  }

  private const string FolderPath = "Assets/08_DialogueData/";
  private const string FileNameFormat = "{0}_{1}.json";
  private const string NewDataSetName = "newName";

  private readonly List<DataSet> dataSets = new();

  private DataSet selectedDataSet;
  private ReorderableList dialogueDataList;
  private bool isFoldDataList = false;

  [MenuItem("Editor Window/Dialogue Editor")]
  public static void OpenWindow()
  {
    EditorWindow wnd = GetWindow<DialogueEditorWindow>();
    wnd.titleContent = new GUIContent(nameof(DialogueEditorWindow));
  }

  private void CreateGUI()
  {
    LoadAllDatas();
    CreateDataList();
  }

  private void CreateDataList()
  {
    dialogueDataList = new ReorderableList(dataSets, typeof(string), true, true, true, true);

    dialogueDataList.drawElementCallback = (rect, i, _, __) =>
    {
      EditorGUI.LabelField(rect, dataSets[i].FileName);
    };

    dialogueDataList.onSelectCallback = reordableList =>
    {
      int index = reordableList.index;
      if (index < 0) return;

      if (selectedDataSet != null)
        SaveData(selectedDataSet);

      selectedDataSet = dataSets[index];
      Repaint();      
    };

    dialogueDataList.onReorderCallback = reordableList =>
    {
      ReorderDataSets();
      foreach(var dataSet in dataSets)
        SaveData(dataSet);
      Repaint();
    };

    dialogueDataList.onAddDropdownCallback = (buttonRect, reordableList) =>
    {
      CreateData();
    };

    dialogueDataList.onRemoveCallback = reoredableList =>
    {
      var index = reoredableList.index;
      if (index < 0) return;

      var removeData = dataSets[index];
      dataSets.RemoveAt(index);
      DeleteData(removeData);

      ReorderDataSets();
      foreach (var dataSet in dataSets)
        SaveData(dataSet);

      if (dataSets.Count > index)
        selectedDataSet = dataSets[index];
      else if (dataSets.Count > 0)
        selectedDataSet = dataSets.Last();

      Repaint();
    };
  }

  private void OnGUI()
  {
    CreateDialogueDataArea();
  }

  private void CreateDialogueDataArea()
  {
    var rect = new Rect(20.0f, 20.0f, position.width - 40.0f, 150.0f);
    using (new GUILayout.AreaScope(rect, GUIContent.none, GUI.skin.box))
    {
      using (new EditorGUILayout.VerticalScope())
      {
        using (new EditorGUILayout.HorizontalScope())
        {
          isFoldDataList = EditorGUILayout.Foldout(isFoldDataList, "Dialogue Datas", true);
          GUILayout.Space(80.0f);

          if (selectedDataSet != null)
          {
            var width = GUILayout.Width(80.0f);
            var height = GUILayout.Height(20.0f);

            if (GUILayout.Button("Reset", width, height))
            {
              ResetSelectedData();
            }

            if (GUILayout.Button("Save", width, height))
            {
              SaveData(selectedDataSet);
            }
            GUILayout.Space(10.0f);
            CreateSelectedDataNameArea();
          }
        }

        GUILayout.Space(15.0f);

        if (isFoldDataList)
        {
          dialogueDataList.DoLayoutList();
        }
      }
    }
  }

  private void ResetSelectedData()
  {
    selectedDataSet.Reset();    
  }

  private void ReorderDataSets()
  {
    for(int i = 0; i< dataSets.Count; i++)
      dataSets[i].Index = i;

    EditorUtility.SetDirty(this);    
  }

  private void CreateSelectedDataNameArea()
  {
    EditorGUILayout.LabelField($"{ParseToHeadNumber(selectedDataSet.Index)}_", GUILayout.Width(30.0f));    
    selectedDataSet.Name = EditorGUILayout.TextField(selectedDataSet.Name, GUILayout.Width(150.0f));
    GUILayout.FlexibleSpace();
  }

  #region Save&Load
  private void LoadAllDatas()
  {
    string[] guids = AssetDatabase.FindAssets("t:TextAsset", new[] { FolderPath });

    foreach (string guid in guids)
    {
      var path = AssetDatabase.GUIDToAssetPath(guid);
      var textAsset = AssetDatabase.LoadAssetAtPath<TextAsset>(path);

      if (textAsset == null)
        continue;

      var fileName = System.IO.Path.GetFileNameWithoutExtension(path);
      var parts = fileName.Split('_');

      var headNumber = int.Parse(parts[0]);
      var subName = parts[1];

      var data = JsonUtility.FromJson<DialogueData>(textAsset.text);

      var dataSet = new DataSet(headNumber, subName, data);
      dataSet.guid = guid;
      dataSets.Add(dataSet);
    }
  }

  private void CreateData()
  {
    var newDataSet = new DataSet(dataSets.Count, NewDataSetName, new DialogueData());
    dataSets.Add(newDataSet);
    SaveData(newDataSet);
    AssetDatabase.Refresh();
    Repaint();
  }

  private void SaveData(DataSet dataSet)
  {
    if (dataSet.IsDirty == false)
      return;

    DeleteData(dataSet);

    var newPath = Path.Combine(FolderPath, string.Format(FileNameFormat, ParseToHeadNumber(dataSet.Index), dataSet.Name));
    var json = JsonUtility.ToJson(dataSet.Data);
    File.WriteAllText(newPath, json);

    dataSet.guid = AssetDatabase.AssetPathToGUID(newPath);

    hasUnsavedChanges = false;
    dataSet.ClearDirty();
    EditorUtility.ClearDirty(this);
    AssetDatabase.Refresh();
  }

  private void DeleteData(DataSet dataSet)
  {
    var path = AssetDatabase.GUIDToAssetPath(dataSet.guid);
    if (AssetDatabase.AssetPathExists(path))
      AssetDatabase.DeleteAsset(path);
  }
  #endregion

  private static string ParseToHeadNumber(int headNumber)
  {
    if (headNumber > 9)
      return headNumber.ToString();
    else
      return $"0{headNumber}";
  }
}