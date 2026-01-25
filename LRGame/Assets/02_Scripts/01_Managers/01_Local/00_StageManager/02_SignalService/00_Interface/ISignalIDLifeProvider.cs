using LR.Stage.TriggerTile.Enum;
using System.Collections.Generic;

public interface ISignalIDLifeProvider
{
  public Dictionary<int, SignalLife> GetSignalIDLifes(string key);
}
