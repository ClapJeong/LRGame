using UnityEngine;

namespace LR.UI.Indicator
{
  public class BaseUIIndicatorView : MonoBehaviour, IGameObjectView, IRectView
  {
    [SerializeField] private BaseGameObjectView gameObjectView;
    [SerializeField] private BaseRectView rectView;

    #region IRectView
    public Vector2 GetCurrentRectSize()
      => rectView.GetCurrentRectSize();

    public void SetAnchoredPosition(Vector2 anchoredPosition)
      => rectView.SetAnchoredPosition(anchoredPosition);

    public void SetPivot(Vector2 pivot)
      => rectView.SetPivot(pivot);  

    public void SetPosition(Vector2 position)
      => rectView.SetPosition(position);

    public void SetRect(Vector2 rect)
      => rectView.SetRect(rect);

    public Vector2 GetPosition()
      => rectView.GetPosition();

    public Vector2 GetAnchoredPosition()
      => rectView.GetAnchoredPosition();
    #endregion

    #region IGameObjectView
    public void SetActive(bool active)
      =>gameObjectView.SetActive(active);

    public void SetRoot(Transform root)
      => gameObjectView.SetRoot(root);
    #endregion
  }
}