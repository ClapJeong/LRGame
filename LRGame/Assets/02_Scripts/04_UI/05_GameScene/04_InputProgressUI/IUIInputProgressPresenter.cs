using UnityEngine;

namespace LR.UI.GameScene.InputProgress
{
  public interface IUIInputProgressPresenter : IUIPresenter
  {
    public void SetFollowTransform(Transform transform);

    public void SetPosition(Vector2 screenPosition);

    public void OnProgress(float normalizedValue);

    public void OnComplete();

    public void OnFail();
  }
}
