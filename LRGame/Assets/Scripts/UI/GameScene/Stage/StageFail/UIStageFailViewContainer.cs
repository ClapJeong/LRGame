using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStageFailViewContainer : MonoBehaviour
  {
    public BaseGameObjectView gameObjectView;
    public BaseRectView noneRectView;
    public Transform indicatorRoot;

    [Header("[ Quit ]")]
    public BaseRectView quitRectView;
    public BaseProgressSubmitView quitProgressSubmitView;
    public BaseImageView quitBackgroundImageView;
    public BaseImageView quitFillImageView;

    [Header("[ Restart ]")]
    public BaseRectView restartRectView;
    public BaseProgressSubmitView restartProgressSubmitView;
    public BaseImageView restartBackgroundImageView;
    public BaseImageView restartFillImageView;
  }
}