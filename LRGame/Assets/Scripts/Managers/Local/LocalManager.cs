using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using LR.UI.Preloading;
using LR.UI.Lobby;
using LR.UI.Player;
using LR.UI.Stage;

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
    IUIResourceService uiResourceService = GlobalManager.instance.UIManager;
    var view = await uiResourceService.CreateViewAsync<UIPreloadingView>(table.Path.Ui + table.UIName.PreloadingRoot,UIRootType.Overlay);

    IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
    presenterFactory.Register(() => new UIPreloadingPresenter(model, view));
    var presenter = presenterFactory.Create<UIPreloadingPresenter>();
    presenter.AttachOnDestroy(gameObject);
    presenter.ShowAsync().Forget();
  }

  private async UniTask CreateLobbyUIAsync()
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var model = new UILobbyFirstPresenter.Model(table.Path.Scene + table.SceneName.Game);

    IUIResourceService uiResourceService = GlobalManager.instance.UIManager;
    var view = await uiResourceService.CreateViewAsync<UILobbyViewContainer>(table.Path.Ui + table.UIName.LobbyRoot, UIRootType.Overlay);

    IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
    presenterFactory.Register(() => new UILobbyFirstPresenter(model, view));
    var presenter = presenterFactory.Create<UILobbyFirstPresenter>();
    presenter.AttachOnDestroy(gameObject);
    presenter.ShowAsync().Forget();
  }

  private async UniTask CreatePlayerUIAsync()
  {
    var model = new UIPlayerRootPresenter.Model();

    var table = GlobalManager.instance.Table.AddressableKeySO;
    IUIResourceService uiResourceService = GlobalManager.instance.UIManager;
    var view = await uiResourceService.CreateViewAsync<UIPlayerRootViewContainer>(table.Path.Ui + table.UIName.PlayerRoot, UIRootType.Overlay);

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

    IUIResourceService uiResourceService = GlobalManager.instance.UIManager;
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var view = await uiResourceService.CreateViewAsync<UIStageRootViewContainer>(table.Path.Ui + table.UIName.StageRoot, UIRootType.Overlay);

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
  #endregion
}
