namespace LR.UI.Indicator
{
  public partial interface IUIIndicatorPresenter
  {
    public void SetRightInputGuide(params Direction[] directions);

    public void SetRightInputGuide(IUIProgressSubmitView progressSubmitView);
  }
}