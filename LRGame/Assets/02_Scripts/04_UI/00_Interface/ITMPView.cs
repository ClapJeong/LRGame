using UnityEngine;

namespace LR.UI
{
  public interface ITMPView
  {
    public void SetText(string text);

    public void AppendText(string text);
  }
}