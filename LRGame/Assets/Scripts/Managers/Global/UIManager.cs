using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIManager : MonoBehaviour, ICanvasProvider, IUIContainerService, IUIResourceService
{
  [System.Serializable]
  public class CanvasSet
  {
    public UIRootType type;
    public Canvas canvas;
  }

  [SerializeField] private List<CanvasSet> canvasSets = new();

  public Canvas GetCanvas(UIRootType rootType)
  {
    var set = canvasSets.First(set=>set.type == rootType);

    if (set == null)
      throw new System.NotImplementedException();

    return set.canvas;
  }
  

  public async UniTask<IUIView> CreateViewAsync(string viewKey, UIRootType createRoot)
  {
    var root = GetCanvas(createRoot).transform;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var view = await resourceManager.CreateAssetAsync<GameObject>(viewKey,root);
    return view.GetComponent<IUIView>();
  }

  public void Release(IUIView view)
  {
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    resourceManager.ReleaseInstance(view.GetGameObject());
  }

  public T Get<T>(UIRootType rootType) where T : IUIPresenter
  {
    throw new System.NotImplementedException();
  }

  public bool TryGet<T>(UIRootType rootType, out T presenter) where T : IUIPresenter
  {
    throw new System.NotImplementedException();
  }
}
