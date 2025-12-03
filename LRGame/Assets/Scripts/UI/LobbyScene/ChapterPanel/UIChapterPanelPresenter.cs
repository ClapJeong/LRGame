using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using LR.UI.Lobby.ChapterPanel;
using System;
using System.Collections.Generic;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.Lobby
{
  public class UIChapterPanelPresenter : IUIPresenter
  {
    public class Model
    {
      public int chapter;
      public IUIDepthService depthService;
      public IUIInputActionManager uiInputActionManager;
      public UnityAction onHide;
      public IGameDataService gameDataService;
      public ISceneProvider sceneProvider;
      public IUIIndicatorService indicatorService;

      public Model(int chapter, IUIDepthService depthService, IUIInputActionManager uiInputActionManager, UnityAction onHide, IGameDataService gameDataService, ISceneProvider sceneProvider, IUIIndicatorService indicatorService)
      {
        this.chapter = chapter;
        this.depthService = depthService;
        this.uiInputActionManager = uiInputActionManager;
        this.onHide = onHide;
        this.gameDataService = gameDataService;
        this.sceneProvider = sceneProvider;
        this.indicatorService = indicatorService;
      }
    }    
    private readonly Model model;
    private readonly UIChapterPanelViewContainer viewContainer;
    private readonly UIChapterPanelActionHolder actionHolder;

    private Dictionary<UIInputActionType, IUIPresenter> directionPresenters = new();
    private UIInputActionType currentSelectingDirection = UIInputActionType.Space;
    
    private UIVisibleState visibleState = UIVisibleState.None;
    private SubscribeHandle subscribeHandle;

    public UIChapterPanelPresenter(Model model, UIChapterPanelViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;
      subscribeHandle = new SubscribeHandle(SubscribeInputActions, UnsubscribeInputActions);

      viewContainer.gameObjectView.SetActive(false);

      CreateQuitButtonPresenter();
      CreateStageButtonPresenters();

      actionHolder = new UIChapterPanelActionHolder(
        onUpPerformed: () =>
        {
          if (currentSelectingDirection != UIInputActionType.Space)
            return;

          currentSelectingDirection = UIInputActionType.LeftUP;
          ShowPresenterAsync(currentSelectingDirection, false, default).Forget();
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.upStageButtonView.rectView).Forget();
        },
        onUpCanceled: () =>
        {
          if (currentSelectingDirection != UIInputActionType.LeftUP)
            return;

          currentSelectingDirection = UIInputActionType.Space;
          ShowPresenterAsync(currentSelectingDirection, false, default).Forget();
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.quitButtonView.rectView).Forget();
        },
        onRightPerformed: () =>
        {
          if (currentSelectingDirection != UIInputActionType.Space)
            return;

          currentSelectingDirection = UIInputActionType.LeftRight;
          ShowPresenterAsync(currentSelectingDirection, false, default).Forget();
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.rightStageButtonView.rectView).Forget();
        },
        onRightCanceled: () =>
        {
          if (currentSelectingDirection != UIInputActionType.LeftRight)
            return;

          currentSelectingDirection = UIInputActionType.Space;
          ShowPresenterAsync(currentSelectingDirection, false, default).Forget();
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.quitButtonView.rectView).Forget();
        },
        onDownPerformed: () =>
        {
          if (currentSelectingDirection != UIInputActionType.Space)
            return;

          currentSelectingDirection = UIInputActionType.LeftDown;
          ShowPresenterAsync(currentSelectingDirection, false, default).Forget();
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.downStageButtonView.rectView).Forget();
        },
        onDownCanceled: () =>
        {
          if (currentSelectingDirection != UIInputActionType.LeftDown)
            return;

          currentSelectingDirection = UIInputActionType.Space;
          ShowPresenterAsync(currentSelectingDirection, false, default).Forget();
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.quitButtonView.rectView).Forget();
        },
        onLeftPerformed: () =>
        {
          if (currentSelectingDirection != UIInputActionType.Space)
            return;

          currentSelectingDirection = UIInputActionType.LeftLeft;
          ShowPresenterAsync(currentSelectingDirection, false, default).Forget();
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.leftStageButtonView.rectView).Forget();
        },
        onLeftCanceled: () =>
        {
          if (currentSelectingDirection != UIInputActionType.LeftLeft)
            return;

          currentSelectingDirection = UIInputActionType.Space;
          ShowPresenterAsync(currentSelectingDirection, false, default).Forget();
          model.indicatorService.GetTopIndicator().MoveAsync(viewContainer.quitButtonView.rectView).Forget();
        });

    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);
  
    public void Dispose()
    {
      subscribeHandle.Dispose();

      if (viewContainer)
        viewContainer.gameObjectView.DestroyGameObject();      
    }

    public async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await model.indicatorService.GetNewAsync(viewContainer.indicatorRoot, viewContainer.quitButtonView.rectView);

      subscribeHandle.Subscribe();
      await ShowPresenterAsync(UIInputActionType.Space, isImmediately, token);
      RaiseDepth();
      viewContainer.gameObjectView.SetActive(true);
      visibleState = UIVisibleState.Showed;
    }

    public async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      model.onHide?.Invoke();

      subscribeHandle.Unsubscribe();      
      await HideAllPresenters(isImmediately, token);
      LowerDepth();
      viewContainer.gameObjectView.SetActive(false);
      visibleState = UIVisibleState.Hided;
    }

    public UIVisibleState GetVisibleState()
      => visibleState;

    public void SetVisibleState(UIVisibleState visibleState)
      => this.visibleState = visibleState;

    private async UniTask ShowPresenterAsync(UIInputActionType type, bool isImmediately, CancellationToken token)
    {
      foreach (var pair in directionPresenters)
      {
        if (pair.Key == type)
          await pair.Value.ShowAsync(isImmediately, token);
        else
          await pair.Value.HideAsync(isImmediately, token);
      }        
    }

    private async UniTask HideAllPresenters(bool isImmediately, CancellationToken token)
    {
      foreach (var presenter in directionPresenters.Values)
        await presenter.HideAsync(isImmediately, token);
    }

    #region Create
    private void CreateQuitButtonPresenter()
    {
      var model = new UIChapterPanelQuitButtonPresenter.Model(
        inputActionType: UIInputActionType.Space, 
        uiInputActionManager: this.model.uiInputActionManager,
        onQuit: () =>
        {
          HideAsync().Forget();
        });
      var view = viewContainer.quitButtonView;
      directionPresenters[UIInputActionType.Space] = new UIChapterPanelQuitButtonPresenter(model, view);
      directionPresenters[UIInputActionType.Space].AttachOnDestroy(viewContainer.gameObject);
    }

    private void CreateStageButtonPresenters()
    {
      var upModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter, 
        stage: 1,
        inputType: UIInputActionType.RightUP,
        onComplete: subscribeHandle.Unsubscribe,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var upView = viewContainer.upStageButtonView;
      directionPresenters[UIInputActionType.LeftUP] = new UIStageButtonPresenter(upModel, upView);
      directionPresenters[UIInputActionType.LeftUP].AttachOnDestroy(viewContainer.gameObject);

      var rightModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 2,
        inputType: UIInputActionType.RightRight,
        onComplete: subscribeHandle.Unsubscribe,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var rightView = viewContainer.rightStageButtonView;
      directionPresenters[UIInputActionType.LeftRight] = new UIStageButtonPresenter(rightModel, rightView);
      directionPresenters[UIInputActionType.LeftRight].AttachOnDestroy(viewContainer.gameObject);

      var downModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 3,
        inputType: UIInputActionType.RightDown,
        onComplete: subscribeHandle.Unsubscribe,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var downView = viewContainer.downStageButtonView;
      directionPresenters[UIInputActionType.LeftDown] = new UIStageButtonPresenter(downModel, downView);
      directionPresenters[UIInputActionType.LeftDown].AttachOnDestroy(viewContainer.gameObject);

      var leftModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 4,
        inputType: UIInputActionType.RightLeft,
        onComplete: subscribeHandle.Unsubscribe,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var leftView = viewContainer.leftStageButtonView;
      directionPresenters[UIInputActionType.LeftLeft] = new UIStageButtonPresenter(leftModel, leftView);
      directionPresenters[UIInputActionType.LeftLeft].AttachOnDestroy(viewContainer.gameObject);
    }
    #endregion

    #region InputActionSubscribes
    private void SubscribeInputActions()
    {
      model.uiInputActionManager.SubscribePerformedEvent(UIInputActionType.LeftUP, actionHolder.OnUpPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(UIInputActionType.LeftUP, actionHolder.OnUpCanceled);

      model.uiInputActionManager.SubscribePerformedEvent(UIInputActionType.LeftRight, actionHolder.OnRightPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(UIInputActionType.LeftRight, actionHolder.OnRightCanceled);      

      model.uiInputActionManager.SubscribePerformedEvent(UIInputActionType.LeftDown, actionHolder.OnDownPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(UIInputActionType.LeftDown, actionHolder.OnDownCanceled);

      model.uiInputActionManager.SubscribePerformedEvent(UIInputActionType.LeftLeft, actionHolder.OnLeftPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(UIInputActionType.LeftLeft, actionHolder.OnLeftCanceled);
    }

    private void UnsubscribeInputActions()
    {
      model.indicatorService.ReleaseTopIndicator();

      model.uiInputActionManager.UnsubscribePerformedEvent(UIInputActionType.LeftUP, actionHolder.OnUpPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(UIInputActionType.LeftUP, actionHolder.OnUpCanceled);

      model.uiInputActionManager.UnsubscribePerformedEvent(UIInputActionType.LeftRight, actionHolder.OnRightPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(UIInputActionType.LeftRight, actionHolder.OnRightCanceled);

      model.uiInputActionManager.UnsubscribePerformedEvent(UIInputActionType.LeftDown, actionHolder.OnDownPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(UIInputActionType.LeftDown, actionHolder.OnDownCanceled);

      model.uiInputActionManager.UnsubscribePerformedEvent(UIInputActionType.LeftLeft, actionHolder.OnLeftPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(UIInputActionType.LeftLeft, actionHolder.OnLeftCanceled);
    }
    #endregion

    #region Depth
    private void RaiseDepth()
    {
      model.depthService.RaiseDepth(null);
    }

    private void LowerDepth()
    {
      model.depthService.LowerDepth();
    }
    #endregion
  }
}