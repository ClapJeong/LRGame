namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueCondition
  {
    public int targetID;
    public int leftKey;
    public int rightKey;

    public bool IsCondition(int leftKey, int rightKey)
      => this.leftKey == leftKey && this.rightKey == rightKey;
  }
}