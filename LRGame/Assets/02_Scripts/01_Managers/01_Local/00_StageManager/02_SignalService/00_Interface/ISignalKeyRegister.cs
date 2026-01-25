
using LR.Stage.TriggerTile.Enum;

public interface ISignalKeyRegister
{
  public void RegisterKey(string key, int id, SignalLife signalLife);
}
