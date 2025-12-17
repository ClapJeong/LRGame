using System.Collections.Generic;

[System.Serializable]
public class DialogueData
{
  [System.Serializable]
  public class DataSet
  {
    public enum Type
    {
      Dialogue,
      Selection,
    }

    public Type dataType;

    public List<DialogueTurnData> dialogueTurnDatas;
    public DialogueSelectionData selectionData;
  }

  public List<DataSet> datasets;
}