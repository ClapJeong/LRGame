using System;
using System.Collections.Generic;

namespace LR.UI.Indicator
{
  public partial interface IUIIndicatorPresenter
  {
    public void SetRightInputGuide(params Direction[] directions);
  }
}