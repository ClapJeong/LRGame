using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

namespace LR.UI.Indicator
{
  public partial interface IUIIndicatorPresenter: IUIPresenter
  {
    public void ReInitialize(Transform root, IRectView targetRectView);

    public void Disable(Transform disabledRoot);

    public UniTask MoveAsync(IRectView targetRect, bool isImmediately = false);
  }
}