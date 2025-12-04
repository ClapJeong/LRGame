using UnityEngine;

namespace LR.UI.GameScene.Stage.PausePanel
{
  public class BaseButtonViewContainer : MonoBehaviour
  {
    [Header("[ Base ]")]
    public BaseRectView baseRectView;

    [Header("[ Min ]")]
    public BaseProgressSubmitView minProgressSubmitView;
    public BaseImageView minImageView;

    [Header("[ Max ]")]
    public BaseProgressSubmitView maxProgressSubmitView;
    public BaseImageView maxImageView;
  }
}