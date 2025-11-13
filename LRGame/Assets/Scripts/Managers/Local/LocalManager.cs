using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;

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
    IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
    IFirstUICreator firstUICreator = GlobalManager.instance.UIManager;
    var firstUiVeiw = await firstUICreator.CreateFirstUIViewAsync(sceneType);
    switch (sceneType)
    {
      case SceneType.Initialize:
        break;

      case SceneType.Preloading:
        {
          CreatePreloadingUI(presenterFactory, firstUiVeiw);
        }
        break;

      case SceneType.Lobby:
        {
          CreateLobbyUI(presenterFactory, firstUiVeiw);
        }
        break;

      case SceneType.Game:
        {
          CreateGameUI(presenterFactory, firstUiVeiw);
        }
        break;
    }
  }

  private void CreatePreloadingUI(IUIPresenterFactory presenterFactory, GameObject viewGameObject)
  {
    var model = new UIPreloadingPresenter.Model();
    var view = viewGameObject.GetComponent<UIPreloadingView>();
    presenterFactory.Register(() => new UIPreloadingPresenter(model, view));
    var presenter = presenterFactory.Create<UIPreloadingPresenter>();
    presenter.AttachOnDestroy(gameObject);
  }

  private void CreateLobbyUI(IUIPresenterFactory presenterFactory,GameObject viewGameObject)
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var model = new UILobbyFirstPresenter.Model(table.Path.Scene + table.SceneName.Game);
    var view = viewGameObject.GetComponent<UILobbyViewContainer>();
    presenterFactory.Register(() => new UILobbyFirstPresenter(model, view));
    var presenter = presenterFactory.Create<UILobbyFirstPresenter>();
    presenter.AttachOnDestroy(gameObject);
  }

  private void CreateGameUI(IUIPresenterFactory presenterFactory, GameObject viewGameObject)
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var model = new UIGameFirstPresenter.Model(
      InputActionPaths.Keyboard.W,
      InputActionPaths.Keyboard.Up,
      () =>
      {
        IStageController stageController = StageManager;
        stageController.Begin();
      },
      () =>
      {
        IStageCreator stageCreator = StageManager;
        stageCreator.ReStartAsync().Forget();
      }
      );
    var view = viewGameObject.GetComponent<UIGameFirstViewContainer>();
    presenterFactory.Register(() => new UIGameFirstPresenter(model, view));
    var presenter = presenterFactory.Create<UIGameFirstPresenter>();
    presenter.AttachOnDestroy(gameObject);

    IStageController stageController = StageManager;
    StageManager.SubscribeOnEvent(IStageController.StageEventType.LeftFailed, presenter.EnableRestartGuide);
    StageManager.SubscribeOnEvent(IStageController.StageEventType.RightFailed, presenter.EnableRestartGuide);
  }

  private async UniTask LoadPreloadAsync()
  {
    var label = GlobalManager.instance.Table.AddressableKeySO.Label.PreLoad;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    await resourceManager.LoadAssetsAsync(label);
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

    IStageCreator stageCreator = StageManager;
    stageCreator.ReStartAsync().Forget();
  }
  #endregion
}
