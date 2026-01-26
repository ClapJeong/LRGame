using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.Lobby
{
  public class UILobbyRootPresenter : IUIPresenter
  {
    private enum PanelState
    {
      None,
      Option, Localize,
      Main,
      Stage,
    }

    public class Model
    {
      public UIManager uiManager;
      public TableContainer table;
      public IUIInputManager uiInputManager;
      public IResourceManager resourceManager;
      public IGameDataService gameDataService;
      public ISceneProvider sceneProvider;

      public Model(UIManager uiManager, TableContainer table, IUIInputManager uiInputManager, IResourceManager resourceManager, IGameDataService gameDataService, ISceneProvider sceneProvider)
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

    private readonly Dictionary<PanelState, IUIPresenter> panelPresenters = new();

    private PanelState currentPanelState = PanelState.None;
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
      CreateOptionPanelPresenter();
      CreateLocalizePanelPresenter();

      await view.ShowAsync(isImmediately, token);
      SetState(PanelState.Main);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      UnregisterContainer();      

      if (view)
        view.DestroySelf();
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

    private void SetState(PanelState panelState)
    {
      if (panelState == currentPanelState)
        return;

      if (currentPanelState != PanelState.None)
        panelPresenters[currentPanelState].DeactivateAsync().Forget();

      currentPanelState = panelState;
      panelPresenters[currentPanelState].ActivateAsync().Forget();
    }

    private async UniTask CreateIndicatorPresenterAsync()
    {
      var indicatorService = model.uiManager.GetIUIIndicatorService();
      currentIndicator = await indicatorService.GetNewAsync(view.IndicatorRoot, view.MainPanelView.StageButtonSet.RectTransform);
      indicatorService.ReleaseTopIndicatorOnDestroy(view.gameObject);
    }

    private void CreateMainPanelPresenter()
    {
      var model = new UIMainPanelPresenter.Model(
        this.model.table.UISO,
        this.model.uiManager.GetIUISelectedGameObjectService(),
        this.model.uiManager.GetIUIDepthService(),
        currentIndicator,
        onOptionButton: ()=> SetState(PanelState.Option),
        onLocalizeButton: ()=>SetState(PanelState.Localize),
        onStageButton: ()=>SetState(PanelState.Stage),
        onQuitButton: null);
      var mainPanelPresenter = new UIMainPanelPresenter(model, view.MainPanelView);
      mainPanelPresenter.AttachOnDestroy(view.gameObject);
      panelPresenters[PanelState.Main] = mainPanelPresenter;
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
        onPanelExit: () => SetState(PanelState.Main));
      var chapterPanelPresenter = new UIChapterPanelPresenter(model, view.ChapterPanelView);
      chapterPanelPresenter.AttachOnDestroy(view.gameObject);
      chapterPanelPresenter.DeactivateAsync(true).Forget();
      panelPresenters[PanelState.Stage] = chapterPanelPresenter;
    }

    private void CreateOptionPanelPresenter()
    {
      var model = new UIOptionPanelPresenter.Model(
        this.model.table.UISO,
        currentIndicator,
        this.model.uiManager.GetIUIDepthService(),
        this.model.uiManager.GetIUISelectedGameObjectService(),
        this.model.uiInputManager,
        onExit: () => SetState(PanelState.Main));
      var optionPanelPresenter = new UIOptionPanelPresenter(model, view.OptionPanelView);
      optionPanelPresenter.AttachOnDestroy(view.gameObject);
      optionPanelPresenter.DeactivateAsync(true).Forget();
      panelPresenters[PanelState.Option] = optionPanelPresenter;
    }

    private void CreateLocalizePanelPresenter()
    {
      var model = new UILocalizePanelPresenter.Model(
        currentIndicator,
        this.model.uiManager.GetIUISelectedGameObjectService(),
        this.model.uiManager.GetIUIDepthService(),
        onExit: () => SetState(PanelState.Main));
      var localizePresenter = new UILocalizePanelPresenter(model, view.LocalizePanelView);
      localizePresenter.AttachOnDestroy(view.gameObject);
      localizePresenter.DeactivateAsync(true).Forget();
      panelPresenters[PanelState.Localize] = localizePresenter;
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