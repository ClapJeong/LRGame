using UnityEngine;
using UnityEngine.UI;

namespace LR.UI
{
  public class BaseNavigationView : MonoBehaviour, INavigationView
  {
    [SerializeField] private Selectable selectable;

    public Selectable GetSelectable()
      => selectable;

    public void SetNavigation(Selectable up, Selectable right, Selectable down, Selectable left)
    {
      var navigation = new Navigation();
      navigation.mode = Navigation.Mode.Explicit;
      navigation.selectOnUp = up;
      navigation.selectOnRight = right;
      navigation.selectOnDown = down;
      navigation.selectOnLeft = left;

      selectable.navigation = navigation;
    }
  }
}