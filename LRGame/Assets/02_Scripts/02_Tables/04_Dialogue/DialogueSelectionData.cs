using System.Collections.Generic;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueSelectionData
  {
    public string subName;

    public int selctionID;
    public List<DialogueCondition> conditions = new();

    public int leftUpKey;
    public int leftRightKey;
    public int leftDownKey;
    public int leftLeftKey;

    public int rightUpKey;
    public int rightRightKey;
    public int rightDownKey;
    public int rightLeftKey;
  }
}