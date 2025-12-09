using System.Collections.Generic;
using UnityEngine.UI;

namespace LR.UI.Indicator
{
  public partial interface IUIIndicatorPresenter
  {
    public enum LeftGuideType
    {
      Movable,
      Clamped,
    }

    public void SetLeftGuide(Direction direction, LeftGuideType guideType);

    public void SetLeftGuide(Dictionary<Direction, LeftGuideType> guideSets);

    public void SetLeftGuide(Navigation navigation);
  }
}