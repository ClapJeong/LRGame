namespace LR.Table.Dialogue
{
  public interface IDialogueSequence : IConditionProvider
  {
    public enum Type
    {
      Talking,
      Selection,
    }

    public Type SequenceType { get; }
    public string FormatedName {  get; }

    public string SubName { get; set; }
  }
}
