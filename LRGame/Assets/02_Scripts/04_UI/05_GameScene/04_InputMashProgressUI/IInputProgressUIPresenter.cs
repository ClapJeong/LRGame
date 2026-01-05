using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.GameScene.InputMashProgress
{
  public interface IInputProgressUIPresenter : IUIPresenter
  {
    public void SetFollowTransform(Transform transform);

    public void SetPosition(Vector2 screenPosition);

    public void OnProgress(float normalizedValue);

    public void OnComplete();

    public void OnFail();
  }
}
