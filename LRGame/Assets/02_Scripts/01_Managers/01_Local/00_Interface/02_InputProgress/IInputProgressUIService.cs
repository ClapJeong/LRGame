using Cysharp.Threading.Tasks;
using LR.UI.GameScene.InputProgress;
using UnityEngine;

public interface IInputProgressUIService
{
  public UniTask<IUIInputProgressPresenter> GetPresenterAsync(
    InputProgressEnum.UIType type,
    Transform followTarget);

  public UniTask<IUIInputProgressPresenter> GetPresenterAsync(
    InputProgressEnum.UIType type,
    Vector2 canvasPosition);
}
