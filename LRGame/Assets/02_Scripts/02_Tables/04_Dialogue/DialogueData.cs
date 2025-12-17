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

      public Type dataType;

      public List<DialogueTurnData> dialogueTurnDatas;
      public List<DialogueSelectionData> selectionDatas;
    }

    public List<DataSet> datasets;
  }
}