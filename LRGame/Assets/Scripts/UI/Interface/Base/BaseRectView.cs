using UnityEngine;

namespace LR.UI
{
  [RequireComponent(typeof(RectTransform))]
  public class BaseRectView : MonoBehaviour, IRectView
  {
    private RectTransform rectTransform;

    private void OnEnable()
    {
      rectTransform = GetComponent<RectTransform>();
    }

    public virtual void SetPivot(Vector2 pivot)
    {
      rectTransform.pivot = pivot;
    }
  }
}