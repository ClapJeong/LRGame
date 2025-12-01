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
          await CreateStageAsync(GlobalManager.instance.selectedStage);
        }
        break;
    }   
  }

  private void InitializeManagers()
  {
    stageManager = new StageManager();
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
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UIPreloadingView>(table.Path.Ui + table.UIName.PreloadingRoot, root);

    IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
    presenterFactory.Register(() => new UIPreloadingPresenter(model, view));
    var presenter = presenterFactory.Create<UIPreloadingPresenter>();
    presenter.AttachOnDestroy(gameObject);
    presenter.ShowAsync().Forget();
  }

  private async UniTask CreateLobbyUIAsync()
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var model = new UILobbyRootPresenter.Model(table.Path.Scene + table.SceneName.Game);

    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UILobbyViewContainer>(table.Path.Ui + table.UIName.LobbyRoot, root);

    IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
    presenterFactory.Register(() => new UILobbyRootPresenter(model, view));
    var presenter = presenterFactory.Create<UILobbyRootPresenter>();
    presenter.AttachOnDestroy(gameObject);
    presenter.ShowAsync().Forget();
  }

  private async UniTask CreatePlayerUIAsync()
  {
    var model = new UIPlayerRootPresenter.Model();

    var table = GlobalManager.instance.Table.AddressableKeySO;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UIPlayerRootViewContainer>(table.Path.Ui + table.UIName.PlayerRoot, root);

    IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
    presenterFactory.Register(() => new UIPlayerRootPresenter(model, view));
    var presenter = presenterFactory.Create<UIPlayerRootPresenter>();
    presenter.AttachOnDestroy(gameObject);
    presenter.ShowAsync().Forget();
  }

  private async UniTask CreateStageUIAsync()
  {
    var model = new UIStageRootPresenter.Model(
   beginPair: (InputActionPaths.Keyboard.W, OnStageBegin),
   restartPair: (InputActionPaths.Keyboard.Up, OnStageRestart),
   lobbyPair: (InputActionPaths.Keyboard.A, OnReturnToLobby),
   nextPair: (InputActionPaths.Keyboard.D, OnNextStage)
 ); ;

    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    ICanvasProvider canvasProvider = GlobalManager.instance.UIManager;
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var root = canvasProvider.GetCanvas(UIRootType.Overlay).transform;
    var view = await resourceManager.CreateAssetAsync<UIStageRootViewContainer>(table.Path.Ui + table.UIName.StageRoot, root);

    IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
    presenterFactory.Register(() => new UIStageRootPresenter(model, view));
    var presenter = presenterFactory.Create<UIStageRootPresenter>();
    presenter.AttachOnDestroy(gameObject);

    presenter.ShowAsync().Forget();
  }

  private async UniTask LoadPreloadAsync()
  {
    var label = GlobalManager.instance.Table.AddressableKeySO.Label.PreLoad;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
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
