using LR.Table.Dialogue;
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
    public bool IsDirty { get; private set; } = true;

    public string guid;

    private int index;
    public int Index
    {
      get { return index; }
      set
      {
        if(index != value)
          IsDirty = true;

        index = value;        
      }
    }

    private string name;
    public string Name
    {
      get { return name; }
      set
      {
        if (name != value)
          IsDirty = true;

        name = value;
      }
    }

    private DialogueData data;
    public DialogueData Data
    {
      get { return data; }
      set
      {
        if (data != value)
          IsDirty = true;

        data = value;
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
  private const string DataSubNameTextField = "DataSubName";

  private readonly List<DataSet> dataSets = new();

  private DataSet selectedDataSet;
  private ReorderableList dialogueDataList;
  private bool isFoldDataList = false;
  private bool wasFocused;

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
    dialogueDataList = new ReorderableList(
      elements: dataSets,
      elementType: typeof(string),
      draggable: true,
      displayHeader: false,
      displayAddButton: true,
      displayRemoveButton: true);

    dialogueDataList.drawElementCallback = (rect, i, _, __) =>
    {
      EditorGUI.LabelField(rect, dataSets[i].FileName);
    };

    dialogueDataList.onSelectCallback = reordableList =>
    {
      int index = reordableList.index;
      if (index < 0) return;

      var targetDataSet = dataSets[index];
      if(selectedDataSet == targetDataSet) 
        return;

      if (selectedDataSet != null)
        SaveData(selectedDataSet);

      selectedDataSet = targetDataSet;

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
      dataSets.Remove(removeData);
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
    var rectSpace = new Vector2(20.0f, 20.0f);
    var rectWidth = position.width - rectSpace.x * 2.0f;
    var rectHeight = 40.0f + (isFoldDataList ? dialogueDataList.GetHeight() : 0.0f);
    var areaRect = new Rect(rectSpace.x, rectSpace.y, rectWidth, rectHeight);
    using (new GUILayout.AreaScope(areaRect, GUIContent.none, GUI.skin.box))
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
    SaveData(selectedDataSet);
  }

  private void ReorderDataSets()
  {
    for(int i = 0; i< dataSets.Count; i++)
      dataSets[i].Index = i;
  }

  private void CreateSelectedDataNameArea()
  {
    EditorGUILayout.LabelField($"{ParseToHeadNumber(selectedDataSet.Index)}_", GUILayout.Width(30.0f));
    GUI.SetNextControlName(DataSubNameTextField);
    selectedDataSet.Name = EditorGUILayout.TextField(selectedDataSet.Name, GUILayout.Width(150.0f));
    var isFocused = GUI.GetNameOfFocusedControl() == DataSubNameTextField;

    Event e = Event.current;
    if (wasFocused &&
        e.type == EventType.KeyUp && e.keyCode == KeyCode.Return)
    {
      SaveData(selectedDataSet);
      GUI.FocusControl(null);
      e.Use();
    }
    if (wasFocused && !isFocused)
    {
      SaveData(selectedDataSet);
    }

    wasFocused = isFocused;
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

      var fileName = Path.GetFileNameWithoutExtension(path);
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
    Repaint();
  }

  private void SaveData(DataSet dataSet)
  {
    if (dataSet.IsDirty == false)
      return;

    DeleteData(dataSet);

    var filePath = string.Format(FileNameFormat, ParseToHeadNumber(dataSet.Index), dataSet.Name);
    var newPath = Path.Combine(FolderPath, filePath);
    var json = JsonUtility.ToJson(dataSet.Data);
    File.WriteAllText(newPath, json);
    AssetDatabase.Refresh();

    dataSet.guid = AssetDatabase.AssetPathToGUID(newPath);
    dataSet.ClearDirty();
  }

  private void DeleteData(DataSet dataSet)
  {
    var path = AssetDatabase.GUIDToAssetPath(dataSet.guid);
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