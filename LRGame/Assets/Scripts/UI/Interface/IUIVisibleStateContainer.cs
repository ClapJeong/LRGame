using UnityEngine;

public interface IUIVisibleStateContainer
{
  public UIVisibleState GetVisibleState();

  public void SetVisibleState(UIVisibleState visibleState);
}
