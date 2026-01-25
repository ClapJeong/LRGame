public interface ISignalConsumer
{
  public void AcquireSignal(string key, int id);

  public void ReleaseSignal(string key, int id);

  public void ResetAllSignal();
}
