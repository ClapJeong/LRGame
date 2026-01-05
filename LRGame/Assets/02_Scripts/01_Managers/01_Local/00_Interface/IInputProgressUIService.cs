using Cysharp.Threading.Tasks;
using LR.UI.GameScene.InputMashProgress;
using UnityEngine;

public interface IInputProgressUIService
{
  public UniTask<IInputProgressUIPresenter> CreateAsync(
    InputProgressEnum.InputProgressUIType type,
    Transform followTarget);

  public UniTask<IInputProgressUIPresenter> CreateAsync(
    InputProgressEnum.InputProgressUIType type,
    Vector2 canvasPosition);
}
