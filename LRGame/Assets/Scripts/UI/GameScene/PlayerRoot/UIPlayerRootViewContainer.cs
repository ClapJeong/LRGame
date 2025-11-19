using UnityEngine;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerRootViewContainer : MonoBehaviour
  {
    [Header("Input")]
    public UIPlayerInputViewContainer leftInputViewContainer;
    public UIPlayerInputViewContainer rightInputViewContainer;

    [Header("HP")]
    public UIPlayerHPViewContainer leftHPViewContainer;
    public UIPlayerHPViewContainer rightHPViewContainer;
  }
}