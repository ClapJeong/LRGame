using LR.UI.GameScene.Stage.SuccessPanel;
using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStageSuccessViewContainer : MonoBehaviour
  {
    [Header("[ Base ]")]
    public Transform indicatorRoot;
    public BaseGameObjectView gameObjectView;

    [Header("[ Quit ]")]
    public BaseButtonViewContainer quitViewContainer;

    [Header("[ Restart ]")]
    public CenterButtonViewContainer restartViewContainer;

    [Header("[ Next ]")]
    public BaseButtonViewContainer nextViewContainer;
  }
}