using UnityEngine.UI;

namespace LR.UI
{
  public interface INavigationView
  {
    public Selectable GetSelectable();

    public void AddNavigation(Direction direction, Selectable target);

    public void SetNavigation(Selectable up, Selectable right, Selectable down, Selectable left);
  }
}