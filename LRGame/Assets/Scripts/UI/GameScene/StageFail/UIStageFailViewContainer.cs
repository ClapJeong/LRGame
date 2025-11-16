using UnityEngine;

namespace LR.UI.GameScene
{
  public class UIStageFailViewContainer : MonoBehaviour, IGameObjectView
  {
    public BaseCanvasGroupView failBackgroundView;
    public BaseLocalizeStringView failTextView;

    public void SetActive(bool active)
      => gameObject.SetActive(active);

    public void SetRoot(Transform root)
      => transform.SetParent(root);
  }
}