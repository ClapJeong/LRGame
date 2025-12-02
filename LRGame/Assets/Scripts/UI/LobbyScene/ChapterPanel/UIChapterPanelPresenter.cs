using Cysharp.Threading.Tasks;
using System;
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

      public Model(int chapter, IUIDepthService depthService, IUIInputActionManager uiInputActionManager, UnityAction onHide, IGameDataService gameDataService, ISceneProvider sceneProvider)
      {
        this.chapter = chapter;
        this.depthService = depthService;
        this.uiInputActionManager = uiInputActionManager;
        this.onHide = onHide;
        this.gameDataService = gameDataService;
        this.sceneProvider = sceneProvider;
      }
    }    
    private readonly Model model;
    private readonly UIChapterPanelViewContainer viewContainer;

    private UIChapterPanelQuitButtonPresenter quitButtonPresenter;
    private UIStageButtonPresenter upStagePresenter;
    private UIStageButtonPresenter rightStagePresenter;
    private UIStageButtonPresenter downStagePresenter;
    private UIStageButtonPresenter leftStagePresenter;

    private UIVisibleState visibleState = UIVisibleState.None;

    public UIChapterPanelPresenter(Model model, UIChapterPanelViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      viewContainer.gameObjectView.SetActive(false);

      CreateQuitButtonPresenter();
      CreateStageButtonPresenters();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());
  
    public void Dispose()
    {
      if (viewContainer)
        viewContainer.gameObjectView.DestroyGameObject();
    }

    public async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await quitButtonPresenter.ShowAsync(isImmediately);
      await upStagePresenter.ShowAsync(isImmediately);
      await rightStagePresenter.ShowAsync(isImmediately);
      await downStagePresenter.ShowAsync(isImmediately);
      await leftStagePresenter.ShowAsync(isImmediately);

      RaiseDepth();

      viewContainer.gameObjectView.SetActive(true);
      visibleState = UIVisibleState.Showed;
    }

    public async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      model.onHide?.Invoke();
      await quitButtonPresenter.HideAsync(isImmediately);
      await upStagePresenter.HideAsync(isImmediately);
      await rightStagePresenter.HideAsync(isImmediately);
      await downStagePresenter.HideAsync(isImmediately);
      await leftStagePresenter.HideAsync(isImmediately);

      LowerDepth();

      viewContainer.gameObjectView.SetActive(false);
      visibleState = UIVisibleState.Hided;
    }

    public UIVisibleState GetVisibleState()
      => visibleState;

    public void SetVisibleState(UIVisibleState visibleState)
      => this.visibleState = visibleState;

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
      quitButtonPresenter = new UIChapterPanelQuitButtonPresenter(model, view);
      quitButtonPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void CreateStageButtonPresenters()
    {
      var upModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter, 
        stage: 1,
        inputType: UIInputActionType.RightUP,
        onClick: null,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var upView = viewContainer.upStageButtonView;
      upStagePresenter = new UIStageButtonPresenter(upModel, upView);
      upStagePresenter.AttachOnDestroy(viewContainer.gameObject);

      var rightModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 2,
        inputType: UIInputActionType.RightRight,
        onClick: null,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var rightView = viewContainer.rightStageButtonView;
      rightStagePresenter = new UIStageButtonPresenter(rightModel, rightView);
      rightStagePresenter.AttachOnDestroy(viewContainer.gameObject);

      var downModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 3,
        inputType: UIInputActionType.RightDown,
        onClick: null,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var downView = viewContainer.downStageButtonView;
      downStagePresenter = new UIStageButtonPresenter(downModel, downView);
      downStagePresenter.AttachOnDestroy(viewContainer.gameObject);

      var leftModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: 4,
        inputType: UIInputActionType.RightLeft,
        onClick: null,
        uiInputActionManager: model.uiInputActionManager,
        gameDataService: model.gameDataService,
        sceneProvider: model.sceneProvider);
      var leftView = viewContainer.leftStageButtonView;
      leftStagePresenter = new UIStageButtonPresenter(leftModel, leftView);
      leftStagePresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void RaiseDepth()
    {
      model.depthService.RaiseDepth(null);
    }

    private void LowerDepth()
    {
      model.depthService.LowerDepth();
    }
  }
}