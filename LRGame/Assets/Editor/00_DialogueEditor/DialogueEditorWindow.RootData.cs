using LR.Table.Dialogue;
using UnityEngine;

public partial class DialogueEditorWindow
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
        if (index != value)
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

}
