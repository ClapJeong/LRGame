using UnityEngine;

public static class RectTransformExtension
{
  public static Vector3 GetCenterPosition(this RectTransform rectTransform)
  {
    Vector2 pivotOffset = (new Vector2(0.5f, 0.5f) - rectTransform.pivot);
    Vector2 size = rectTransform.rect.size;

    return (Vector2)rectTransform.position + Vector2.Scale(size, pivotOffset);
  }

  public static void SetScale(this RectTransform rectTransform, float scale)
  {
    rectTransform.localScale = Vector3.one * scale;
  }

  public static void SetSize(this RectTransform rectTransform, Vector2 size)
  {
    rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, size.x);
    rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, size.y);
  }
}
