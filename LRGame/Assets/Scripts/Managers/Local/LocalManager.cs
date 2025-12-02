using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using LR.UI.Preloading;
using LR.UI.Lobby;
using LR.UI.GameScene.Stage;
using LR.UI.GameScene.Player;

public class LocalManager : MonoBehaviour
{
  [SerializeField] private SceneType sceneType;
  public static LocalManager instance;

  private StageManager stageManager;
  public StageManager StageManager => stageManager;

  private IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
  private ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;

  private async void Awake()
  {
    instance = this;
    InitializeManagers();

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

  private void InitializeManagers()
  {
    stageManager = new StageManager(
      resourceManager: GlobalManager.instance.ResourceManager,
      sceneProvider: GlobalManager.instance.SceneProvider);
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
    presenter.ShowAsync().Forget();
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
    var view = await resourceManager.CreateAssetAsync<UILobbyViewContainer>(table.Path.Ui + table.UIName.LobbyRoot, root);

    var presenter = new UILobbyRootPresenter(model, view);
    presenter.AttachOnDestroy(gameObject);
    presenter.ShowAsync().Forget();
  }

  private async UniTask CreatePlayerUIAsync()
  {
    var model = new UIPlayerRootPresenter.Model();

    var table = GlobalManager.instance.Table.AddressableKeySO;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UIPlayerRootViewContainer>(table.Path.Ui + table.UIName.PlayerRoot, root);

    var presenter = new UIPlayerRootPresenter(model, view);
    presenter.AttachOnDestroy(gameObject);
    presenter.ShowAsync().Forget();
  }

  private async UniTask CreateStageUIAsync()
  {
    var model = new UIStageRootPresenter.Model(
   InputActionPaths.Keyboard.W, OnStageBegin,
   InputActionPaths.Keyboard.Up, OnStageRestart,
   InputActionPaths.Keyboard.A, OnReturnToLobby,
   InputActionPaths.Keyboard.D, OnNextStage,
   stageController: stageManager,
   presenterContainer: GlobalManager.instance.UIManager,
   resourceManager: resourceManager,
   gameDataService: GlobalManager.instance.GameDataService,
   inputActionFactory: GlobalManager.instance.FactoryManager.InputActionFactory);

    var table = GlobalManager.instance.Table.AddressableKeySO;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UIStageRootViewContainer>(table.Path.Ui + table.UIName.StageRoot, root);

    var presenter = new UIStageRootPresenter(model, view);
    presenter.AttachOnDestroy(gameObject);

    presenter.ShowAsync().Forget();
  }

  private async UniTask LoadPreloadAsync()
  {
    var label = GlobalManager.instance.Table.AddressableKeySO.Label.PreLoad;
    await resourceManager.LoadAssetsAsync(label);
  }

  private void OnStageBegin()
  {
  }

  private void OnStageRestart()
  {
  }

  private void OnReturnToLobby()
  {
  }

  private void OnNextStage()
  {
  }

  #region DebugginMethods
  public void Debugging_StageComplete()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageController stageController = StageManager;
    stageController.Complete();
  }

  public void Debugging_StageLeftFail()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageController stageController = StageManager;
    stageController.OnLeftFailed();
  }

  public void Debugging_StageRightFail()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageController stageController = StageManager;
    stageController.OnRightFailed();
  }

  public void Debugging_StageRestart()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageController stageController = StageManager;
    stageController.RestartAsync().Forget();
  }

  public async void Debugging_LeftPlayerHPDamaged(int value)
  {
    IPlayerHPController hpController = await StageManager.GetPresenterAsync(PlayerType.Left);
    hpController.DamageHP(value);
  }

  public async void Debugging_LeftPlayerHPRestored(int value)
  {
    IPlayerHPController hpController = await StageManager.GetPresenterAsync(PlayerType.Left);
    hpController.RestoreHP(value);
  }

  public async void Debugging_RightPlayerHPDamaged(int value)
  {
    IPlayerHPController hpController = await StageManager.GetPresenterAsync(PlayerType.Right);
    hpController.DamageHP(value);
  }

  public async void Debugging_RightPlayerHPRestored(int value)
  {
    IPlayerHPController hpController = await StageManager.GetPresenterAsync(PlayerType.Right);
    hpController.RestoreHP(value);
  }
  #endregion
}
