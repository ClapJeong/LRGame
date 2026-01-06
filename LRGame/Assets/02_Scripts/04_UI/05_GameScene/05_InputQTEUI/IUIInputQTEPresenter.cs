using UnityEngine;

namespace LR.UI.GameScene.InputQTE
{
  public interface IUIInputQTEPresenter : IUIPresenter
  {
    public void SetFollowTransform(Transform transform);

    public void SetPosition(Vector2 screenPosition);

    public void OnSequenceBegin();

    public void OnQTEBegin(Direction direction);

    public void OnQTEProgress(float value);

    public void OnQTEResult(bool isSuccess);

    public void OnSequenceProgress(float value);

    public void OnQTECountChanged(int count);

    public void OnSequenceResult(bool isSuccess);
  }
}