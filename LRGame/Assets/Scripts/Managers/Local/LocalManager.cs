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
        }
        break;
    }   
  }

  private void InitializeManagers()
  {
    stageManager = new StageManager();
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
          var model = new UIPreloadingPresenter.Model();
          var view = firstUiVeiw.GetComponent<UIPreloadingView>();
          presenterFactory.Register(() => new UIPreloadingPresenter(model, view));
          var presenter = presenterFactory.Create<UIPreloadingPresenter>();
          presenter.AttachOnDestroy(gameObject);
        }
        break;

      case SceneType.Lobby:
        {
          var table = GlobalManager.instance.Table.AddressableKeySO;
          var model = new UILobbyFirstPresenter.Model(table.Path.Scene + table.SceneName.Game);
          var view = firstUiVeiw.GetComponent<UILobbyViewContainer>();
          presenterFactory.Register(() => new UILobbyFirstPresenter(model, view));
          var presenter = presenterFactory.Create<UILobbyFirstPresenter>();
          presenter.AttachOnDestroy(gameObject);
        }
        break;

      case SceneType.Game:
        break;
    }

  }

  private async UniTask LoadPreloadAsync()
  {
    var label = GlobalManager.instance.Table.AddressableKeySO.Label.PreLoad;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
    await resourceManager.LoadAssetsAsync(label);
  }
}
