using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;

namespace LR.UI.Indicator
{
  public class BaseUIIndicatorView : BaseUIView
  {
    [Header("[ LeftInput ]")]
    public Image leftUpImage;
    public Image leftRightImage;
    public Image leftDownImage;
    public Image leftLeftImage;

    [Header("[ RightInput ]")]
    public Image rightUpImage;
    public Image rightRightImage;
    public Image rightDownImage;
    public Image rightLeftImage;

    [Header("[ Space ]")]
    public Image spaceImage;

    public override UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(false);
      visibleState = VisibleState.Hidden;
      return UniTask.CompletedTask;
    }

    public override UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = VisibleState.Showen;
      return UniTask.CompletedTask;
    }
  }
}