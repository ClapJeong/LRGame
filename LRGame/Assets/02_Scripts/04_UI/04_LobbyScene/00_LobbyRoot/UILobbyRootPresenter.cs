using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace LR.UI.Lobby
{
  public class UILobbyRootPresenter : IUIPresenter
  {
    public class Model
    {
      public UIManager uiManager;
      public IUIInputActionManager uiInputManager;
      public IResourceManager resourceManager;
      public IGameDataService gameDataService;
      public ISceneProvider sceneProvider;

      public Model(UIManager uiManager, IUIInputActionManager uiInputManager, IResourceManager resourceManager, IGameDataService gameDataService, ISceneProvider sceneProvider)
      {
        this.uiManager = uiManager;
        this.uiInputManager = uiInputManager;
        this.resourceManager = resourceManager;
        this.gameDataService = gameDataService;
        this.sceneProvider = sceneProvider;
      }
    }

    private readonly Model model;
    private readonly UILobbyViewContainer viewContainer;

    private IUIIndicatorService indicatorService => model.uiManager;

    private IUIIndicatorPresenter currentIndicator;
    private Dictionary<UIChapterButtonViewContainer, UIChapterButtonPresenter> chapterButtons = new();

    public UILobbyRootPresenter(Model model, UILobbyViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      RegisterContainer();
      CreateChapterButtonsAsync().Forget();
    }

    public UIVisibleState GetVisibleState()
      => UIVisibleState.Showed;

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new System.NotImplementedException();
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      UnregisterContainer();
      LowerDepth();
      UnsubscribeSelectedGameObjectService();

      if (viewContainer)
        viewContainer.BaseGameObjectView.DestroyGameObject();      
    }

    private async UniTask CreateChapterButtonsAsync()
    {
      var navigationsView = new List<UIChapterButtonViewContainer>();
      var testChapterCount = 3;
      for (int i = 0; i < testChapterCount; i++)
      {
        var chapter = i;

        var table = GlobalManager.instance.Table.AddressableKeySO;
        var key = table.Path.Ui + table.UIName.LobbyChapterButton;
        var model = new UIChapterButtonPresenter.Model(
          depthService: this.model.uiManager,
          uiInputActionManager: this.model.uiInputManager,
          resourceManager: this.model.resourceManager,
          chapter: chapter,
          gameDataService: this.model.gameDataService,
          sceneProvider: this.model.sceneProvider,
          indicatorService: this.model.uiManager);
        var view = await this.model.resourceManager.CreateAssetAsync<UIChapterButtonViewContainer>(key, viewContainer.stageButtonRoot);
        view.name = $"ChapterView_{i}";
        var presenter = new UIChapterButtonPresenter(model, view, viewContainer.chapterPanelRoot);
        presenter.AttachOnDestroy(view.gameObject);

        chapterButtons[view] = presenter;
        navigationsView.Add(view);
      }

      InitializeNavigations(navigationsView);
    }

    private void InitializeNavigations(List<UIChapterButtonViewContainer> navigationViews)
    {
      for(int i = 0; i < navigationViews.Count; i++)
      {
        var currentNavigationView = navigationViews[i].navigationView;

        if (i > 0)
        {
          var prevNavigationView = navigationViews[i - 1].navigationView;
          currentNavigationView.AddNavigation(Direction.Left, prevNavigationView.GetSelectable());
        }

        if(i<navigationViews.Count - 1)
        {
          var nextNavigationView = navigationViews[i + 1].navigationView;
          currentNavigationView.AddNavigation(Direction.Right, nextNavigationView.GetSelectable());
        }
      }
      RaiseDepth(navigationViews.First());
    }

    private void RegisterContainer()
    {
      IUIPresenterContainer presenterContainer = GlobalManager.instance.UIManager;
      presenterContainer.Add(this);
    }

    private void UnregisterContainer()
    {
      IUIPresenterContainer presenterContainer = model.uiManager;
      presenterContainer.Remove(this);
    }

    #region Depths
    private async void RaiseDepth(UIChapterButtonViewContainer firstView)
    {
      LayoutRebuilder.ForceRebuildLayoutImmediate(viewContainer.stageButtonRoot.GetComponent<RectTransform>());
      await UniTask.Yield();

      currentIndicator = await indicatorService.GetNewAsync(viewContainer.indicatorRoot, firstView.rectView);
      currentIndicator.SetLeftGuide(firstView.navigationView.GetNavigation());
      currentIndicator.SetRightGuide(Direction.Right, Direction.Left);
      indicatorService.ReleaseTopIndicatorOnDestroy(viewContainer.gameObject);

      IUIDepthService depthService = model.uiManager;
      depthService.RaiseDepth(firstView.gameObject);

      SubscribeSelectedGameObjectService();
    }

    private void LowerDepth()
    {
      IUIDepthService depthService = model.uiManager;
      depthService.LowerDepth();
    }
    #endregion

    #region Subscribes
    private void SubscribeSelectedGameObjectService()
    {
      IUISelectedGameObjectService selectedGameObjectService = model.uiManager;
      selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);
      selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnExit, OnSelectedGameObjectExit);
    }

    private void UnsubscribeSelectedGameObjectService()
    {     
      IUISelectedGameObjectService selectedGameObjectService = model.uiManager;
      selectedGameObjectService.UnsubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);
      selectedGameObjectService.UnsubscribeEvent(IUISelectedGameObjectService.EventType.OnExit, OnSelectedGameObjectExit);
    }
    #endregion

    private void OnSelectedGameObjectEnter(GameObject target)
    {
      if (target.TryGetComponent<UIChapterButtonViewContainer>(out var targetView) &&
          indicatorService.IsTopIndicatorIsThis(currentIndicator))
      {
        currentIndicator.MoveAsync(targetView.rectView).Forget();
        currentIndicator.SetLeftGuide(targetView.navigationView.GetNavigation());
        chapterButtons[targetView].ShowAsync().Forget();
      }
    }

    private void OnSelectedGameObjectExit(GameObject target)
    {
      if (target.TryGetComponent<UIChapterButtonViewContainer>(out var targetView) &&
          indicatorService.IsTopIndicatorIsThis(currentIndicator))
      {
        chapterButtons[targetView].HideAsync().Forget();
      }
    }
  }
}