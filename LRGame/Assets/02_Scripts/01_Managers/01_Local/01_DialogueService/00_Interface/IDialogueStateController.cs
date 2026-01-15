public interface IDialogueStateController
{
  public void Play();

  public void Complete();

  public void Skip();

  public void NextSequence();

  public void SetSequenceState(SequenceState state);
}
