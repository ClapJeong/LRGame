using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIChapterPanelPresenter : IUIPresenter
  {
    public class Model
    {
      public int chapter;
      public int stageCount;

      public Model(int chapter, int stageCount)
      {
        this.chapter = chapter;
        this.stageCount = stageCount;
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
      IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;

      var model = new UIChapterPanelQuitButtonPresenter.Model(UIInputActionType.Space);
      presenterFactory.Register(() => new UIChapterPanelQuitButtonPresenter(model, viewContainer.quitButtonView));
      quitButtonPresenter = presenterFactory.Create<UIChapterPanelQuitButtonPresenter>();
      quitButtonPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void CreateStageButtonPresenters()
    {
      IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;

      var upModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter, 
        stage: model.stageCount, 
        inputType: UIInputActionType.RightUP,
        null);
      presenterFactory.Register(() => new UIStageButtonPresenter(upModel, viewContainer.upStageButtonView));
      upStagePresenter = presenterFactory.Create<UIStageButtonPresenter>();
      upStagePresenter.AttachOnDestroy(viewContainer.gameObject);

      var rightModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: model.stageCount,
        inputType: UIInputActionType.RightRight,
        null);
      presenterFactory.Register(() => new UIStageButtonPresenter(rightModel, viewContainer.rightStageButtonView));
      rightStagePresenter = presenterFactory.Create<UIStageButtonPresenter>();
      rightStagePresenter.AttachOnDestroy(viewContainer.gameObject);

      var downModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: model.stageCount,
        inputType: UIInputActionType.RightDown,
        null);
      presenterFactory.Register(() => new UIStageButtonPresenter(downModel, viewContainer.downStageButtonView));
      downStagePresenter = presenterFactory.Create<UIStageButtonPresenter>();
      downStagePresenter.AttachOnDestroy(viewContainer.gameObject);

      var leftModel = new UIStageButtonPresenter.Model(
        chapter: model.chapter,
        stage: model.stageCount,
        inputType: UIInputActionType.RightLeft,
        null);
      presenterFactory.Register(() => new UIStageButtonPresenter(leftModel, viewContainer.leftStageButtonView));
      leftStagePresenter = presenterFactory.Create<UIStageButtonPresenter>();
      leftStagePresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    private void RaiseDepth()
    {
      IUIDepthService depthService = GlobalManager.instance.UIManager;
      depthService.RaiseDepth(null);
    }

    private void LowerDepth()
    {
      IUIDepthService depthService = GlobalManager.instance.UIManager;
      depthService.LowerDepth();
    }
  }
}