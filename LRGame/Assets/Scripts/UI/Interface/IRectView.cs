using UnityEngine;

namespace LR.UI
{
  public interface IRectView
  {
    public void SetPivot(Vector2 pivot);

    public void SetRect(Vector2 rect);

    public Vector2 GetCurrentRectSize();

    public void SetPosition(Vector2 position);

    public void SetAnchoredPosition(Vector2 anchoredPosition);

    public Vector2 GetPosition();

    public Vector2 GetAnchoredPosition();

    public Vector2 GetCenterPosition();
  }
}