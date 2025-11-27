using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using LR.UI;
using UnityEngine.Events;
using LR.UI.Indicator;

public class UIManager : MonoBehaviour, 
  ICanvasProvider, 
  IUIResourceService, 
  IUIPresenterFactory, 
  IUIPresenterContainer, 
  IUISelectedGameObjectService,
  IUIIndicatorService,
  IUIDepthService
{
  [System.Serializable]
  public class CanvasSet
  {
    public UIRootType type;
    public Canvas canvas;
  }

  [SerializeField] private List<CanvasSet> canvasSets = new();

  private UIResourceService resourceService;
  private UIPresenterContainer presenterContainer;
  private UIPresenterFactory presenterFactory;
  private UISelectedGameObjectService selectedGameObjectService;  
  private UIIndicatorService indicatorService;
  private UIDepthService depthService;
  private UIProgressSubmitController progressSubmitController;

  public void Initialize()
  {
    presenterContainer = new UIPresenterContainer();
    presenterFactory = new UIPresenterFactory(container: this);
    selectedGameObjectService = new UISelectedGameObjectService();
    resourceService = new UIResourceService(canvasProvider: this);
    depthService = new UIDepthService();
    indicatorService = new UIIndicatorService(resourceManager: GlobalManager.instance.ResourceManager);
    progressSubmitController = new UIProgressSubmitController(selectedGameObjectService: selectedGameObjectService, inputActionFactory: GlobalManager.instance.FactoryManager.InputActionFactory);
  }

  private void Update()
  {
    selectedGameObjectService.UpdateDetectingSelectedObject();
    depthService.UpdateFocusingSelectedGameObject();
  }

  public Canvas GetCanvas(UIRootType rootType)
  {
    var set = canvasSets.First(set=>set.type == rootType);

    if (set == null)
      throw new System.NotImplementedException();

    return set.canvas;
  }

  #region IUIResourceService
  public async UniTask<T> CreateViewAsync<T>(string viewKey, UIRootType createRoot) where T : UnityEngine.Object
    => await resourceService.CreateViewAsync<T>(viewKey, createRoot);

  public void ReleaseView(GameObject view, bool releaseHandle = false)
    => resourceService.ReleaseView(view, releaseHandle);
  #endregion

  #region IUIPresenterFactory
  public void Register<T>(Func<T> constructor) where T : IUIPresenter
    =>presenterFactory.Register<T>(constructor);

  public T Create<T>() where T : IUIPresenter
    => presenterFactory.Create<T>();
  #endregion

  #region IUIPresenterContainer
  public void Add(IUIPresenter presenter)
    => presenterContainer.Add(presenter);

  public void Remove(IUIPresenter presenter)
    => presenterContainer.Remove(presenter);

  public IReadOnlyList<T> GetAll<T>() where T : IUIPresenter
    => presenterContainer.GetAll<T>();

  public T GetFirst<T>() where T : IUIPresenter
    => presenterContainer.GetFirst<T>();

  public T GetLast<T>() where T : IUIPresenter
    => presenterContainer.GetLast<T>();
  #endregion

  #region IUISelectionEventService
  public void SetSelectedObject(GameObject gameObject)
    => selectedGameObjectService.SetSelectedObject(gameObject);

  public void SubscribeEvent(IUISelectedGameObjectService.EventType type, UnityAction<GameObject> action)
    => selectedGameObjectService.SubscribeEvent(type, action);

  public void UnsubscribeEvent(IUISelectedGameObjectService.EventType type, UnityAction<GameObject> action)
    => selectedGameObjectService.UnsubscribeEvent(type, action);
  #endregion

  #region IUIIndicatorService
  public void AttachCurrentWithGameObject(GameObject target)
    => indicatorService.AttachCurrentWithGameObject(target);

  public async UniTask<IUIIndicatorPresenter> CreateAsync(Transform root, IRectView beginTarget)
    => await indicatorService.CreateAsync(root, beginTarget);

  public IUIIndicatorPresenter GetCurrent()
    => indicatorService.GetCurrent();

  public bool TryGetCurrent(out IUIIndicatorPresenter current)
    => indicatorService.TryGetCurrent(out current);

  public void Push(IUIIndicatorPresenter presenter)
    => indicatorService.Push(presenter);

  public IUIIndicatorPresenter Pop()
    => indicatorService.Pop();

  public void DestroyCurrent()
    => indicatorService.DestroyCurrent();
  #endregion

  #region IUIDepthService
  public void SelectTopObject()
    => depthService.SelectTopObject();

  public void RaiseDepth(GameObject targetSelectingGameObject)
    =>depthService.RaiseDepth(targetSelectingGameObject);

  public void LowerDepth()
    => depthService.LowerDepth();
  #endregion
}
