using Cysharp.Threading.Tasks;
using UnityEngine;

namespace LR.UI.Indicator
{
  public partial interface IUIIndicatorPresenter: IUIPresenter
  {
    public void ReInitialize(Transform root, IRectView targetRectView);

    public UniTask MoveAsync(IRectView targetRect, bool isImmediately = false);
  }
}