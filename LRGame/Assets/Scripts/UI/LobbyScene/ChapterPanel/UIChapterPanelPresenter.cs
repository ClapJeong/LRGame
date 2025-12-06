using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using LR.UI.Lobby.ChapterPanel;
using System;
using System.Collections.Generic;
using System.Threading;
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

    private static readonly UIInputDirectionType Up = UIInputDirectionType.LeftUp;
    private static readonly UIInputDirectionType Right = UIInputDirectionType.LeftRight;
    private static readonly UIInputDirectionType Down = UIInputDirectionType.LeftDown;
    private static readonly UIInputDirectionType Left = UIInputDirectionType.LeftLeft;
    private static readonly UIInputDirectionType Back = UIInputDirectionType.Space;

    private readonly Model model;
    private readonly UIChapterPanelViewContainer viewContainer;

    private UIChapterPanelActionHolder actionHolder;
    private Dictionary<UIInputDirectionType, IUIPresenter> directionPresenters = new();
    private UIInputDirectionType currentSelectingDirection = UIInputDirectionType.Space;
    
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
      CreateActionHolder();
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
      var indicator = await model.indicatorService.GetNewAsync(viewContainer.indicatorRoot, viewContainer.quitButtonView.rectView);
      indicator.SetLeftGuide(new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>
      {
        { Up.ParseToDirection(), IUIIndicatorPresenter.LeftGuideType.Movable },
        { Right.ParseToDirection(), IUIIndicatorPresenter.LeftGuideType.Movable },
        { Down.ParseToDirection(), IUIIndicatorPresenter.LeftGuideType.Movable },
        { Left.ParseToDirection(), IUIIndicatorPresenter.LeftGuideType.Movable },
      });
      indicator.SetRightGuide(Direction.Space);

      subscribeHandle.Subscribe();
      await ShowPresenterAsync(UIInputDirectionType.Space, isImmediately, token);
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

    private async UniTask ShowPresenterAsync(UIInputDirectionType type, bool isImmediately, CancellationToken token)
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
    private void CreateActionHolder()
    {
      actionHolder = new UIChapterPanelActionHolder(
        onUpPerformed: () => OnEnterInput(requireDirectionType: Back, targetDirectionType: Up, targetRectView: viewContainer.upStageButtonView.rectView),
        onUpCanceled: () => OnEnterInput(requireDirectionType: Up, targetDirectionType: Back, targetRectView: viewContainer.quitButtonView.rectView),

        onRightPerformed: () => OnEnterInput(requireDirectionType: Back, targetDirectionType: Right, targetRectView: viewContainer.rightStageButtonView.rectView),
        onRightCanceled: () => OnEnterInput(requireDirectionType: Right, targetDirectionType: Back, targetRectView: viewContainer.quitButtonView.rectView),

        onDownPerformed: () => OnEnterInput(requireDirectionType: Back, targetDirectionType: Down, targetRectView: viewContainer.downStageButtonView.rectView),
        onDownCanceled: () => OnEnterInput(requireDirectionType: Down, targetDirectionType: Back, targetRectView: viewContainer.quitButtonView.rectView),

        onLeftPerformed: () => OnEnterInput(requireDirectionType: Back, targetDirectionType: Left, targetRectView: viewContainer.leftStageButtonView.rectView),
        onLeftCanceled: () => OnEnterInput(requireDirectionType: Left, targetDirectionType: Back, targetRectView: viewContainer.quitButtonView.rectView));
    }

    private void OnEnterInput(UIInputDirectionType requireDirectionType, UIInputDirectionType targetDirectionType, BaseRectView targetRectView)
    {
      if (currentSelectingDirection != requireDirectionType)
        return;
      currentSelectingDirection = targetDirectionType;

      ShowPresenterAsync(currentSelectingDirection, false, default).Forget();

      var topIndicator = model.indicatorService.GetTopIndicator();
      var leftGuideDictionary = GetLeftGuideDictionary(targetDirectionType);
      topIndicator.MoveAsync(targetRectView)
        .ContinueWith(() =>
        {
          topIndicator.SetLeftGuide(leftGuideDictionary);
          topIndicator.SetRightGuide(targetDirectionType.ParseToDirection());
        })
        .Forget();    
    }

    private Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType> GetLeftGuideDictionary(UIInputDirectionType targetDirectionType)
    {
      var indicatorLeftGuide = new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>();
      if (targetDirectionType == Back)
      {
        indicatorLeftGuide[Up.ParseToDirection()] = IUIIndicatorPresenter.LeftGuideType.Movable;
        indicatorLeftGuide[Right.ParseToDirection()] = IUIIndicatorPresenter.LeftGuideType.Movable;
        indicatorLeftGuide[Down.ParseToDirection()] = IUIIndicatorPresenter.LeftGuideType.Movable;
        indicatorLeftGuide[Left.ParseToDirection()] = IUIIndicatorPresenter.LeftGuideType.Movable;
      }
      else
      {
        indicatorLeftGuide[targetDirectionType.ParseToDirection().ParseOpposite()] = IUIIndicatorPresenter.LeftGuideType.Clamped;
      }
      return indicatorLeftGuide;
    }

    private void CreateQuitButtonPresenter()
    {
      var targetInputType = Back;
      var model = new UIChapterPanelQuitButtonPresenter.Model(
        inputDirectionType: targetInputType, 
        uiInputActionManager: this.model.uiInputActionManager,
        onQuit: () =>
        {
          HideAsync().Forget();
        });
      var view = viewContainer.quitButtonView;
      directionPresenters[targetInputType] = new UIChapterPanelQuitButtonPresenter(model, view);
      directionPresenters[targetInputType].AttachOnDestroy(viewContainer.gameObject);
      directionPresenters[targetInputType].HideAsync().Forget();
    }

    private void CreateStageButtonPresenters()
    {
      var rightInputType = Right;
      var upModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter, 
        stage: 1,
        inputType: UIInputDirectionType.RightUP,
        onComplete: subscribeHandle.Unsubscribe,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var upView = viewContainer.upStageButtonView;
      directionPresenters[Up] = new UIStageButtonPresenter(upModel, upView);
      directionPresenters[Up].AttachOnDestroy(viewContainer.gameObject);
      directionPresenters[Up].HideAsync().Forget();

      var rightModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 2,
        inputType: UIInputDirectionType.RightRight,
        onComplete: subscribeHandle.Unsubscribe,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var rightView = viewContainer.rightStageButtonView;
      directionPresenters[Right] = new UIStageButtonPresenter(rightModel, rightView);
      directionPresenters[Right].AttachOnDestroy(viewContainer.gameObject);
      directionPresenters[Right].HideAsync().Forget();

      var downModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 3,
        inputType: UIInputDirectionType.RightDown,
        onComplete: subscribeHandle.Unsubscribe,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var downView = viewContainer.downStageButtonView;
      directionPresenters[Down] = new UIStageButtonPresenter(downModel, downView);
      directionPresenters[Down].AttachOnDestroy(viewContainer.gameObject);
      directionPresenters[Down].HideAsync().Forget();

      var leftModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 4,
        inputType: UIInputDirectionType.RightLeft,
        onComplete: subscribeHandle.Unsubscribe,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var leftView = viewContainer.leftStageButtonView;
      directionPresenters[Left] = new UIStageButtonPresenter(leftModel, leftView);
      directionPresenters[Left].AttachOnDestroy(viewContainer.gameObject);
      directionPresenters[Left].HideAsync().Forget();
    }
    #endregion

    #region InputActionSubscribes
    private void SubscribeInputActions()
    {
      model.uiInputActionManager.SubscribePerformedEvent(Up, actionHolder.OnUpPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(Up, actionHolder.OnUpCanceled);

      model.uiInputActionManager.SubscribePerformedEvent(Right, actionHolder.OnRightPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(Right, actionHolder.OnRightCanceled);      

      model.uiInputActionManager.SubscribePerformedEvent(Down, actionHolder.OnDownPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(Down, actionHolder.OnDownCanceled);

      model.uiInputActionManager.SubscribePerformedEvent(Left, actionHolder.OnLeftPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(Left, actionHolder.OnLeftCanceled);
    }

    private void UnsubscribeInputActions()
    {
      model.indicatorService.ReleaseTopIndicator();

      model.uiInputActionManager.UnsubscribePerformedEvent(Up, actionHolder.OnUpPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(Up, actionHolder.OnUpCanceled);

      model.uiInputActionManager.UnsubscribePerformedEvent(Right, actionHolder.OnRightPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(Right, actionHolder.OnRightCanceled);

      model.uiInputActionManager.UnsubscribePerformedEvent(Down, actionHolder.OnDownPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(Down, actionHolder.OnDownCanceled);

      model.uiInputActionManager.UnsubscribePerformedEvent(Left, actionHolder.OnLeftPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(Left, actionHolder.OnLeftCanceled);
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