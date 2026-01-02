using Cysharp.Threading.Tasks;
using LR.UI.GameScene.Dialogue;
using LR.UI.GameScene.Player;
using LR.UI.GameScene.Stage;
using LR.UI.Lobby;
using LR.UI.Preloading;
using System.Threading;
using System.Threading.Tasks;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class LocalManager : MonoBehaviour
{
  public static LocalManager instance;

  [SerializeField] private SceneType sceneType;

  [field: SerializeField] public CameraService CameraService { get; private set; }

  [Space(10)]
  [SerializeField] private Transform defaultEffectRoot;
  public StageManager StageManager { get; private set; }
  public DialogueService DialogueService {  get; private set; }
  private bool isSceneInitialized = false;

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
        break;

      case SceneType.Lobby:
        break;

      case SceneType.Game:
        {
          await UniTask.WaitUntil(() => isSceneInitialized);
          DialogueService.Play();
        }        
        break;
    }
  }

  private void InitializeManagers()
  {
    var model = new StageManager.Model(
      table: GlobalManager.instance.Table,
      gameDataService: GlobalManager.instance.GameDataService,
      resourceManager: GlobalManager.instance.ResourceManager,
      sceneProvider: GlobalManager.instance.SceneProvider,
      cameraService: CameraService,
      defaultEffectRoot: defaultEffectRoot);
    StageManager = new StageManager(model);

    DialogueService = new DialogueService(StageManager);
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
          ISceneProvider sceneProvider = GlobalManager.instance.SceneProvider;
          sceneProvider.LoadSceneAsync(SceneType.Lobby, false).Forget();
        }
        break;

      case SceneType.Lobby:
        {
          await CreateFirstUIAsync();
          isSceneInitialized = true;
        }
        break;

      case SceneType.Game:
        {
          GlobalManager.instance.GameDataService.GetSelectedStage(out var chapter, out var stage);
          var index = chapter * 4 + stage;
          await CreateStageAsync(index);
          await CreateFirstUIAsync();
          isSceneInitialized = true;
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
          await CreatePlayerUIsAsync();
          await CreateStageUIAsync();
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
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UIPreloadingView>(table.Path.UI + table.UIName.PreloadingRoot, root);

    var presenter = new UIPreloadingPresenter(model, view);
    presenter.AttachOnDestroy(gameObject);
    presenter.ActivateAsync().Forget();
  }

  private async UniTask CreateLobbyUIAsync()
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var model = new UILobbyRootPresenter.Model(
      uiManager: GlobalManager.instance.UIManager,
      uiInputManager: GlobalManager.instance.UIInputManager,
      resourceManager: GlobalManager.instance.ResourceManager,
      gameDataService: GlobalManager.instance.GameDataService,
      sceneProvider: GlobalManager.instance.SceneProvider);

    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UILobbyRootView>(table.Path.UI + table.UIName.LobbyRoot, root);

    var presenter = new UILobbyRootPresenter(model, view);
    presenter.AttachOnDestroy(gameObject);
    await presenter.ActivateAsync();
  }

  private async UniTask CreatePlayerUIsAsync()
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var viewRoot = await resourceManager.CreateAssetAsync<PlayerRootContainer>(table.Path.UI + table.UIName.PlayerRoot, root);

    var Leftmodel = new UIPlayerRootPresenter.Model(
      stageManager: StageManager,
      playerType: PlayerType.Left,
      playerGetter: StageManager);
    var leftView = viewRoot.leftView;

    var leftPresenter = new UIPlayerRootPresenter(Leftmodel, leftView);
    leftPresenter.AttachOnDestroy(gameObject);
    leftPresenter.DeactivateAsync().Forget();

    var rightmodel = new UIPlayerRootPresenter.Model(
      stageManager: StageManager,
      playerType: PlayerType.Right,
      playerGetter: StageManager);
    var rightView = viewRoot.rightView;

    var rightPresenter = new UIPlayerRootPresenter(rightmodel, rightView);
    rightPresenter.AttachOnDestroy(gameObject);
    rightPresenter.DeactivateAsync().Forget();

    DialogueService.SubscribeEvent(IDialogueSubscriber.EventType.OnComplete, () =>
    {
      if (leftPresenter.GetVisibleState() == UIVisibleState.Hidden)
        leftPresenter.ActivateAsync().Forget();
      if (rightPresenter.GetVisibleState() == UIVisibleState.Hidden)
        rightPresenter.ActivateAsync().Forget();
    });

    this.OnDestroyAsObservable().Subscribe(_ =>
    {
      if (viewRoot)
        Destroy(viewRoot.gameObject);
    });
  }

  private async UniTask CreateStageUIAsync()
  {
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    var model = new UIStageRootPresenter.Model(
      dialogueSubscriber: DialogueService,
      stageStateHandler: StageManager,
      stageEventSubscriber: StageManager,
      resourceManager: resourceManager,
      gameDataService: GlobalManager.instance.GameDataService,
      uiManager: GlobalManager.instance.UIManager,
      sceneProvider: GlobalManager.instance.SceneProvider,
      uiInputActionManager: GlobalManager.instance.UIInputManager);

    var table = GlobalManager.instance.Table.AddressableKeySO;
    var key = table.Path.UI + table.UIName.StageRoot;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UIStageRootView>(key, root);

    var presenter = new UIStageRootPresenter(model, view);
    presenter.AttachOnDestroy(gameObject);
  }

  private async UniTask CreateDialogueUIAsync()
  {
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;

    var model = new UIDialogueRootPresenter.Model(
      table: GlobalManager.instance.Table,
      resourceManager: resourceManager,
      gameDataService: GlobalManager.instance.GameDataService,
      uiInputActionManager: GlobalManager.instance.UIInputManager,
      dialogueDataProvider: StageManager,
      subscriber: DialogueService,
      controller: DialogueService,
      stageStateHandler: StageManager);
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var key = table.Path.UI + table.UIName.DialogueRoot;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UIDialogueRootView>(key, root);

    var presenter = new UIDialogueRootPresenter(model, view);
    presenter.AttachOnDestroy(gameObject);
    await presenter.DeactivateAsync();
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


  #region DebugginMethods
  public void Debugging_StageComplete()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageStateHandler stageStateHandler = StageManager;
    stageStateHandler.Complete();    
  }

  public void Debugging_StageLeftFail()
  {
    if (sceneType != SceneType.Game)
      return;

    var leftPlayer = StageManager.GetPlayer(PlayerType.Left);
    leftPlayer.GetEnergyController().Damage(float.MaxValue, ignoreInvincible: true);
  }

  public void Debugging_StageRightFail()
  {
    if (sceneType != SceneType.Game)
      return;

    var rightPlayer = StageManager.GetPlayer(PlayerType.Right);
    rightPlayer.GetEnergyController().Damage(float.MaxValue, ignoreInvincible: true);
  }

  public void Debugging_StageRestart()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageStateHandler stageService = StageManager;
    stageService.RestartAsync().Forget();
  }

  public void Debugging_LeftPlayeEnergyDamaged(float value)
  {
    if (StageManager.IsAllPlayerExist() == false)
      return;

    var leftPlayer = StageManager.GetPlayer(PlayerType.Left);
    leftPlayer
      .GetEnergyController()
      .Damage(value, true);
  }

  public void Debugging_LeftPlayerEnergyRestored(float value)
  {
    if (StageManager.IsAllPlayerExist() == false)
      return;
    
    var leftPlayer = StageManager.GetPlayer(PlayerType.Left);
    leftPlayer
      .GetEnergyController()
      .Restore(value);
  }

  public void Debugging_RightPlayerEnergyDamaged(float value)
  {
    if (StageManager.IsAllPlayerExist() == false)
      return;
    
    var rightPlayer = StageManager.GetPlayer(PlayerType.Right);
    rightPlayer
      .GetEnergyController()
      .Damage(value, true);
  }

  public void Debugging_RightPlayerEnergyRestored(float value)
  {
    if (StageManager.IsAllPlayerExist() == false)
      return; 
    
    var rightPlayer = StageManager.GetPlayer(PlayerType.Right);
    rightPlayer
      .GetEnergyController()
      .Restore(value);
  }
  #endregion
}
