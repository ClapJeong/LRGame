using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using System;
using System.Threading;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UILobbyRootPresenter : IUIPresenter
  {
    public class Model
    {
      public UIManager uiManager;
      public TableContainer table;
      public IUIInputActionManager uiInputManager;
      public IResourceManager resourceManager;
      public IGameDataService gameDataService;
      public ISceneProvider sceneProvider;

      public Model(UIManager uiManager, TableContainer table, IUIInputActionManager uiInputManager, IResourceManager resourceManager, IGameDataService gameDataService, ISceneProvider sceneProvider)
      {
        this.uiManager = uiManager;
        this.table = table;
        this.uiInputManager = uiInputManager;
        this.resourceManager = resourceManager;
        this.gameDataService = gameDataService;
        this.sceneProvider = sceneProvider;
      }
    }

    private readonly Model model;
    private readonly UILobbyRootView view;

    private UIMainPanelPresenter mainPanelPresenter;
    private UIChapterPanelPresenter chapterPanelPresenter;
    private IUIIndicatorPresenter currentIndicator;   

    public UILobbyRootPresenter(Model model, UILobbyRootView view)
    {
      this.model = model;
      this.view = view;

      RegisterContainer();
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await view.HideAsync(isImmediately, token);
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await CreateIndicatorPresenterAsync();
      CreateMainPanelPresenter();
      CreateChapterPanelPresenter();
      await view.ShowAsync(isImmediately, token);
      await mainPanelPresenter.ActivateAsync(isImmediately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      UnregisterContainer();

      if (view)
        view.DestroySelf();
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    private async UniTask CreateIndicatorPresenterAsync()
    {
      currentIndicator = await model.uiManager.GetIUIIndicatorService().GetNewAsync(view.IndicatorRoot, view.MainPanelView.StageButtonSet.RectTransform);
    }

    private void CreateMainPanelPresenter()
    {
      var model = new UIMainPanelPresenter.Model(
        this.model.uiManager.GetIUISelectedGameObjectService(),
        this.model.uiManager.GetIUIDepthService(),
        currentIndicator,
        OnOptionButtonSubmit,
        OnLocalizeButtonSubmit,
        OnStageButtonSubmit,
        OnQuitButtonSubmit);
      mainPanelPresenter = new(model, view.MainPanelView);
      mainPanelPresenter.AttachOnDestroy(view.gameObject);
    }

    private void OnOptionButtonSubmit()
    {

    }

    private void OnLocalizeButtonSubmit()
    {

    }

    private void OnStageButtonSubmit()
    {
      mainPanelPresenter.DeactivateAsync().Forget();
      chapterPanelPresenter.ActivateAsync().Forget();
    }

    private void OnQuitButtonSubmit()
    {

    }

    private void CreateChapterPanelPresenter()
    {
      var model = new UIChapterPanelPresenter.Model(
        this.model.table.AddressableKeySO,        
        this.model.table.UISO,
        this.model.uiInputManager,
        this.model.uiManager.GetIUIDepthService(),
        this.model.gameDataService,
        this.model.sceneProvider,
        currentIndicator,
        this.model.resourceManager,
        this.model.uiManager.GetIUISelectedGameObjectService(),
        () =>
        {
          chapterPanelPresenter.DeactivateAsync().Forget();
          mainPanelPresenter.ActivateAsync().Forget();
        });
      chapterPanelPresenter = new(model, view.ChapterPanelView);
      chapterPanelPresenter.AttachOnDestroy(view.gameObject);
    }

    private void RegisterContainer()
    {
      GlobalManager
        .instance
        .UIManager
        .GetIUIPresenterContainer()
        .Add(this);
    }

    private void UnregisterContainer()
    {
      GlobalManager
        .instance
        .UIManager
        .GetIUIPresenterContainer().Remove(this);
    }
  }
}