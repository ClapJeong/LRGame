using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.Indicator
{
  public interface IUIIndicatorPresenter: IUIPresenter
  {
    public UniTask MoveAsync(IRectView targetRect, bool isImmediately = false, CancellationToken token = default);
  }
}