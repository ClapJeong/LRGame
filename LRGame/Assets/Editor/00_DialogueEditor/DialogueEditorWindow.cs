using LR.Table.Dialogue;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

    public RootData(int index, string name, bool isDirty)
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
      this.IsDirty = isDirty;
      data.SetOnDirty(MarkDirty);      
    }

    public void Reset()
    {
      name = NewDataSetName;
      data = new DialogueData(MarkDirty);
      IsDirty = true;
    }

    public void OnSequenceSetRemoved()
      => MarkDirty();

    private void MarkDirty()
      => IsDirty = true;

    public void ClearDirty()
      => IsDirty = false;
  }

  private const string FolderPath = "Assets/08_DialogueData/";
  private const string FileNameFormat = "{0}_{1}.json";
  private const string NewDataSetName = "newName";
  private const string DataSubNameTextField = "DataSubName";

  #region Static
  private static readonly GUILayoutOption[] IOButtonSize = new[]
  {
    GUILayout.Width(80.0f),
    GUILayout.Height(20.0f),
  };
  private static readonly GUILayoutOption[] AddButtonSize = new[]
  {
    GUILayout.Width(120.0f),
    GUILayout.Height(30.0f),
  };
  private static readonly GUILayoutOption[] OperationButtonSize = new[]
  {
    GUILayout.Width(20.0f),
    GUILayout.Height(20.0f),
  };
  private GUIStyle IntCenterStyle;
  private GUIStyle IntLeftStyle;
  private GUIStyle IntRightStyle;
  private GUIStyle StringCenterStyle;
  private GUIStyle StringLeftStyle;
  private GUIStyle StringRightStyle;
  #endregion
  private readonly List<RootData> RootDatas = new();
  
  private ReorderableList rootReordableList;
  private RootData selectedRootData;
  private bool isFoldRootDataList = false;

  private ReorderableList sequenceSetDataReordableList;
  private DialogueData.SequenceSet selectedSequenceSet;

  private DialogueSequenceBase selectedSequence;

  private List<DialogueSelectionData> availableSelections = new();
  private List<string> availableSelectionNames = new();

  private bool wasFocused;
  private Vector2 scrollPos;

  [MenuItem("Editor Window/Dialogue Editor")]
  public static void OpenWindow()
  {
  EditorWindow wnd = GetWindow<DialogueEditorWindow>();
    wnd.titleContent = new GUIContent(nameof(DialogueEditorWindow));
  }

  private void OnEnable()
  {
    IntCenterStyle = new(EditorStyles.numberField)
    {
      alignment = TextAnchor.MiddleCenter
    };
    IntLeftStyle = new(EditorStyles.numberField)
    {
      alignment = TextAnchor.UpperLeft
    };
    IntRightStyle = new(EditorStyles.numberField)
    {
      alignment = TextAnchor.UpperRight
    };
    StringCenterStyle = new(EditorStyles.textField)
    {
      alignment = TextAnchor.MiddleCenter
    };
    StringLeftStyle = new(EditorStyles.textField)
    {
      alignment = TextAnchor.UpperLeft
    };
    StringRightStyle = new(EditorStyles.textField)
    {
      alignment = TextAnchor.UpperRight
    };
  }
  private void CreateGUI()
  {
    LoadAllDatas();
    CreateRootReordableList();
  }

  #region RootDataList
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

      CreateSequenceSetReordableList(selectedRootData);
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
    CreateSequenceSetReordableList(selectedRootData);
    SelectSequenceSet(null);

    Repaint();
  }

  private void ResetSelectedRootData()
  {
    selectedRootData.Reset();
    SaveData(selectedRootData);
  }

  private void ReorderRootDatas()
  {
    for (int i = 0; i < RootDatas.Count; i++)
      RootDatas[i].Index = i;
  }
  #endregion

  #region SequenceSet
  private void CreateSequenceSetReordableList(RootData rootDataSet)
  {
    sequenceSetDataReordableList = new(
      elements: rootDataSet.Data.SequenceSets,
      elementType: typeof(DialogueData.SequenceSet),
      draggable: true,
      displayHeader: true,
      displayAddButton: false,
      displayRemoveButton: true);

    sequenceSetDataReordableList.drawHeaderCallback = rect =>
    {
      EditorGUI.LabelField(rect,$"[ Sequence Set ] " + rootDataSet.FileName);
    };

    sequenceSetDataReordableList.drawElementCallback = (rect, i, _, __) =>
    {
      var targetSequenceSet = rootDataSet.Data.SequenceSets[i];
      var stb = new StringBuilder(targetSequenceSet.SequenceType + ": ");
      for (int j = 0; j < targetSequenceSet.Sequences.Count; j++)
      {
        stb.Append(targetSequenceSet.Sequences[j].SubName);
        if(j < targetSequenceSet.Sequences.Count - 1)
          stb.Append(", ");
      }
      EditorGUI.LabelField(rect, stb.ToString());
    };

    sequenceSetDataReordableList.onSelectCallback = OnSelecteSequenceSet;

    sequenceSetDataReordableList.onReorderCallback = OnReorderSequenceSet;

    sequenceSetDataReordableList.onRemoveCallback = list =>
    {
      int index = list.index;
      if (index < 0 || index >= selectedRootData.Data.SequenceSets.Count)
        return;

      selectedRootData.Data.RemoveSequenceSet(selectedRootData.Data.SequenceSets[index]);
      SelectSequenceSet(null);

      selectedRootData.OnSequenceSetRemoved();
      SaveData(selectedRootData);

      list.index = Mathf.Clamp(index - 1, 0, selectedRootData.Data.SequenceSets.Count - 1);

      Repaint();
    };
  }

  private void OnSelecteSequenceSet(ReorderableList reordableList)
  {
    int index = reordableList.index;
    if (index < 0) return;

    var targetSequenceSet = selectedRootData.Data.SequenceSets[index];
    if (selectedSequenceSet == targetSequenceSet)
      return;

    if (selectedSequenceSet != null)
      SaveData(selectedRootData);

    SelectSequenceSet(targetSequenceSet);
    Repaint();
  }

  private void OnReorderSequenceSet(ReorderableList reordableList)
  {
    SaveData(selectedRootData);
    Repaint();
  }

  private void SelectSequenceSet(DialogueData.SequenceSet sequenceSet)
  {
    if (selectedSequenceSet == sequenceSet) return;

    selectedSequenceSet = sequenceSet;
    if (selectedSequenceSet != null)
      SelectSequence(selectedSequenceSet.Sequences.First());
    else
      SelectSequence(null);
  }
  #endregion

  private void OnGUI()
  {
    scrollPos = EditorGUILayout.BeginScrollView(scrollPos);
    using (new EditorGUILayout.VerticalScope())
    {
      DrawRootDataArea();

      if (selectedRootData != null)
      {
        sequenceSetDataReordableList.DoLayoutList();
        
        DrawAddSequenceSetButtons();
        GUILayout.Space(15.0f);

        if (selectedSequenceSet != null)
        {
          GUILayout.Space(15.0f);
          DrawSequenceArea();

          if(selectedSequence != null)
          {
            switch (selectedSequence.SequenceType)
            {
              case IDialogueSequence.Type.Talking:
                DrawTalkingArea();
                break;

              case IDialogueSequence.Type.Selection:
                DrawSelectionArea();
                break;
            }
          }
        }
      }
    }
    EditorGUILayout.EndScrollView();
  }

  #region Drawing Root Data
  private void DrawRootDataArea()
  {
    using (new EditorGUILayout.VerticalScope(GUI.skin.box))
    {
      using (new EditorGUILayout.HorizontalScope(GUI.skin.box))
      {
        isFoldRootDataList = EditorGUILayout.Foldout(isFoldRootDataList, "Dialogue Datas", true);
        GUILayout.Space(80.0f);

        EditorGUI.BeginDisabledGroup(selectedRootData == null);
        DrawResetButtons();

        DrawSaveButton();
        EditorGUI.EndDisabledGroup();

        if (selectedRootData != null)
        {          
          GUILayout.Space(10.0f);

          DrawSelectedRootDataNameArea();
        }
      }

      if (isFoldRootDataList)
      {
        GUILayout.Space(15.0f);
        rootReordableList.DoLayoutList();
      }
    }
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

  private void DrawSelectedRootDataNameArea()
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
  #endregion

  #region SequenceSett Create Buttons
  private void DrawAddSequenceSetButtons()
  {
    using (new EditorGUILayout.HorizontalScope())
    {
      GUILayout.FlexibleSpace();
      DrawCreateTalkingButton();
      GUILayout.Space(15.0f);
      DrawCreateSelectionButton();
      GUILayout.FlexibleSpace();
    }
  }

  private void DrawCreateTalkingButton()
  {
    if(GUILayout.Button("+ Talking", AddButtonSize))
    {
      selectedRootData.Data.AddSequenceSet(IDialogueSequence.Type.Talking);
      CreateSequenceSetReordableList(selectedRootData);
      Repaint();
      SaveData(selectedRootData);
    }
  }

  private void DrawCreateSelectionButton()
  {
    if (GUILayout.Button("+ Selection", AddButtonSize))
    {
      selectedRootData.Data.AddSequenceSet(IDialogueSequence.Type.Selection);
      CreateSequenceSetReordableList(selectedRootData);
      Repaint();
      SaveData(selectedRootData);
    }
  }
  #endregion

  #region Sequence & Condition
  private void DrawSequenceArea()
  {
    using (new GUILayout.VerticalScope(GUI.skin.box))
    {
      using (new GUILayout.HorizontalScope())
      {
        GUILayout.FlexibleSpace();
        GUILayout.Label("[ Conditions ]");
        GUILayout.FlexibleSpace();
      }

      DrawSequenceButtons(selectedSequenceSet);

      DrawConditionSettingArea();
    }
  }

  private void DrawSequenceButtons(DialogueData.SequenceSet sequenceSet)
  {
    using (new EditorGUILayout.HorizontalScope(GUI.skin.box))
    {
      for (int i = 0; i < sequenceSet.Sequences.Count; i++)
      {
        var isDefault = i == 0;
        var sequence = sequenceSet.Sequences[i];
        var condition = sequence.GetCondition();
        var interactable = sequence == selectedSequence;

        if (isDefault)
          EditorGUILayout.BeginVertical();

        EditorGUI.BeginDisabledGroup(interactable);
        if (GUILayout.Button($"[ {sequence.SubName} ]", GUILayout.Width(80.0f), GUILayout.Height(20.0f)))
          SelectSequence(sequence);
        EditorGUI.EndDisabledGroup();

        if (!isDefault && GUILayout.Button("-", OperationButtonSize))
          RemoveSequence(sequence);

        if (isDefault)
          EditorGUILayout.EndVertical();

        if (i < sequenceSet.Sequences.Count - 1)
          EditorGUILayout.Space(15.0f);
      }

      GUILayout.FlexibleSpace();
      if (GUILayout.Button("+", OperationButtonSize))
        AddSequence();
    }
  }

  private void DrawConditionSettingArea()
  {
    var selectedConditon = selectedSequence.GetCondition();
    if (selectedConditon.TargetID < 0)
      return;

    using (new GUILayout.HorizontalScope())
    {
      GUILayout.FlexibleSpace();
      GUILayout.Label("[ Condition Setting ]");
      GUILayout.FlexibleSpace();
    }

    using (new GUILayout.HorizontalScope(GUI.skin.box))
    {
      selectedSequence.SubName = EditorGUILayout.TextField(selectedSequence.SubName, GUILayout.Width(100.0f), GUILayout.Height(20.0f));

      var conditionIndex = availableSelections.IndexOf(availableSelections.FirstOrDefault(data => data.SelectionID == selectedConditon.TargetID));
      var selectedIndex = EditorGUILayout.Popup(conditionIndex, availableSelectionNames.ToArray());
      if(conditionIndex != selectedIndex)
      {
        selectedConditon.TargetID = availableSelections[selectedIndex].SelectionID;
        SaveData(selectedRootData);
      }

      selectedConditon.LeftKey = (int)(Direction)EditorGUILayout.EnumPopup("Left: ", (Direction)selectedConditon.LeftKey);
      selectedConditon.RightKey = (int)(Direction)EditorGUILayout.EnumPopup("Right: ", (Direction)selectedConditon.RightKey);
    }
  }

  private void SelectSequence(DialogueSequenceBase sequence)
  {
    if (selectedSequence == sequence)
      return;

    SaveData(selectedRootData);
    selectedSequence = sequence;

    if (selectedSequence != null)
      UpdateAvailableSelectionDatas();
  }

  private void UpdateAvailableSelectionDatas()
  {
    availableSelections.Clear();
    availableSelectionNames.Clear();
    foreach (var sequenceSet in selectedRootData.Data.SequenceSets)
    {
      if (sequenceSet == selectedSequenceSet)
        break;

      if(sequenceSet.SequenceType == IDialogueSequence.Type.Selection)
      {
        foreach (var sequence in sequenceSet.Sequences)
        {
          var selectionData = sequence as DialogueSelectionData;
          availableSelections.Add(selectionData);
          availableSelectionNames.Add($"{selectionData.SelectionID}_{selectionData.SubName}");
        }          
      }
    }
  }

  private void RemoveSequence(DialogueSequenceBase sequence)
  {
    selectedSequenceSet.RemoveSequence(sequence);
    if (selectedSequence == sequence)
      SelectSequence(selectedSequenceSet.Sequences.First());
    SaveData(selectedRootData);
  }

  private void AddSequence()
  {
    selectedSequenceSet.CreateNewSequence();
  }
  #endregion

  private void DrawSelectionArea()
  {
    var selectedSelection = selectedSequence as DialogueSelectionData;
    using (new GUILayout.VerticalScope(GUI.skin.box))
    {
      using (new GUILayout.HorizontalScope())
      {
        var labelCenterStyle = new GUIStyle(EditorStyles.label)
        {
          alignment = TextAnchor.MiddleCenter
        };

        GUILayout.FlexibleSpace();
        EditorGUILayout.LabelField("[ Selection ]", labelCenterStyle);
        GUILayout.FlexibleSpace();
      }

      using (new GUILayout.HorizontalScope())
      {
        GUILayout.FlexibleSpace();
        selectedSelection.SelectionID = EditorGUILayout.IntField(selectedSelection.SelectionID, GUILayout.Width(60.0f));
        selectedSelection.SubName = EditorGUILayout.TextField(selectedSelection.SubName, StringCenterStyle);
        GUILayout.FlexibleSpace();
      }

      EditorGUILayout.Space(10.0f);

      using (new GUILayout.HorizontalScope())
      {
        var space = 60.0f;
        GUILayout.FlexibleSpace();
        using (new GUILayout.VerticalScope(GUI.skin.box))
        {          
          using (new GUILayout.HorizontalScope())
          {
            GUILayout.Space(space);
            selectedSelection.LeftUpKey = EditorGUILayout.TextField(selectedSelection.LeftUpKey, StringCenterStyle, GUILayout.Width(space));
            GUILayout.Space(space);
          }
          using (new GUILayout.HorizontalScope())
          {
            selectedSelection.LeftLeftKey = EditorGUILayout.TextField(selectedSelection.LeftLeftKey, StringCenterStyle, GUILayout.Width(space));
             GUILayout.Space(space);
            selectedSelection.LeftRightKey = EditorGUILayout.TextField(selectedSelection.LeftRightKey, StringCenterStyle, GUILayout.Width(space));
          }
          using (new GUILayout.HorizontalScope())
          {
             GUILayout.Space(space);
            selectedSelection.LeftDownKey = EditorGUILayout.TextField(selectedSelection.LeftDownKey, StringCenterStyle, GUILayout.Width(space));
             GUILayout.Space(space);
          }
        }

        using (new GUILayout.VerticalScope(GUI.skin.box))
        {
          using (new GUILayout.HorizontalScope())
          {
             GUILayout.Space(space);
            selectedSelection.RightUpKey = EditorGUILayout.TextField(selectedSelection.RightUpKey, StringCenterStyle, GUILayout.Width(space));
             GUILayout.Space(space);
          }
          using (new GUILayout.HorizontalScope())
          {
            selectedSelection.RightLeftKey = EditorGUILayout.TextField(selectedSelection.RightLeftKey, StringCenterStyle, GUILayout.Width(space));
             GUILayout.Space(space);
            selectedSelection.RightRightKey = EditorGUILayout.TextField(selectedSelection.RightRightKey, StringCenterStyle, GUILayout.Width(space));
          }
          using (new GUILayout.HorizontalScope())
          {
             GUILayout.Space(space);
            selectedSelection.RightDownKey = EditorGUILayout.TextField(selectedSelection.RightDownKey, StringCenterStyle, GUILayout.Width(space));
             GUILayout.Space(space);
          }          
        }
        GUILayout.FlexibleSpace();
      }
    }
  }

  private void DrawTalkingArea()
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