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
  private class RootDataSet
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

    public RootDataSet(int index, string name, DialogueData data)
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

  private static readonly GUILayoutOption[] IOButtonSize = new[]
  {
    GUILayout.Width(80.0f),
    GUILayout.Height(20.0f),
  };
  private static readonly GUILayoutOption[] AddButtonSisze = new[]
  {
    GUILayout.Width(120.0f),
    GUILayout.Height(30.0f),
  };

  private readonly List<RootDataSet> RootDataSets = new();
  
  private ReorderableList rootReordableList;
  private RootDataSet selectedRootData;
  private bool isFoldRootDataList = false;

  private ReorderableList dataSetReordableList;
  private DialogueData.DataSet selectedDataSet;

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
    CreateRootReordableList();
  }

  private void CreateRootReordableList()
  {
    rootReordableList = new ReorderableList(
      elements: RootDataSets,
      elementType: typeof(string),
      draggable: true,
      displayHeader: false,
      displayAddButton: true,
      displayRemoveButton: true);

    rootReordableList.drawElementCallback = (rect, i, _, __) =>
    {
      EditorGUI.LabelField(rect, RootDataSets[i].FileName);
    };

    rootReordableList.onSelectCallback = OnRootDataSelected;

    rootReordableList.onReorderCallback = reordableList =>
    {
      ReorderDataSets();
      foreach(var dataSet in RootDataSets)
        SaveData(dataSet);

      Repaint();
    };

    rootReordableList.onAddDropdownCallback = (buttonRect, reordableList) =>
    {
      CreateData();
    };

    rootReordableList.onRemoveCallback = reoredableList =>
    {
      var index = reoredableList.index;
      if (index < 0) return;

      var removeData = RootDataSets[index];
      RootDataSets.Remove(removeData);
      DeleteData(removeData);

      ReorderDataSets();
      foreach (var dataSet in RootDataSets)
        SaveData(dataSet);

      if (RootDataSets.Count > index)
        selectedRootData = RootDataSets[index];
      else if (RootDataSets.Count > 0)
        selectedRootData = RootDataSets.Last();

      CreateDataSetReordableList(selectedRootData);
      Repaint();
    };
  }

  private void OnRootDataSelected(ReorderableList reordableList)
  {
    int index = reordableList.index;
    if (index < 0) return;

    var targetRootData = RootDataSets[index];
    if (selectedRootData == targetRootData)
      return;

    if (selectedRootData != null)
      SaveData(selectedRootData);

    selectedRootData = targetRootData;
    CreateDataSetReordableList(selectedRootData);

    Repaint();
  }

  private void ResetSelectedData()
  {
    selectedRootData.Reset();
    SaveData(selectedRootData);
  }

  private void CreateDataSetReordableList(RootDataSet rootDataSet)
  {
    dataSetReordableList = new(
      elements: rootDataSet.Data.datasets,
      elementType: typeof(DialogueData.DataSet),
      draggable: true,
      displayHeader: true,
      displayAddButton: false,
      displayRemoveButton: false);

    dataSetReordableList.drawHeaderCallback = rect =>
    {
      EditorGUI.LabelField(rect, rootDataSet.FileName);
    };

    dataSetReordableList.drawElementCallback = (rect, i, _, __) =>
    {
      var targetDataSet = selectedRootData.Data.datasets[i];
      EditorGUI.LabelField(rect, targetDataSet.FieldName);
    };

    dataSetReordableList.onSelectCallback = OnDataSetSelected;

    dataSetReordableList.onReorderCallback = OnReorderDataSet;
  }

  private void OnDataSetSelected(ReorderableList reordableList)
  {
    int index = reordableList.index;
    if (index < 0) return;

    var targetDataSet = selectedRootData.Data.datasets[index];
    if (selectedDataSet == targetDataSet)
      return;

    if (selectedDataSet != null)
      SaveData(selectedRootData);

    selectedDataSet = targetDataSet;

    Repaint();
  }

  private void OnReorderDataSet(ReorderableList reordableList)
  {
    SaveData(selectedRootData);
    Repaint();
  }

  private void OnGUI()
  {
    using (new EditorGUILayout.VerticalScope())
    {
      DrawRootDataArea();

      if (selectedRootData != null)
      {
        dataSetReordableList.DoLayoutList();

        if(selectedDataSet != null)
        {
          GUILayout.Space(15.0f);
          DrawDialogueConditionArea();

          GUILayout.Space(15.0f);
          DrawDataSetArea();
        }

        GUILayout.Space(15.0f);
        DrawAddDataButtons();
      }
    }      
  }

  private void DrawRootDataArea()
  {
    var rectSpace = new Vector2(20.0f, 20.0f);
    var rectWidth = position.width - rectSpace.x * 2.0f;
    var rectHeight = 40.0f + (isFoldRootDataList ? rootReordableList.GetHeight() : 0.0f);
    var areaRect = new Rect(rectSpace.x, rectSpace.y, rectWidth, rectHeight);
    using (new GUILayout.AreaScope(areaRect, GUIContent.none, GUI.skin.box))
    {
      using (new EditorGUILayout.HorizontalScope())
      {
        isFoldRootDataList = EditorGUILayout.Foldout(isFoldRootDataList, "Dialogue Datas", true);
        GUILayout.Space(80.0f);

        DrawResetButtons();

        DrawSaveButton();

        if (selectedRootData != null)
        {
          GUILayout.Space(10.0f);

          DrawSelectedDataNameArea();
        }
      }

      if (isFoldRootDataList)
      {
        GUILayout.Space(15.0f);
        rootReordableList.DoLayoutList();
      }
    }

    if (selectedRootData != null)
      GUILayout.Space(rectSpace.y + rectHeight + 15.0f);
  }

  private void DrawResetButtons()
  {
    if (GUILayout.Button("Reset", IOButtonSize))
    {
      ResetSelectedData();
    }
  }

  private void DrawSaveButton()
  {
    if (GUILayout.Button("Save", IOButtonSize))
    {
      SaveData(selectedRootData);
    }
  }

  private void ReorderDataSets()
  {
    for(int i = 0; i< RootDataSets.Count; i++)
      RootDataSets[i].Index = i;
  }

  private void DrawSelectedDataNameArea()
  {
    EditorGUILayout.LabelField($"{ParseToHeadNumber(selectedRootData.Index)}_", GUILayout.Width(30.0f));
    GUI.SetNextControlName(DataSubNameTextField);
    selectedRootData.Name = EditorGUILayout.TextField(selectedRootData.Name, GUILayout.Width(150.0f));
    var isFocused = GUI.GetNameOfFocusedControl() == DataSubNameTextField;

    Event e = Event.current;
    if (wasFocused && IsTextFieldEnterPressed(e))
    {
      SaveData(selectedRootData);
      GUI.FocusControl(null);
      e.Use();
    }

    if (wasFocused && !isFocused)
    {
      SaveData(selectedRootData);
    }

    wasFocused = isFocused;
    GUILayout.FlexibleSpace();
  }

  private bool IsTextFieldEnterPressed(Event e)
    => e.type == EventType.KeyUp && e.keyCode == KeyCode.Return;

  private void DrawAddDataButtons()
  {
    using (new EditorGUILayout.HorizontalScope())
    {
      GUILayout.FlexibleSpace();
      DrawAddCharacterDataButton();
      GUILayout.Space(15.0f);
      DrawAddSelectionDataButton();
      GUILayout.FlexibleSpace();
    }
  }

  private void DrawAddCharacterDataButton()
  {
    if(GUILayout.Button("+ Dialogue", AddButtonSisze))
    {
      selectedRootData.Data.datasets.Add(new DialogueData.DataSet(new DialogueTurnData()));
    }
  }

  private void DrawAddSelectionDataButton()
  {
    if (GUILayout.Button("+ Selection", AddButtonSisze))
    {
      selectedRootData.Data.datasets.Add(new DialogueData.DataSet(new DialogueSelectionData()));
    }
  }

  private void DrawDataSetArea()
  {

  }

  private void DrawDialogueConditionArea()
  {

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

      var dataSet = new RootDataSet(headNumber, subName, data);
      dataSet.guid = guid;
      RootDataSets.Add(dataSet);
    }
  }

  private void CreateData()
  {
    var newDataSet = new RootDataSet(RootDataSets.Count, NewDataSetName, new DialogueData());
    RootDataSets.Add(newDataSet);
    SaveData(newDataSet);
    Repaint();
  }

  private void SaveData(RootDataSet dataSet)
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

  private void DeleteData(RootDataSet dataSet)
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