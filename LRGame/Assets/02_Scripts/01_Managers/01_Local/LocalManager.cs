using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using LR.UI.Preloading;
using LR.UI.Lobby;
using LR.UI.GameScene.Stage;
using LR.UI.GameScene.Player;
using LR.Stage.Player;

public class LocalManager : MonoBehaviour
{
  [SerializeField] private SceneType sceneType;
  public static LocalManager instance;

  private StageManager stageManager;
  public StageManager StageManager => stageManager;

  [SerializeField] private CameraService cameraService;
  public CameraService CameraService => cameraService;

  private IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
  private ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;

  private void Awake()
  {
    instance = this;
    InitializeManagers();
    InitializeSceneAsync().Forget();
  }

  private void InitializeManagers()
  {
    var model = new StageManager.Model(
      resourceManager: GlobalManager.instance.ResourceManager,
      sceneProvider: GlobalManager.instance.SceneProvider,
      cameraService: cameraService);
    stageManager = new StageManager(model);
  }

  private async UniTask InitializeSceneAsync()
  {
    switch (sceneType)
    {
      case SceneType.Initialize:
        {
          GlobalManager.instance.SceneProvider.LoadSceneAsync(SceneType.Preloading, CancellationToken.None).Forget();
        }
        break;

      case SceneType.Preloading:
        {
          await CreateFirstUIAsync();
          await LoadPreloadAsync();
          ISceneProvider sceneProvider = GlobalManager.instance.SceneProvider;
          sceneProvider.LoadSceneAsync(SceneType.Lobby, CancellationToken.None).Forget();
        }
        break;

      case SceneType.Lobby:
        {
          await CreateFirstUIAsync();
        }
        break;

      case SceneType.Game:
        {
          await CreateFirstUIAsync();
          GlobalManager.instance.GameDataService.GetSelectedStage(out var chapter, out var stage);
          var index = chapter * 4 + stage;
          await CreateStageAsync(index);
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
          await CreatePlayerUIAsync();
          await CreateStageUIAsync();
        }
        break;
    }
  }

  private async UniTask CreatePreloadingUIAsync()
  {
    var model = new UIPreloadingPresenter.Model();

    var table = GlobalManager.instance.Table.AddressableKeySO;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UIPreloadingView>(table.Path.Ui + table.UIName.PreloadingRoot, root);

    var presenter = new UIPreloadingPresenter(model, view);
    presenter.AttachOnDestroy(gameObject);
    presenter.ActivateAsync().Forget();
  }

  private async UniTask CreateLobbyUIAsync()
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var model = new UILobbyRootPresenter.Model(
      uiManager: GlobalManager.instance.UIManager,
      uiInputManager: GlobalManager.instance.UIInputManager,
      resourceManager: GlobalManager.instance.ResourceManager,
      gameDataService: GlobalManager.instance.GameDataService,
      sceneProvider: GlobalManager.instance.SceneProvider);

    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UILobbyRootView>(table.Path.Ui + table.UIName.LobbyRoot, root);

    var presenter = new UILobbyRootPresenter(model, view);
    presenter.AttachOnDestroy(gameObject);
    presenter.ActivateAsync().Forget();
  }

  private async UniTask CreatePlayerUIAsync()
  {
    var model = new UIPlayerRootPresenter.Model(
      stageManager: stageManager);

    var table = GlobalManager.instance.Table.AddressableKeySO;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UIPlayerRootView>(table.Path.Ui + table.UIName.PlayerRoot, root);

    var presenter = new UIPlayerRootPresenter(model, view);
    presenter.AttachOnDestroy(gameObject);
    presenter.ActivateAsync().Forget();
  }

  private async UniTask CreateStageUIAsync()
  {
    var model = new UIStageRootPresenter.Model(
      stageService: stageManager,
      resourceManager: resourceManager,
      gameDataService: GlobalManager.instance.GameDataService,
      uiManager: GlobalManager.instance.UIManager,
      sceneProvider: GlobalManager.instance.SceneProvider,
      uiInputActionManager: GlobalManager.instance.UIInputManager);

    var table = GlobalManager.instance.Table.AddressableKeySO;
    var key = table.Path.Ui + table.UIName.StageRoot;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UIStageRootView>(key, root);

    var presenter = new UIStageRootPresenter(model, view);
    presenter.AttachOnDestroy(gameObject);
    presenter.ActivateAsync().Forget();
  }

  private async UniTask LoadPreloadAsync()
  {
    var label = GlobalManager.instance.Table.AddressableKeySO.Label.PreLoad;
    await resourceManager.LoadAssetsAsync(label);
  }

  #region DebugginMethods
  public void Debugging_StageComplete()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageService stageService = StageManager;
    stageService.Complete();
  }

  public void Debugging_StageLeftFail()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageService stageService = StageManager;
    stageService.OnLeftExhausted();
  }

  public void Debugging_StageRightFail()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageService stageService = StageManager;
    stageService.OnRightExhaused();
  }

  public void Debugging_StageRestart()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageService stageService = StageManager;
    stageService.RestartAsync().Forget();
  }

  public async void Debugging_LeftPlayeEnergyDamaged(float value)
  {
    var leftPlayer = await StageManager.GetPresenterAsync(PlayerType.Left);
    leftPlayer
      .GetEnergyController()
      .Damage(value);
  }

  public async void Debugging_LeftPlayerEnergyRestored(float value)
  {
    var leftPlayer = await StageManager.GetPresenterAsync(PlayerType.Left);
    leftPlayer
      .GetEnergyController()
      .Restore(value);
  }

  public async void Debugging_RightPlayerEnergyDamaged(float value)
  {
    var rightPlayer = await StageManager.GetPresenterAsync(PlayerType.Right);
    rightPlayer
      .GetEnergyController()
      .Damage(value);
  }

  public async void Debugging_RightPlayerEnergyRestored(float value)
  {
    var rightPlayer = await StageManager.GetPresenterAsync(PlayerType.Right);
    rightPlayer
      .GetEnergyController()
      .Restore(value);
  }
  #endregion
}
