using LR.Stage.TriggerTile.Enum;
using System.Collections.Generic;

public interface ISignalLifesProvider
{
  public List<SignalLife> GetSignalLifes(string key);
}
