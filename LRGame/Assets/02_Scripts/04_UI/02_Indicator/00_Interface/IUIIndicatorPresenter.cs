using Cysharp.Threading.Tasks;
using UnityEngine;

namespace LR.UI.Indicator
{
  public partial interface IUIIndicatorPresenter: IUIPresenter
  {
    public void ReInitialize(Transform root, RectTransform rectTransform);

    public UniTask MoveAsync(RectTransform rectTransform, bool isImmediately = false);
  }
}