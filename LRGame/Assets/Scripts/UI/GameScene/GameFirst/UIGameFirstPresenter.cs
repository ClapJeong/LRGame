using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.GameScene
{
  public class UIGameFirstPresenter : IUIPresenter
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

      public Model((string,UnityAction) beginPair,(string,UnityAction) restartPair, (string,UnityAction)lobbyPair,(string,UnityAction)nextPair)
      {
        this.beginInputActionPath = beginPair.Item1;
        this.onBeginStage = beginPair.Item2;

        this.restartInputActionPath = restartPair.Item1;
        this.onRestartStage = restartPair.Item2;

        this.lobbyInputActionPath = lobbyPair.Item1;
        this.onLobby = beginPair.Item2;

        this.nextInputActionPath = nextPair.Item1;
        this.onNext = nextPair.Item2;
      }
    }

    private readonly Model model;
    private readonly UIGameFirstViewContainer viewContainer;

    private readonly UIStageBeginPresenter beginPresenter;
    private readonly UIStageFailPresenter failPresenter;
    private readonly UIStageSuccessPresenter successPresenter;

    public UIGameFirstPresenter(Model model, UIGameFirstViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      this.beginPresenter = CreateBeginPresenter();
      this.failPresenter = CreateFailPresenter();
      this.successPresenter = CreateSuccessPresenter();

      beginPresenter.ShowAsync(true).Forget();
      failPresenter.HideAsync(true).Forget();
      successPresenter.HideAsync(true).Forget();

      IStageController stageController = LocalManager.instance.StageManager;
      stageController.SubscribeOnEvent(IStageController.StageEventType.Complete,OnStageSuccess);
      stageController.SubscribeOnEvent(IStageController.StageEventType.LeftFailed, OnStageFailed);
      stageController.SubscribeOnEvent(IStageController.StageEventType.RightFailed, OnStageFailed);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public void Dispose()
    {
      IUIPresenterContainer presenterContainer = GlobalManager.instance.UIManager;
      presenterContainer.Remove(this);

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


    private UIStageBeginPresenter CreateBeginPresenter()
    {
      var model = new UIStageBeginPresenter.Model(this.model.beginInputActionPath, OnStageBeginInput,0.5f,0.5f);
      var beginView = viewContainer.beginViewContainer;
      IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
      presenterFactory.Register(() => new UIStageBeginPresenter(model, beginView));
      return presenterFactory.Create<UIStageBeginPresenter>();
    }

    private UIStageFailPresenter CreateFailPresenter()
    {
      var model = new UIStageFailPresenter.Model(0.8f, 0.4f, this.model.restartInputActionPath,OnStageRestartInput);
      var failView = viewContainer.failViewContainer;
      IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
      presenterFactory.Register(() => new UIStageFailPresenter(model, failView));
      return presenterFactory.Create<UIStageFailPresenter>();
    }

    private UIStageSuccessPresenter CreateSuccessPresenter()
    {
      var model = new UIStageSuccessPresenter.Model(
        0.5f,
        this.model.restartInputActionPath,
        this.model.nextInputActionPath,
        this.model.lobbyInputActionPath,
        OnStageRestartInput,
        OnStageNextInput,
        OnReturnToLobbyInput);
      var view = viewContainer.successViewContainer;
      IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
      presenterFactory.Register(()=> new UIStageSuccessPresenter(model, view));
      return presenterFactory.Create<UIStageSuccessPresenter>();
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
      GlobalManager.instance.selectedStage = 0;
      ISceneProvider sceneProvider = GlobalManager.instance.SceneProvider;
      sceneProvider.LoadSceneAsync(SceneType.Lobby).Forget();
    }

    private void OnStageNextInput()
    {
      var table = GlobalManager.instance.Table.AddressableKeySO;
      ISceneProvider sceneProvider = GlobalManager.instance.SceneProvider;
      GlobalManager.instance.selectedStage++;
      sceneProvider.ReloadCurrentSceneAsync().Forget();
    }
    #endregion
  }
}