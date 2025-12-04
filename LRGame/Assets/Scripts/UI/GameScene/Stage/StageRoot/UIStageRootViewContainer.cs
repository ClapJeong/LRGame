using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStageRootViewContainer : MonoBehaviour
  {
    public UIStageBeginViewContainer beginViewContainer;
    public UIStageFailViewContainer failViewContainer;
    public UIStageSuccessViewContainer successViewContainer;
    public UIStagePauseViewContainer pauseViewContainer;
  }
}