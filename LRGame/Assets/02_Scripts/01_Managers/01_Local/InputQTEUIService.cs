using Cysharp.Threading.Tasks;
using LR.UI.GameScene.InputQTE;
using System;
using UnityEngine;

public class InputQTEUIService : IInputQTEUIService
{
  private readonly GameObject localManager;
  private readonly ICanvasProvider canvasProvider;
  private readonly IResourceManager resourceManager;
  private readonly AddressableKeySO addressableSO;

  public InputQTEUIService(GameObject localManager, ICanvasProvider canvasProvider, IResourceManager resourceManager, AddressableKeySO addressableSO)
  {
    this.localManager = localManager;
    this.canvasProvider = canvasProvider;
    this.resourceManager = resourceManager;
    this.addressableSO = addressableSO;
  }

  public async UniTask<IUIInputQTEPresenter> GetPrsenterAsync(InputQTEEnum.UIType type, Transform followTarget)
  {
    var presenter = await CreatePresenterAsync(type);
    presenter.SetFollowTransform(followTarget);
    return presenter;
  }

  public async UniTask<IUIInputQTEPresenter> GetPrsenterAsync(InputQTEEnum.UIType type, Vector2 screenPosition)
  {
    var presenter = await CreatePresenterAsync(type);
    presenter.SetPosition(screenPosition);
    return presenter;
  }

  private async UniTask<IUIInputQTEPresenter> CreatePresenterAsync(InputQTEEnum.UIType type)
  {
    var viewKey = addressableSO.Path.UI + type.ToString();
    switch (type)
    {
      case InputQTEEnum.UIType.LeftEnergyItem:
        {
          var model = new UILeftEnergyItemPresenter.Model();
          var view = await resourceManager.CreateAssetAsync<UILeftEnergyItemView>(viewKey, canvasProvider.GetCanvas(UIRootType.Overlay).transform);
          var presenter = new UILeftEnergyItemPresenter(model, view);
          presenter.AttachOnDestroy(localManager);
          return presenter;
        }

      default: throw new NotImplementedException();
    }    
  }
}
