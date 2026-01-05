using Cysharp.Threading.Tasks;
using LR.UI.GameScene.InputMashProgress;
using UnityEngine;

public class InputProgressUIService : IInputProgressUIService
{
  private readonly GameObject localManager;
  private readonly ICanvasProvider canvasProvider;
  private readonly IResourceManager resourceManager;
  private readonly AddressableKeySO addressableSO;

  public InputProgressUIService(GameObject localManager, ICanvasProvider canvasProvider, IResourceManager resourceManager, AddressableKeySO addressableSO)
  {
    this.localManager = localManager;
    this.canvasProvider = canvasProvider;
    this.resourceManager = resourceManager;
    this.addressableSO = addressableSO;
  }

  public async UniTask<IInputProgressUIPresenter> CreateAsync(InputProgressEnum.InputProgressUIType type, Transform followTarget)
  {
    var presenter = await CreateAsync(type);
    presenter.SetFollowTransform(followTarget);
    return presenter;
  }

  public async UniTask<IInputProgressUIPresenter> CreateAsync(InputProgressEnum.InputProgressUIType type, Vector2 canvasPosition)
  {
    var presenter = await CreateAsync(type);
    presenter.SetPosition(canvasPosition);
    return presenter;
  }

  private async UniTask<IInputProgressUIPresenter> CreateAsync(InputProgressEnum.InputProgressUIType type)
  {
    var viewKey = addressableSO.Path.UI + type.ToString();
    switch (type)
    {
      case InputProgressEnum.InputProgressUIType.RightEnergyItem:
        {
          var model = new UIRightEnergyItemPresenter.Model();
          var view = await resourceManager.CreateAssetAsync<UIRightEnergyItemView>(viewKey, canvasProvider.GetCanvas(UIRootType.Overlay).transform);
          var presenter = new UIRightEnergyItemPresenter(model, view);
          presenter.AttachOnDestroy(localManager);
          return presenter;
        }

      default: throw new System.NotImplementedException();
    }
  }
}
