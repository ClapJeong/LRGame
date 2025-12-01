using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIChapterButtonViewContainer : MonoBehaviour
  {
    public BaseGameObjectView gameObjectView;
    public BaseTMPView tmpView;
    public BaseProgressSubmitView progressSubmitView;
    public BaseImageView imageView;

    [Space(5)]
    public Transform panelRoot;
  }
}