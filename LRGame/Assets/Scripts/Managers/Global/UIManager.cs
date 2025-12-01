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

  [Header("[ Canvas ]")]
  [SerializeField] private List<CanvasSet> canvasSets = new();

  [Header("[ Root ]")]
  [SerializeField] private Transform disableRoot;

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
    depthService = new UIDepthService();
    indicatorService = new UIIndicatorService(resourceManager: GlobalManager.instance.ResourceManager, disableRoot: disableRoot);
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

  public IUIIndicatorPresenter GetTopIndicator()
    => indicatorService.GetTopIndicator();

  public bool TryGetTopIndicator(out IUIIndicatorPresenter current)
    => indicatorService.TryGetTopIndicator(out current);

  public async UniTask<IUIIndicatorPresenter> GetNewAsync(Transform root, IRectView beginTarget)
    => await indicatorService.GetNewAsync(root, beginTarget);

  public void ReleaseTopIndicator()
    => indicatorService.ReleaseTopIndicator();

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
