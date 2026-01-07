public interface ISignalConsumer
{
  public void AcquireSignal(string key);

  public void ReleaseSignal(string key);

  public void ResetAllSignal();
}
