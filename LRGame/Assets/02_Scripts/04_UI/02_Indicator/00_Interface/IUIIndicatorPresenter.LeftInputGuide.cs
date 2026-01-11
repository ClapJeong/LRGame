using System.Collections.Generic;
using UnityEngine.UI;

namespace LR.UI.Indicator
{
  public partial interface IUIIndicatorPresenter
  {
    public enum LeftInputGuideType
    {
      Movable,
      Clamped,
    }

    public void SetLeftInputGuide(Direction direction, LeftInputGuideType guideType);

    public void SetLeftInputGuide(Dictionary<Direction, LeftInputGuideType> guideSets);

    public void SetLeftInputGuide(Navigation navigation);
  }
}