using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.Indicator
{
  public interface IUIIndicatorPresenter: IUIPresenter
  {
    public void ReInitialize(Transform root, IRectView targetRectView);

    public void Disable(Transform disabledRoot);

    public UniTask MoveAsync(IRectView targetRect, bool isImmediately = false);
  }
}