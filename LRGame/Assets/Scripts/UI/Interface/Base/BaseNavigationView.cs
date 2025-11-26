using UnityEngine;
using UnityEngine.UI;

namespace LR.UI
{
  public class BaseNavigationView : MonoBehaviour, INavigationView
  {
    [SerializeField] private Selectable selectable;

    private void Awake()
    {
      if (selectable == null)
        throw new System.NotImplementedException($"{gameObject.name}에 selectable 할당 않 됢!");
    }

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

    public void AddNavigation(Direction direction, Selectable target)
    {
      var navigation = GetSelectable().navigation;
      navigation.mode = Navigation.Mode.Explicit;
      switch (direction)
      {
        case Direction.Up:
          navigation.selectOnUp = target;
          break;

        case Direction.Down:
          navigation.selectOnDown = target;
          break;

        case Direction.Left:
          navigation.selectOnLeft = target;
          break;

        case Direction.Right:
          navigation.selectOnRight = target;
          break;

        default: throw new System.NotImplementedException();
      }

      selectable.navigation = navigation;
    }
  }
}