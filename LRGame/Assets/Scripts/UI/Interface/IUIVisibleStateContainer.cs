using UnityEngine;

namespace LR.UI
{
  public interface IUIVisibleStateContainer
  {
    public UIVisibleState GetVisibleState();

    public void SetVisibleState(UIVisibleState visibleState);
  }
}