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
  private class RootData
  {
    public bool IsDirty { get; private set; } = false;

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
      => data;    

    public string FileName => $"{index}_{name}";

    public RootData(int index, string name,  bool isDirty)
    {
      this.index = index;
      this.name = name;
      this.data = new DialogueData(MarkDirty);
      this.IsDirty = isDirty;
    }

    public RootData(int index, string name, string json, bool isDirty)
    {
      this.index = index;
      this.name = name;
      this.data = JsonUtility.FromJson<DialogueData>(json);
      data.onDirty = MarkDirty;
      this.IsDirty = isDirty;
    }

    public void Reset()
    {
      name = NewDataSetName;
      data = new DialogueData(MarkDirty);
      IsDirty = true;
    }

    private void MarkDirty()
      => IsDirty = true;

    public void ClearDirty()
      => IsDirty = false;
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

  private readonly List<RootData> RootDatas = new();
  
  private ReorderableList rootReordableList;
  private RootData selectedRootData;
  private bool isFoldRootDataList = false;

  private ReorderableList turnDataReordableList;
  private DialogueData.TurnData selectedTurnData;

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
      elements: RootDatas,
      elementType: typeof(string),
      draggable: true,
      displayHeader: false,
      displayAddButton: true,
      displayRemoveButton: true);

    rootReordableList.drawElementCallback = (rect, i, _, __) =>
    {
      EditorGUI.LabelField(rect, RootDatas[i].FileName);
    };

    rootReordableList.onSelectCallback = OnRootDataSelected;

    rootReordableList.onReorderCallback = reordableList =>
    {
      ReorderRootDatas();
      foreach(var dataSet in RootDatas)
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

      var removeData = RootDatas[index];
      RootDatas.Remove(removeData);
      DeleteData(removeData);

      ReorderRootDatas();
      foreach (var dataSet in RootDatas)
        SaveData(dataSet);

      if (RootDatas.Count > index)
        selectedRootData = RootDatas[index];
      else if (RootDatas.Count > 0)
        selectedRootData = RootDatas.Last();

      CreateTurnDataReordableList(selectedRootData);
      Repaint();
    };
  }

  private void OnRootDataSelected(ReorderableList reordableList)
  {
    int index = reordableList.index;
    if (index < 0) return;

    var targetRootData = RootDatas[index];
    if (selectedRootData == targetRootData)
      return;

    if (selectedRootData != null)
      SaveData(selectedRootData);

    selectedRootData = targetRootData;
    CreateTurnDataReordableList(selectedRootData);

    Repaint();
  }

  private void ResetSelectedRootData()
  {
    selectedRootData.Reset();
    SaveData(selectedRootData);
  }

  private void CreateTurnDataReordableList(RootData rootDataSet)
  {
    turnDataReordableList = new(
      elements: rootDataSet.Data.TurnDatas,
      elementType: typeof(DialogueData.TurnData),
      draggable: true,
      displayHeader: true,
      displayAddButton: false,
      displayRemoveButton: false);

    turnDataReordableList.drawHeaderCallback = rect =>
    {
      EditorGUI.LabelField(rect, rootDataSet.FileName);
    };

    turnDataReordableList.drawElementCallback = (rect, i, _, __) =>
    {
      var targetDataSet = selectedRootData.Data.TurnDatas[i];
      EditorGUI.LabelField(rect, targetDataSet.FieldName);
    };

    turnDataReordableList.onSelectCallback = OnTurnDataSelected;

    turnDataReordableList.onReorderCallback = OnReorderTurnData;
  }

  private void OnTurnDataSelected(ReorderableList reordableList)
  {
    int index = reordableList.index;
    if (index < 0) return;

    var targetTurnData = selectedRootData.Data.TurnDatas[index];
    if (selectedTurnData == targetTurnData)
      return;

    if (selectedTurnData != null)
      SaveData(selectedRootData);

    selectedTurnData = targetTurnData;

    Repaint();
  }

  private void OnReorderTurnData(ReorderableList reordableList)
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
        turnDataReordableList.DoLayoutList();

        if(selectedTurnData != null)
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

        if (selectedRootData != null)
        {
          DrawResetButtons();

          DrawSaveButton();

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
      ResetSelectedRootData();
    }
  }

  private void DrawSaveButton()
  {
    if (GUILayout.Button("Save", IOButtonSize))
    {
      SaveData(selectedRootData);
    }
  }

  private void ReorderRootDatas()
  {
    for(int i = 0; i< RootDatas.Count; i++)
      RootDatas[i].Index = i;
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
      DrawAddTalkingButton();
      GUILayout.Space(15.0f);
      DrawAddSelectionButton();
      GUILayout.FlexibleSpace();
    }
  }

  private void DrawAddTalkingButton()
  {
    if(GUILayout.Button("+ Talking", AddButtonSisze))
    {
      selectedRootData.Data.AddTurnData(DialogueData.TurnData.Type.Talking);
      CreateTurnDataReordableList(selectedRootData);
      Repaint();
      SaveData(selectedRootData);
    }
  }

  private void DrawAddSelectionButton()
  {
    if (GUILayout.Button("+ Selection", AddButtonSisze))
    {
      selectedRootData.Data.AddTurnData(DialogueData.TurnData.Type.Selection);
      CreateTurnDataReordableList(selectedRootData);
      Repaint();
      SaveData(selectedRootData);
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

      var dataSet = new RootData(headNumber, subName, textAsset.text, false);
      dataSet.guid = guid;
      RootDatas.Add(dataSet);
    }
  }

  private void CreateData()
  {
    var newDataSet = new RootData(RootDatas.Count, NewDataSetName, true);
    RootDatas.Add(newDataSet);
    SaveData(newDataSet);
    Repaint();
  }

  private void SaveData(RootData dataSet)
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

  private void DeleteData(RootData dataSet)
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