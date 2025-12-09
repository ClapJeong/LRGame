using UnityEngine;

namespace LR.UI.Indicator
{
  public class BaseUIIndicatorView : MonoBehaviour
  {
    [Header("[ Base ]")]
    public BaseGameObjectView gameObjectView;
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
  }
}