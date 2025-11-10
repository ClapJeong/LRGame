using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIManager : MonoBehaviour, ICanvasProvider, IUIResourceService, IUIPresenterFactory, IUIPresenterContainer, IFirstUICreator
{
  [System.Serializable]
  public class CanvasSet
  {
    public UIRootType type;
    public Canvas canvas;
  }

  [SerializeField] private List<CanvasSet> canvasSets = new();

  private readonly Dictionary<Type, Func<IUIPresenter>> presenterRegisters = new();
  private readonly Dictionary<Type,List<IUIPresenter>> cachedPresenters = new();

  public Canvas GetCanvas(UIRootType rootType)
  {
    var set = canvasSets.First(set=>set.type == rootType);

    if (set == null)
      throw new System.NotImplementedException();

    return set.canvas;
  }
  

  public async UniTask<GameObject> CreateViewAsync(string viewKey, UIRootType createRoot)
  {
    var root = GetCanvas(createRoot).transform;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var view = await resourceManager.CreateAssetAsync<GameObject>(viewKey,root);
    return view;
  }

  public void ReleaseView(GameObject view, bool releaseHandle = false)
  {
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    resourceManager.ReleaseInstance(view, releaseHandle);
  }

  public async UniTask<GameObject> CreateFirstUIViewAsync(SceneType sceneType)
  {
    var firstUIKey = GetFirstUIKey(sceneType);
    var firstUI = await CreateViewAsync(firstUIKey, UIRootType.Overlay);
    return firstUI;
  }

  private string GetFirstUIKey(SceneType sceneType)
  {
    var keyTable = GlobalManager.instance.Table.AddressableKeySO;
    return sceneType switch
    {
      SceneType.Initialize => throw new System.NotImplementedException(),
      SceneType.Preloading =>
         keyTable.Path.Ui +
         keyTable.UIName.PreloadingFirst,
      SceneType.Lobby =>
         keyTable.Path.Ui +
         keyTable.UIName.LobbyFirst,
      SceneType.Game =>
         keyTable.Path.Ui +
         keyTable.UIName.GameFirst,

      _ => throw new System.NotImplementedException(),
    };
  }

  public void Register<T>(Func<T> constructor) where T : IUIPresenter
  {
    var type = typeof(T);
    presenterRegisters[type] = ()=> constructor();
  }

  public T Create<T>() where T : IUIPresenter
  {
    var type = typeof(T);
    if (presenterRegisters.ContainsKey(type) == false)
      throw new System.NotImplementedException($"{type.Name} does not exist");

    var presenter = (T)presenterRegisters[type]();
    Add(presenter);

    return presenter;
  }

  public void Add(IUIPresenter presenter)
  {
    var type = presenter.GetType();

    if (cachedPresenters.TryGetValue(type, out var existList))
      existList.Add(presenter);
    else
      cachedPresenters[type] = new List<IUIPresenter> { presenter };
  }

  public void Remove(IUIPresenter presenter)
  {
    var type = presenter.GetType();

    if(cachedPresenters.TryGetValue(type,out var existList))
      existList.Remove(presenter);
  }

  public IReadOnlyList<T> GetAll<T>() where T : IUIPresenter
  {
    if(cachedPresenters.TryGetValue(typeof(T), out var existList))
      return existList.Cast<T>().ToList();
    else
      return Array.Empty<T>();
  }

  public T GetFirst<T>() where T : IUIPresenter
    => GetAll<T>().FirstOrDefault();

  public T GetLast<T>() where T : IUIPresenter
    => GetAll<T>().LastOrDefault();
}
