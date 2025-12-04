using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStageRootViewContainer : MonoBehaviour
  {
    [Header("[ Base ]")]
    public BaseGameObjectView gameObjectView;

    [Header("[ Else ]")]
    public UIStageBeginViewContainer beginViewContainer;
    public UIStageFailViewContainer failViewContainer;
    public UIStageSuccessViewContainer successViewContainer;
    public UIStagePauseViewContainer pauseViewContainer;
  }
}