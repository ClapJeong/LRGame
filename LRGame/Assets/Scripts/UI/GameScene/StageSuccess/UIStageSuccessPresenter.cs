using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace LR.UI.GameScene.Stage
{
  public class UIStageSuccessPresenter : IUIPresenter
  {
    public class Model
    {
      public float showDuration;

      public string restartPath;
      public string nextPath;
      public string lobbyPath;

      public UnityAction onRestart;
      public UnityAction onNext;
      public UnityAction onLobby;

      public IResourceManager resourceManager;
      public IGameDataService gameDataService;
      public InputActionFactory inputActionFactory;

      public Model(
        float showDuration, 
        string restartPath,
        string nextPath,
        string lobbyPath, 
        UnityAction onRestart, 
        UnityAction onNext,
        UnityAction onLobby,
        IResourceManager resourceManager,
        IGameDataService gameDataService,
        InputActionFactory inputActionFactory)
      {
        this.showDuration = showDuration;
        this.restartPath = restartPath;
        this.nextPath = nextPath;
        this.lobbyPath = lobbyPath;
        this.onRestart = onRestart;
        this.onNext = onNext;
        this.onLobby = onLobby;
        this.resourceManager = resourceManager;
        this.gameDataService = gameDataService;
        this.inputActionFactory = inputActionFactory;
      }
    }

    private readonly Model model;
    private readonly UIStageSuccessViewContainer viewContainer;

    private readonly ICanvasGroupTweenView canvasGroup;

    private InputAction restartInputAction;
    private InputAction nextInputAction;
    private InputAction lobbyInputAction;

    private UIVisibleState visibleState;

    public UIStageSuccessPresenter(Model model, UIStageSuccessViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      this.canvasGroup = viewContainer.canvasGroup;

      viewContainer.restartText.SetArgument(new() { model.restartPath });
      viewContainer.nextText.SetArgument(new() { model.nextPath });
      viewContainer.lobbyText.SetArgument(new() { model.lobbyPath });

      CreateInputActions();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_=>Dispose());

    public void Dispose()
    {
      var inputActionFactory = GlobalManager.instance.FactoryManager.InputActionFactory;
      inputActionFactory.Release(restartInputAction);
      inputActionFactory.Release(nextInputAction);
      inputActionFactory.Release(lobbyInputAction);
    }

    public UIVisibleState GetVisibleState()
      =>visibleState;

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      canvasGroup.DoFadeAsync(0.0f, 0.0f).Forget();
      restartInputAction.Disable();
      nextInputAction?.Disable();
      lobbyInputAction.Disable();
      visibleState = UIVisibleState.Hided;
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showing;
      await canvasGroup.DoFadeAsync(1.0f, model.showDuration, token);
      visibleState = UIVisibleState.Showed;
      restartInputAction.Enable();
      nextInputAction?.Enable();
      lobbyInputAction.Enable();
    }

    private async void CreateInputActions()
    {
      restartInputAction = model.inputActionFactory.Get(model.restartPath, () => model.onRestart?.Invoke(), InputActionFactory.InputActionPhaseType.Performed);
      lobbyInputAction = model.inputActionFactory.Get(model.lobbyPath, () => model.onLobby?.Invoke(), InputActionFactory.InputActionPhaseType.Performed);

      var table = GlobalManager.instance.Table.AddressableKeySO;
      var stageLabel = table.Label.Stage;

      var stages = await model.resourceManager.LoadAssetsAsync(stageLabel);
      model.gameDataService.GetSelectedStage(out var chapter,out var stage);
      var index = chapter * 4 + stage;
      if (index < stages.Count)
        nextInputAction = model.inputActionFactory.Get(model.nextPath, () => model.onNext?.Invoke(), InputActionFactory.InputActionPhaseType.Performed);
      else
        viewContainer.nextText.SetEntry("");
    }
  }
}