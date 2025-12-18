using System.Collections.Generic;

namespace LR.Table.Dialogue
{
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

      public readonly Type dataType;
      public string FieldName => $"{dataType.ToString()}_{subName}";

      public string subName = "none";

      public List<DialogueTurnData> dialogueTurnDatas;
      public List<DialogueSelectionData> selectionDatas;

      public DataSet(DialogueTurnData turnData)
      {
        dataType = Type.Dialogue;
        dialogueTurnDatas = new()
        {
          turnData
        };
      }

      public DataSet(DialogueSelectionData selectionData)
      {
        dataType = Type.Selection;
        selectionDatas = new()
        {
          selectionData
        };
      }
    }

    public List<DataSet> datasets;
  }
}