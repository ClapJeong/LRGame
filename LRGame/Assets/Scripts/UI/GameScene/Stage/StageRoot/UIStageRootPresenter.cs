using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.GameScene.Stage
{
  public class UIStageRootPresenter : IUIPresenter
  {
    public class Model
    {
      public string beginInputActionPath;
      public string restartInputActionPath;
      public string lobbyInputActionPath;
      public string nextInputActionPath;

      public UnityAction onBeginStage;
      public UnityAction onRestartStage;
      public UnityAction onLobby;
      public UnityAction onNext;

      public IStageController stageController;
      public IUIPresenterContainer presenterContainer;
      public IResourceManager resourceManager;
      public IGameDataService gameDataService;
      public InputActionFactory inputActionFactory;


      public Model(
        string beginInputActionPath, UnityAction onBeginStage,
        string restartInputActionPath, UnityAction onRestartStage,
        string lobbyInputActionPath, UnityAction onLobby,
        string nextInputActionPath, UnityAction onNext,
        IStageController stageController, 
        IUIPresenterContainer presenterContainer,
        IResourceManager resourceManager,
        IGameDataService gameDataService,
        InputActionFactory inputActionFactory)
      {
        this.beginInputActionPath = beginInputActionPath;
        this.restartInputActionPath = restartInputActionPath;
        this.lobbyInputActionPath = lobbyInputActionPath;
        this.nextInputActionPath = nextInputActionPath;
        this.onBeginStage = onBeginStage;
        this.onRestartStage = onRestartStage;
        this.onLobby = onLobby;
        this.onNext = onNext;
        this.stageController = stageController;
        this.presenterContainer = presenterContainer;
        this.resourceManager = resourceManager;
        this.gameDataService = gameDataService;
        this.inputActionFactory = inputActionFactory;
      }
    }

    private readonly Model model;
    private readonly UIStageRootViewContainer viewContainer;

    private UIStageBeginPresenter beginPresenter;
    private UIStageFailPresenter failPresenter;
    private UIStageSuccessPresenter successPresenter;


    public UIStageRootPresenter(Model model, UIStageRootViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      CreateBeginPresenter();
      CreateFailPresenter();
      CreateSuccessPresenter();

      beginPresenter.ShowAsync(true).Forget();
      failPresenter.HideAsync(true).Forget();
      successPresenter.HideAsync(true).Forget();

      model.stageController.SubscribeOnEvent(IStageController.StageEventType.Complete,OnStageSuccess);
      model.stageController.SubscribeOnEvent(IStageController.StageEventType.LeftFailed, OnStageFailed);
      model.stageController.SubscribeOnEvent(IStageController.StageEventType.RightFailed, OnStageFailed);

      model.presenterContainer.Add(this);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public void Dispose()
    {
      model.presenterContainer.Remove(this);

      if(viewContainer)
        GameObject.Destroy(viewContainer.gameObject);
    }

    public UIVisibleState GetVisibleState()
      => UIVisibleState.Showed;

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
      => throw new NotImplementedException();

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    private void CreateBeginPresenter()
    {
      var model = new UIStageBeginPresenter.Model(this.model.beginInputActionPath, OnStageBeginInput,0.5f,0.5f);
      var beginView = viewContainer.beginViewContainer;
      beginPresenter = new UIStageBeginPresenter(model, beginView);
      beginPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void CreateFailPresenter()
    {
      var model = new UIStageFailPresenter.Model(0.8f, 0.4f, this.model.restartInputActionPath,OnStageRestartInput);
      var failView = viewContainer.failViewContainer;
      failPresenter = new UIStageFailPresenter(model, failView);
      failPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void CreateSuccessPresenter()
    {
      var model = new UIStageSuccessPresenter.Model(
        0.5f,
        this.model.restartInputActionPath,
        this.model.nextInputActionPath,
        this.model.lobbyInputActionPath,
        OnStageRestartInput,
        OnStageNextInput,
        OnReturnToLobbyInput,
        resourceManager: this.model.resourceManager,
        gameDataService: this.model.gameDataService,
        inputActionFactory: this.model.inputActionFactory);
      var view = viewContainer.successViewContainer;
      successPresenter = new UIStageSuccessPresenter(model, view);
      successPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    #region Callbacks
    private void OnStageBeginInput()
    {
      beginPresenter.HideAsync().Forget();
      IStageController stageController = LocalManager.instance.StageManager;
      stageController.Begin();      

      model.onBeginStage?.Invoke();
    }

    private void OnStageRestartInput()
    {
      successPresenter.HideAsync().Forget();
      failPresenter.HideAsync().Forget();
      IStageController stageController = LocalManager.instance.StageManager;
      stageController.RestartAsync().Forget();
      
      model.onRestartStage?.Invoke();
    }

    private void OnStageFailed()
    {
      failPresenter.ShowAsync().Forget();
    }

    private void OnStageSuccess()
    {
      successPresenter.ShowAsync(false).Forget();
    }

    private void OnReturnToLobbyInput()
    {
      GlobalManager.instance.GameDataService.SetSelectedStage(-1, -1);
      ISceneProvider sceneProvider = GlobalManager.instance.SceneProvider;
      sceneProvider.LoadSceneAsync(SceneType.Lobby).Forget();
    }

    private void OnStageNextInput()
    {
      var table = GlobalManager.instance.Table.AddressableKeySO;
      ISceneProvider sceneProvider = GlobalManager.instance.SceneProvider;
      sceneProvider.ReloadCurrentSceneAsync().Forget();
    }
    #endregion
  }
}