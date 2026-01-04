using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIManager : MonoBehaviour, 
  ICanvasProvider, 
  IChatCardPositionGetter
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

  [Header("[ IChatCardPositionGetter ]")]
  [SerializeField] private RectTransform LeftChatCardPosition;
  [SerializeField] private RectTransform CenterChatCardPosition;
  [SerializeField] private RectTransform RightChatCardPosition;

  private UIPresenterContainer presenterContainer;
  private UISelectedGameObjectService selectedGameObjectService;  
  private UIIndicatorService indicatorService;
  private UIDepthService depthService;
  private UIProgressSubmitController progressSubmitController;

  public void Initialize(IResourceManager resourceManager, FactoryManager factoryManager)
  {
    presenterContainer = new UIPresenterContainer();
    selectedGameObjectService = new UISelectedGameObjectService();
    depthService = new UIDepthService();
    indicatorService = new UIIndicatorService(resourceManager, disableRoot);
    progressSubmitController = new UIProgressSubmitController(selectedGameObjectService, factoryManager.InputActionFactory);
  }

  private void Update()
  {
    selectedGameObjectService.UpdateDetectingSelectedObject();
    depthService.UpdateFocusingSelectedGameObject();
  }

  #region ICanvasProvider
  public Canvas GetCanvas(UIRootType rootType)
  {
    var set = canvasSets.First(set=>set.type == rootType);

    return set == null ? throw new System.NotImplementedException() : set.canvas;
  }
  #endregion

  public IUIPresenterContainer GetIUIPresenterContainer()
    => presenterContainer;

  public IUISelectedGameObjectService GetIUISelectedGameObjectService()
    => selectedGameObjectService;

  public IUIIndicatorService GetIUIIndicatorService()
    => indicatorService;

  public IUIDepthService GetIUIDepthService()
    => depthService;

  public IUIProgressSubmitController GetIUIProgressSubmitController()
    => progressSubmitController;

  #region IChatCardPositionGetter
  public Vector2 GetPosition(CharacterPositionType positionType)
    => positionType switch
    {
      CharacterPositionType.Left => LeftChatCardPosition.position,
      CharacterPositionType.Center => CenterChatCardPosition.position,
      CharacterPositionType.Right => RightChatCardPosition.position,
      _ => throw new System.NotImplementedException(),
    };
  #endregion
}
