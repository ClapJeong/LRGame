using System.Collections.Generic;
using UnityEngine;

public interface ILocalizeStringController
{
  public void SetEntry(string key);

  public void SetArgument(List<object> arguments);
}
