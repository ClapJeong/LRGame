using UnityEngine;

namespace LR.UI
{
  [ExecuteInEditMode]
  [RequireComponent(typeof(RectTransform))]
  public class BaseRectView : MonoBehaviour, IRectView
  {
    private RectTransform rectTransform;

    private void OnEnable()
    {
      rectTransform = GetComponent<RectTransform>();
    }

    public virtual void SetPivot(Vector2 pivot)
      => rectTransform.pivot = pivot;

    public void SetRect(Vector2 rect)
    {
      rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rect.x);
      rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rect.y);
    }

    public Vector2 GetCurrentRectSize()
      => rectTransform.rect.size;

    public void SetPosition(Vector2 position)
      => rectTransform.position = position;

    public void SetAnchoredPosition(Vector2 anchoredPosition)
      => rectTransform.anchoredPosition = anchoredPosition;

    public Vector2 GetPosition()
      => rectTransform.position;

    public Vector2 GetAnchoredPosition()
      => rectTransform.anchoredPosition;
  }
}