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
      public UnityAction onHide;
      public IUIDepthService depthService;
      public IUIInputActionManager uiInputActionManager;      
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
    private readonly UIChapterPanelView view;

    private UIChapterPanelActionHolder actionHolder;
    private Dictionary<UIInputDirectionType, IUIPresenter> directionPresenters = new();
    private UIInputDirectionType currentSelectingDirection = UIInputDirectionType.Space;
    private IUIIndicatorPresenter currentIndicator;
    
    private SubscribeHandle subscribeHandle;

    public UIChapterPanelPresenter(Model model, UIChapterPanelView view)
    {
      this.model = model;
      this.view = view;

      subscribeHandle = new SubscribeHandle(SubscribeInputActions, UnsubscribeInputActions);

      CreateQuitButtonPresenter();
      CreateStageButtonPresenters();
      CreateActionHolder();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);
  
    public void Dispose()
    {
      if (currentIndicator != null)
        ReleaseIndicator();

      subscribeHandle.Dispose();

      if (view)
        view.DestroySelf();
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await CreateAndSubscribeIndicatorAsync();
      RaiseDepth();
      subscribeHandle.Subscribe();
      await ActivatePresenterAsync(UIInputDirectionType.Space, isImmediately, token);
      await view.ShowAsync(isImmediately, token);
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      model.onHide?.Invoke();

      if (currentIndicator != null)
      {
        LowerDepth();
        ReleaseIndicator();
      }
      subscribeHandle.Unsubscribe();      
      await DeactivateAllPresenters(isImmediately, token);
      await view.HideAsync(isImmediately, token);
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    private async UniTask ActivatePresenterAsync(UIInputDirectionType type, bool isImmediately, CancellationToken token)
    {
      foreach (var pair in directionPresenters)
      {
        if (pair.Key == type)
          await pair.Value.ActivateAsync(isImmediately, token);
        else
          await pair.Value.DeactivateAsync(isImmediately, token);
      }        
    }

    private async UniTask DeactivateAllPresenters(bool isImmediately, CancellationToken token)
    {
      foreach (var presenter in directionPresenters.Values)
        await presenter.DeactivateAsync(isImmediately, token);
    }

    #region Indicator
    private async UniTask CreateAndSubscribeIndicatorAsync()
    {
      currentIndicator = await model.indicatorService.GetNewAsync(view.indicatorRoot, view.quitButtonView.rectView);
      currentIndicator.SetLeftGuide(new Dictionary<Direction, IUIIndicatorPresenter.LeftGuideType>
      {
        { Up.ParseToDirection(), IUIIndicatorPresenter.LeftGuideType.Movable },
        { Right.ParseToDirection(), IUIIndicatorPresenter.LeftGuideType.Movable },
        { Down.ParseToDirection(), IUIIndicatorPresenter.LeftGuideType.Movable },
        { Left.ParseToDirection(), IUIIndicatorPresenter.LeftGuideType.Movable },
      });
      currentIndicator.SetRightGuide(Direction.Space);
    }

    private void ReleaseIndicator()
    {
      model.indicatorService.ReleaseTopIndicator();
      currentIndicator = null;
    }
    #endregion

    #region Create
    private void CreateActionHolder()
    {
      actionHolder = new UIChapterPanelActionHolder(
        onUpPerformed: () => OnEnterInput(requireDirectionType: Back, targetDirectionType: Up, targetRectView: view.upStageButtonView.rectView),
        onUpCanceled: () => OnEnterInput(requireDirectionType: Up, targetDirectionType: Back, targetRectView: view.quitButtonView.rectView),

        onRightPerformed: () => OnEnterInput(requireDirectionType: Back, targetDirectionType: Right, targetRectView: view.rightStageButtonView.rectView),
        onRightCanceled: () => OnEnterInput(requireDirectionType: Right, targetDirectionType: Back, targetRectView: view.quitButtonView.rectView),

        onDownPerformed: () => OnEnterInput(requireDirectionType: Back, targetDirectionType: Down, targetRectView: view.downStageButtonView.rectView),
        onDownCanceled: () => OnEnterInput(requireDirectionType: Down, targetDirectionType: Back, targetRectView: view.quitButtonView.rectView),

        onLeftPerformed: () => OnEnterInput(requireDirectionType: Back, targetDirectionType: Left, targetRectView: view.leftStageButtonView.rectView),
        onLeftCanceled: () => OnEnterInput(requireDirectionType: Left, targetDirectionType: Back, targetRectView: view.quitButtonView.rectView));
    }

    private void OnEnterInput(UIInputDirectionType requireDirectionType, UIInputDirectionType targetDirectionType, BaseRectView targetRectView)
    {
      if (currentSelectingDirection != requireDirectionType)
        return;
      currentSelectingDirection = targetDirectionType;

      ActivatePresenterAsync(currentSelectingDirection, false, default).Forget();

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
          DeactivateAsync().Forget();
        });
      var view = this.view.quitButtonView;
      directionPresenters[targetInputType] = new UIChapterPanelQuitButtonPresenter(model, view);
      directionPresenters[targetInputType].AttachOnDestroy(this.view.gameObject);
      directionPresenters[targetInputType].DeactivateAsync().Forget();
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
      var upView = view.upStageButtonView;
      directionPresenters[Up] = new UIStageButtonPresenter(upModel, upView);
      directionPresenters[Up].AttachOnDestroy(view.gameObject);
      directionPresenters[Up].DeactivateAsync().Forget();

      var rightModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 2,
        inputType: UIInputDirectionType.RightRight,
        onComplete: subscribeHandle.Unsubscribe,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var rightView = view.rightStageButtonView;
      directionPresenters[Right] = new UIStageButtonPresenter(rightModel, rightView);
      directionPresenters[Right].AttachOnDestroy(view.gameObject);
      directionPresenters[Right].DeactivateAsync().Forget();

      var downModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 3,
        inputType: UIInputDirectionType.RightDown,
        onComplete: subscribeHandle.Unsubscribe,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var downView = view.downStageButtonView;
      directionPresenters[Down] = new UIStageButtonPresenter(downModel, downView);
      directionPresenters[Down].AttachOnDestroy(view.gameObject);
      directionPresenters[Down].DeactivateAsync().Forget();

      var leftModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 4,
        inputType: UIInputDirectionType.RightLeft,
        onComplete: subscribeHandle.Unsubscribe,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var leftView = view.leftStageButtonView;
      directionPresenters[Left] = new UIStageButtonPresenter(leftModel, leftView);
      directionPresenters[Left].AttachOnDestroy(view.gameObject);
      directionPresenters[Left].DeactivateAsync().Forget();
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