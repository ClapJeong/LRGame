using UnityEngine;

namespace LR.UI.GameScene
{
  public class UIGameFirstViewContainer : MonoBehaviour
  {
    public UIStageBeginViewContainer beginViewContainer;
    public UIStageFailViewContainer failViewContainer;
    public UIStageSuccessViewContainer successViewContainer;

    [Header("[ Player UI ]")]
    public UIPlayerInputViewContainer leftViewContainer;
    public UIPlayerInputViewContainer rightViewContainer;
  }
}