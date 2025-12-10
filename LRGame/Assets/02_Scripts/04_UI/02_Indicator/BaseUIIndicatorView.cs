using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI.Indicator
{
  public class BaseUIIndicatorView : BaseUIView
  {
    [Header("[ Base ]")]
    public BaseRectView rectView;

    [Header("[ LeftInput ]")]
    public BaseImageView leftUpImageView;
    public BaseImageView leftRightImageView;
    public BaseImageView leftDownImageView;
    public BaseImageView leftLeftImageView;

    [Header("[ RightInput ]")]
    public BaseImageView rightUpImageView;
    public BaseImageView rightRightImageView;
    public BaseImageView rightDownImageView;
    public BaseImageView rightLeftImageView;

    [Header("[ Space ]")]
    public BaseImageView spaceImageView;

    public override UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
      return UniTask.CompletedTask;
    }

    public override UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showen;
      return UniTask.CompletedTask;
    }
  }
}