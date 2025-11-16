using System.Collections.Generic;
using UnityEngine;

namespace LR.UI
{
  public interface ILocalizeStringView
  {
    public void SetEntry(string key);

    public void SetArgument(List<object> arguments);
  }
}