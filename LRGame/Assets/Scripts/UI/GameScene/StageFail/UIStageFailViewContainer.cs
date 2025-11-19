using UnityEngine;

namespace LR.UI.Stage
{
  public class UIStageFailViewContainer : MonoBehaviour, IGameObjectView
  {
    public BaseCanvasGroupTweenView failBackgroundView;
    public BaseLocalizeStringView failTextView;

    public void SetActive(bool active)
      => gameObject.SetActive(active);

    public void SetRoot(Transform root)
      => transform.SetParent(root);
  }
}