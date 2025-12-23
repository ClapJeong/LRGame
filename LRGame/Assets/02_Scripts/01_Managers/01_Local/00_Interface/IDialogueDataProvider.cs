using LR.Table.Dialogue;

public interface IDialogueDataProvider
{
  public bool TryGetBeforeDialogueData(out DialogueData beforeDialogueData);

  public bool TryGetAfterDialogueData(out DialogueData afterDialogueData);
}
