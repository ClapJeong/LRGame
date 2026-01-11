using Cysharp.Threading.Tasks;
using DG.Tweening;
using LR.UI.Indicator;
using LR.UI.Lobby.ChapterPanel;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace LR.UI.Lobby
{
  public class UIChapterPanelPresenter : IUIPresenter
  {
    public class Model
    {
      public AddressableKeySO addressableKeySO;
      public UISO uiSO;
      public IUIInputActionManager uiInputActionManager;      
      public IUIDepthService depthService;
      public IGameDataService gameDataService;
      public ISceneProvider sceneProvider;
      public IUIIndicatorPresenter panelIndicator;
      public IResourceManager resourceManager;
      public IUISelectedGameObjectService uiSelectedGameObjectService;
      public UnityAction onPanelExit;

      public Model(AddressableKeySO addressableKeySO, UISO uiSO, IUIInputActionManager uiInputActionManager, IUIDepthService depthService, IGameDataService gameDataService, ISceneProvider sceneProvider, IUIIndicatorPresenter panelIndicator, IResourceManager resourceManager, IUISelectedGameObjectService uiSelectedGameObjectService, UnityAction onPanelExit)
      {
        this.addressableKeySO = addressableKeySO;
        this.uiSO = uiSO;
        this.uiInputActionManager = uiInputActionManager;
        this.depthService = depthService;
        this.gameDataService = gameDataService;
        this.sceneProvider = sceneProvider;
        this.panelIndicator = panelIndicator;
        this.resourceManager = resourceManager;
        this.uiSelectedGameObjectService = uiSelectedGameObjectService;
        this.onPanelExit = onPanelExit;
      }
    }
    private readonly Model model;
    private readonly UIChapterPanelView view;

    private readonly SubscribeHandle subscribeHandle;
    private readonly StageButtonSetService stageButtonSetService;

    private UIChapterPanelExitButtonPresenter exitButtonPresenter;

    public UIChapterPanelPresenter(Model model, UIChapterPanelView view)
    {
      this.model = model;
      this.view = view;

      stageButtonSetService = new(
        model.uiSO,
        view.ChapterButtonSetRoot,
        view.StageButtonSetCenterPosition,
        model.panelIndicator,
        view.StageButtonSetVertialLayoutGroup,
        view.ExitView);

      view.HideAsync(true).Forget();

      CreateExitButtonPresenter();
      CreateStageButtonSetsAsync().Forget();
      subscribeHandle = new SubscribeHandle(()=>
      {
        SubscribeSelectedGameObjectService();
        SubscribeCurrentDepth();
      },
      () =>
      {
        UnsubscribeSelectedGameObjectService();
        UnsubscribeCurrentDepth();
      });
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Subscribe();
      model.depthService.SelectTopObject();
      exitButtonPresenter.ActivateAsync().Forget();
      await view.ShowAsync(isImmediately, token);
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      stageButtonSetService.DeactivateAsync(isImmediately, token).Forget();
      subscribeHandle.Unsubscribe();
      exitButtonPresenter.DeactivateAsync().Forget();
      await view.HideAsync(isImmediately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
      stageButtonSetService.Dispose();

      if (view)
        view.DestroySelf();
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    private async UniTask CreateStageButtonSetsAsync()
    {
      var setCount = model.gameDataService.StageDataCount;
      setCount = 24;//Test
      UIStageButtonSetView prevView = null;
      for (int i = 0; i < setCount / 4; i++)
      {
        var key = this.model.addressableKeySO.Path.UI + this.model.addressableKeySO.UIName.StageButtonSet;
        var model = new UIStageButtonSetPresenter.Model(
          i,
          this.model.uiInputActionManager,
          this.model.gameDataService,
          this.model.sceneProvider);
        var view = await this.model.resourceManager.CreateAssetAsync<UIStageButtonSetView>(key, this.view.ChapterButtonSetRoot);        
        var presenter = new UIStageButtonSetPresenter(model, view);
        presenter.DeactivateAsync(true).Forget();
        presenter.AttachOnDestroy(this.view.gameObject);
        
        if (prevView != null)
        {
          prevView.Selectable.AddNavigation(Direction.Right, view.Selectable);
          view.Selectable.AddNavigation(Direction.Left, prevView.Selectable);
        }        
        view.Selectable.AddNavigation(Direction.Down, this.view.ExitView.Selectable);
        prevView = view;

        stageButtonSetService.AddMap(presenter, view);
      }

      stageButtonSetService.InitializeFirstPosition();
    }

    private void CreateExitButtonPresenter()
    {
      var model = new UIChapterPanelExitButtonPresenter.Model(
        this.model.panelIndicator,
        this.model.uiSelectedGameObjectService,
        Direction.Down,
        this.model.onPanelExit);
      exitButtonPresenter = new(model, view.ExitView);
      exitButtonPresenter.AttachOnDestroy(view.gameObject);
    }

    private void SubscribeSelectedGameObjectService()
    {
      model.uiSelectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, SetIndicatorTarget);
      model.uiSelectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, stageButtonSetService.OnSelectStageButtonSet);
    }

    private void UnsubscribeSelectedGameObjectService()
    {
      model.uiSelectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, SetIndicatorTarget);
      model.uiSelectedGameObjectService.UnsubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, stageButtonSetService.OnSelectStageButtonSet);
    }

    private void SubscribeCurrentDepth()
    {
      model.depthService.RaiseDepth(stageButtonSetService.FirstGameObject);
    }

    private void UnsubscribeCurrentDepth()
    {
      model.depthService.LowerDepth();
    }


    private void SetIndicatorTarget(GameObject gameObject)
    {
      if (gameObject != null)
        model.panelIndicator.MoveAsync(gameObject.GetComponent<RectTransform>());
    }    
  }
}