using Cysharp.Threading.Tasks;
using LR.UI.GameScene.InputQTE;
using UnityEngine;

public interface IInputQTEUIService
{
  public UniTask<IUIInputQTEPresenter> GetPrsenterAsync(InputQTEEnum.UIType type, Transform followTarget);
  public UniTask<IUIInputQTEPresenter> GetPrsenterAsync(InputQTEEnum.UIType type, Vector2 screenPosition);
}
