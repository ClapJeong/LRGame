using Cysharp.Threading.Tasks;
using LR.UI;
using LR.UI.GameScene.Dialogue;
using LR.UI.GameScene.Player;
using LR.UI.GameScene.Stage;
using LR.UI.Lobby;
using LR.UI.Preloading;
using LR.Stage.Player.Enum;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using LR.UI.Enum;

public partial class LocalManager : MonoBehaviour
{
  public static LocalManager instance;

  [SerializeField] private SceneType sceneType;

  [field: SerializeField] public CameraService CameraService { get; private set; }

  [Space(10)]
  [SerializeField] private Transform defaultEffectRoot;
  public StageManager StageManager { get; private set; }
  public DialogueService DialogueService {  get; private set; }
  public ChatCardService ChatCardService { get; private set; }
  public InputProgressService InputProgressService { get; private set; }
  public InputProgressUIService InputProgressUIService { get; private set; }
  public InputQTEService InputQTEService { get; private set; }
  public InputQTEUIService InputQTEUIService { get; private set; }

  private readonly List<IUIPresenter> firstPresenters = new();
  private readonly List<string> releaseKeys = new();
  private readonly CompositeDisposable disposables = new();

  public async UniTask InitializeAsync()
  {
    instance = this;
    InitializeManagers();
    await InitializeSceneAsync();
  }

  public async void Play()
  {
    switch (sceneType)
    {
      case SceneType.Initialize:
        break;

      case SceneType.Preloading:
        {
          foreach(var firstPresenter in firstPresenters)
            firstPresenter?.ActivateAsync().Forget();
        }
        break;

      case SceneType.Lobby:
        {
          foreach (var firstPresenter in firstPresenters)
            firstPresenter?.ActivateAsync().Forget();
        }
        break;

      case SceneType.Game:
        {
          StageManager.SubscribeOnEvent(IStageEventSubscriber.StageEventType.Complete, () =>
          {
            if (StageManager.IsAfterDialoguePlayable())
              DialogueService.Play();
          });

          if (StageManager.IsBeforeDialoguePlayable())
          {
            DialogueService.Play();
          }
          else
          {
            foreach (var firstPresenter in firstPresenters)
              firstPresenter?.ActivateAsync().Forget();
          }
        }        
        break;
    }
  }

  private void InitializeManagers()
  {
    InputQTEUIService = new(
      gameObject,
      GlobalManager.instance.UIManager,
      GlobalManager.instance.ResourceManager,
      GlobalManager.instance.Table.AddressableKeySO);

    InputQTEService = new(
      GlobalManager.instance.FactoryManager.InputActionFactory,
      InputQTEUIService,
      CameraService);

    InputProgressUIService = new(
      gameObject,
      GlobalManager.instance.UIManager,
      GlobalManager.instance.ResourceManager,
      GlobalManager.instance.Table.AddressableKeySO);

    InputProgressService = new(
      GlobalManager.instance.FactoryManager.InputActionFactory,
      InputProgressUIService,
      CameraService);

    ChatCardService = new(
      gameObject,
        GlobalManager.instance.UIManager,
        GlobalManager.instance.ResourceManager,
        GlobalManager.instance.UIManager,
        GlobalManager.instance.Table.AddressableKeySO,
        GlobalManager.instance.Table.ChatCardDatasSO,
        GlobalManager.instance.Table.UISO);
    ChatCardService.AddTo(disposables);

    var stageManagerModel = new StageManager.Model(
      gameObject,
      table: GlobalManager.instance.Table,
      gameDataService: GlobalManager.instance.GameDataService,
      resourceManager: GlobalManager.instance.ResourceManager,
      sceneProvider: GlobalManager.instance.SceneProvider,
      cameraService: CameraService,
      defaultEffectRoot: defaultEffectRoot,
      GlobalManager.instance.FactoryManager.InputActionFactory,
      InputProgressService,
      InputQTEService,
      ChatCardService,
      GlobalManager.instance.UIManager.GetIUIPresenterContainer());
    StageManager = new StageManager(stageManagerModel);
    StageManager.AddTo(disposables);

    DialogueService = new DialogueService();
  }

  private async UniTask InitializeSceneAsync()
  {
    switch (sceneType)
    {
      case SceneType.Initialize:
        {
        }
        break;

      case SceneType.Preloading:
        {
          await CreateFirstUIAsync();
          await LoadPreloadAsync();
          await LoadDialogueAsync();

          var gameDataService = GlobalManager.instance.GameDataService;
#if UNITY_EDITOR
          if (GlobalManager.instance.PlayVeryFirstCutscene)
#else
if(gameDataService.IsVeryFirst())
#endif
          {
            var veryFirstService = GlobalManager.instance.VeryFirstService;

            var adddressableSO = GlobalManager.instance.Table.AddressableKeySO;
            var resourceManager = GlobalManager.instance.ResourceManager;
            var canvasProvider = GlobalManager.instance.UIManager;

            var localeService = GlobalManager.instance.LocaleService;
            var indicatorService = GlobalManager.instance.UIManager.GetIUIIndicatorService();
            var selectedGameObjectService = GlobalManager.instance.UIManager.GetIUISelectedGameObjectService();
            var depthService = GlobalManager.instance.UIManager.GetIUIDepthService();
            var uiInputManager = GlobalManager.instance.UIInputManager;

            await veryFirstService.CreateFirstTimelineAsync(adddressableSO, resourceManager, canvasProvider);

            await veryFirstService.CreateFirstLocaleUI(adddressableSO, resourceManager, canvasProvider);
            await veryFirstService.InitializeFirstLocaleUIAsync(localeService, indicatorService, selectedGameObjectService, depthService, uiInputManager, 
              onConfirm: async () =>
            {              
              await veryFirstService.DestroyFirstLocaleUIAsync(resourceManager);

              var sceneProvider = GlobalManager.instance.SceneProvider;              
              veryFirstService.PlayFirstTimeline(
                onComplete: async () =>
                {
                  gameDataService.SetSelectedStage(0, 1);                  
                  sceneProvider.LoadSceneAsync(
                    SceneType.Game,
                    false,
                    default,
                    null,
                    onComplete: async () =>
                    {
                      UniTask.Delay(10)
                       .ContinueWith(()=> veryFirstService.DestroyCutscene(resourceManager)).Forget();
                    }).Forget();
                });

            });
          }
          else
          {
            var sceneProvider = GlobalManager.instance.SceneProvider;
            sceneProvider.LoadSceneAsync(SceneType.Lobby, false).Forget();
          }            
        }
        break;

      case SceneType.Lobby:
        {
          await CreateFirstUIAsync();
        }
        break;

      case SceneType.Game:
        {
          GlobalManager.instance.GameDataService.GetSelectedStage(out var chapter, out var stage);
          var index = (Mathf.Max(0, chapter - 1)) * 4 + stage;
          await CreateStageAsync(index);
          await CreateFirstUIAsync();
        }
        break;
    }
  }

  private async UniTask CreateStageAsync(int index)
  {
    await StageManager.CreateAsync(index, true);
  }

  private async UniTask CreateFirstUIAsync()
  {
    switch (sceneType)
    {
      case SceneType.Initialize:
        break;

      case SceneType.Preloading:
        {
          await CreatePreloadingUIAsync();
        }
        break;

      case SceneType.Lobby:
        {
          await CreateLobbyUIAsync();
        }
        break;

      case SceneType.Game:
        {
          var playBeforeDialogue = StageManager.IsBeforeDialoguePlayable();
          await CreatePlayerUIsAsync(playBeforeDialogue);
          await CreateStageUIAsync(playBeforeDialogue);
          if(StageManager.IsBeforeDialoguePlayable())
            await CreateDialogueUIAsync();
        }
        break;
    }
  }

  private async UniTask CreatePreloadingUIAsync()
  {
    var model = new UIPreloadingPresenter.Model();

    var table = GlobalManager.instance.Table.AddressableKeySO;
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var root = canvasProvider.GetCanvas(RootType.Overlay).transform;
    var key = table.Path.UI + table.UIName.PreloadingRoot;
    releaseKeys.Add(key);
    var view = await resourceManager.CreateAssetAsync<UIPreloadingView>(key, root);
    var presenter = new UIPreloadingPresenter(model, view);

    firstPresenters.Add(presenter);
    presenter.AttachOnDestroy(gameObject);    
    await presenter.DeactivateAsync(true);    
  }

  private async UniTask CreateLobbyUIAsync()
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var model = new UILobbyRootPresenter.Model(
      localeService: GlobalManager.instance.LocaleService,
      uiManager: GlobalManager.instance.UIManager,
      GlobalManager.instance.Table,
      uiInputManager: GlobalManager.instance.UIInputManager,
      resourceManager: GlobalManager.instance.ResourceManager,
      gameDataService: GlobalManager.instance.GameDataService,
      sceneProvider: GlobalManager.instance.SceneProvider);

    var root = canvasProvider.GetCanvas(RootType.Overlay).transform;
    var key = table.Path.UI + table.UIName.LobbyRoot;
    releaseKeys.Add(key);
    var view = await resourceManager.CreateAssetAsync<UILobbyRootView>(key, root);
    var presenter = new UILobbyRootPresenter(model, view);

    presenter.AttachOnDestroy(gameObject);
    await presenter.ActivateAsync();
  }

  private async UniTask CreatePlayerUIsAsync(bool playBeforeDialogue)
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var root = canvasProvider.GetCanvas(RootType.Overlay).transform;
    var key = table.Path.UI + table.UIName.PlayerRoot;
    releaseKeys.Add(key);
    var viewRoot = await resourceManager.CreateAssetAsync<PlayerRootContainer>(key, root);

    var Leftmodel = new UIPlayerRootPresenter.Model(
      GlobalManager.instance.Table,
      stageManager: StageManager,
      playerType: PlayerType.Left,
      playerGetter: StageManager,
      GlobalManager.instance.UIInputManager,
      GlobalManager.instance.UIManager,
      StageManager.StageDataContainer,
      StageManager,
      GlobalManager.instance.GameDataService,
      GlobalManager.instance.ResourceManager);
    var leftView = viewRoot.leftView;
    var leftPresenter = new UIPlayerRootPresenter(Leftmodel, leftView);
    leftPresenter.AttachOnDestroy(gameObject);

    var rightmodel = new UIPlayerRootPresenter.Model(
      GlobalManager.instance.Table,
      stageManager: StageManager,
      playerType: PlayerType.Right,
      playerGetter: StageManager,
      GlobalManager.instance.UIInputManager,
      GlobalManager.instance.UIManager,
      StageManager.StageDataContainer,
      StageManager,
      GlobalManager.instance.GameDataService,
      GlobalManager.instance.ResourceManager);
    var rightView = viewRoot.rightView;
    var rightPresenter = new UIPlayerRootPresenter(rightmodel, rightView);
    rightPresenter.AttachOnDestroy(gameObject);

    if (playBeforeDialogue)
    {
      DialogueService.SubscribeEvent(IDialogueStateSubscriber.EventType.OnComplete, () =>
      {
        leftPresenter.ActivateAsync().Forget();
        rightPresenter.ActivateAsync().Forget();
      });
    }
    else
    {
      firstPresenters.Add(leftPresenter);
      firstPresenters.Add(rightPresenter);
      leftPresenter.AttachOnDestroy(gameObject); 
      rightPresenter.AttachOnDestroy(gameObject);

      await UniTask.WhenAll(
        leftPresenter.DeactivateAsync(),
        rightPresenter.DeactivateAsync());
    }

    this.OnDestroyAsObservable().Subscribe(_ =>
    {
      if (viewRoot)
        Destroy(viewRoot.gameObject);
    });
  }

  private async UniTask CreateStageUIAsync(bool playBeforeDialogue)
  {
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var key = table.Path.UI + table.UIName.StageRoot;
    releaseKeys.Add(key);
    var root = canvasProvider.GetCanvas(RootType.Overlay).transform;

    var model = new UIStageRootPresenter.Model(
      dialoguePlayableProvider: StageManager,
      dialogueSubscriber: DialogueService,
      stageStateHandler: StageManager,
      stageStateProvider: StageManager,
      stageEventSubscriber: StageManager,
      resourceManager: resourceManager,
      gameDataService: GlobalManager.instance.GameDataService,
      uiManager: GlobalManager.instance.UIManager,
      sceneProvider: GlobalManager.instance.SceneProvider,
      uiInputActionManager: GlobalManager.instance.UIInputManager,
      tableContainer: GlobalManager.instance.Table);
    var view = await resourceManager.CreateAssetAsync<UIStageRootView>(key, root);
    var presenter = new UIStageRootPresenter(model, view);

    if (playBeforeDialogue == false)
      firstPresenters.Add(presenter);
    presenter.AttachOnDestroy(gameObject);
    await presenter.DeactivateAsync(true);
  }

  private async UniTask CreateDialogueUIAsync()
  {
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var key = table.Path.UI + table.UIName.DialogueRoot;
    releaseKeys.Add(key);
    var root = canvasProvider.GetCanvas(RootType.Overlay).transform;

    var model = new UIDialogueRootPresenter.Model(
      table: GlobalManager.instance.Table,
      resourceManager: resourceManager,
      gameDataService: GlobalManager.instance.GameDataService,
      uiInputActionManager: GlobalManager.instance.UIInputManager,
      dialogueDataProvider: StageManager,
      subscriber: DialogueService,
      controller: DialogueService,
      stageStateHandler: StageManager);    
    var view = await resourceManager.CreateAssetAsync<UIDialogueRootView>(key, root);
    var presenter = new UIDialogueRootPresenter(model, view);

    presenter.AttachOnDestroy(gameObject);
    await presenter.ActivateAsync(true);
  }

  private async UniTask LoadPreloadAsync()
  {
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var label = GlobalManager.instance.Table.AddressableKeySO.Label.Preload;
    await resourceManager.LoadAssetsAsync(label);
  }

  private async UniTask LoadDialogueAsync()
  {
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var label = GlobalManager.instance.Table.AddressableKeySO.Label.Dialogue;
    await resourceManager.LoadAssetsAsync(label);
  }

  private void OnDestroy()
  {
    foreach (var key in releaseKeys)
      GlobalManager.instance.ResourceManager.ReleaseAsset(key);
    disposables.Dispose();
  }
}
