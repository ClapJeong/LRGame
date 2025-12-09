using UnityEngine;

namespace LR.UI
{
  [RequireComponent(typeof(RectTransform))]
  public class BaseRectView : MonoBehaviour, IRectView
  {
    private RectTransform rectTransform;
    private RectTransform RectTransform
    {
      get
      {
        if(rectTransform == null)
          rectTransform = GetComponent<RectTransform>();
        return rectTransform;
      }
    }

    public virtual void SetPivot(Vector2 pivot)
      => RectTransform.pivot = pivot;

    public void SetRect(Vector2 rect)
    {
      RectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rect.x);
      RectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rect.y);
    }

    public Vector2 GetCurrentRectSize()
      => RectTransform.rect.size;

    public void SetPosition(Vector2 position)
      => RectTransform.position = position;

    public void SetAnchoredPosition(Vector2 anchoredPosition)
      => RectTransform.anchoredPosition = anchoredPosition;

    public Vector2 GetPosition()
      => RectTransform.position;

    public Vector2 GetAnchoredPosition()
      => RectTransform.anchoredPosition;

    public Vector2 GetCenterPosition()
    {
      Vector2 pivotOffset = (new Vector2(0.5f, 0.5f) - RectTransform.pivot);
      Vector2 size = RectTransform.rect.size;

      return (Vector2)RectTransform.position + Vector2.Scale(size, pivotOffset);
    }
  }
}