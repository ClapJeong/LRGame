public interface IDialogueController
{
  public void Play();

  public void Complete();

  public void Skip();

  public void NextSequence();

  public void SetState(DialogueState state);
}
