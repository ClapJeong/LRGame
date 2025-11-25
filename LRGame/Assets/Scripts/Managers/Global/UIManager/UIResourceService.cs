using Cysharp.Threading.Tasks;
using UnityEngine;

public class UIResourceService : IUIResourceService
{
  private ICanvasProvider canvasProvider;

  public UIResourceService(ICanvasProvider canvasProvider)
  {
    this.canvasProvider = canvasProvider;
  }

  public async UniTask<T> CreateViewAsync<T>(string viewKey, UIRootType createRoot) where T : UnityEngine.Object
  {
    var root = canvasProvider.GetCanvas(createRoot).transform;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var view = await resourceManager.CreateAssetAsync<T>(viewKey, root);
    return view;
  }

  public void ReleaseView(GameObject view, bool releaseHandle = false)
  {
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    resourceManager.ReleaseInstance(view, releaseHandle);
  }
}