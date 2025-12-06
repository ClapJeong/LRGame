using System;
using System.Collections.Generic;

namespace LR.UI.Indicator
{
  public partial interface IUIIndicatorPresenter
  {
    public void SetRightGuide(params Direction[] directions);
  }
}