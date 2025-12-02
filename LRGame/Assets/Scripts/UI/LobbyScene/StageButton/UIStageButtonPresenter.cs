using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.Lobby
{
  public class UIStageButtonPresenter : IUIPresenter
  {
    public class Model
    {
      public int chapter;
      public int stage;
      public UIInputActionType inputType;
      public UnityAction onClick;

      public IUIInputActionManager uiInputActionManager;
      public IGameDataService gameDataService;
      public ISceneProvider sceneProvider;

      public Model(int chapter, int stage, UIInputActionType inputType, UnityAction onClick, IUIInputActionManager uiInputActionManager, IGameDataService gameDataService, ISceneProvider sceneProvider)
      {
        this.chapter = chapter;
        this.stage = stage;
        this.inputType = inputType;
        this.onClick = onClick;
        this.uiInputActionManager = uiInputActionManager;
        this.gameDataService = gameDataService;
        this.sceneProvider = sceneProvider;
      }
    }

    private readonly Model model;
    private readonly UIStageButtonViewContainer viewContainer;

    private UIVisibleState visibleState;

    public UIStageButtonPresenter(Model model, UIStageButtonViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      viewContainer.tmpView.SetText(model.stage.ToString());
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if (visibleState == UIVisibleState.Showed)
        UnsubscribeInputAction();
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      SubscribeSubmitView();
      SubscribeInputAction();
      visibleState = UIVisibleState.Showed;
      return UniTask.CompletedTask;
    }

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      UnsubscribeSubmitView();
      UnsubscribeInputAction();
      visibleState = UIVisibleState.Hided;
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
      => this.visibleState = visibleState;

    public UIVisibleState GetVisibleState()
      => visibleState;

    #region Subscribes
    private void SubscribeSubmitView()
    {
      var direction = model.inputType.ParseToDirection();

      viewContainer.progressSubmitView.SubscribeOnProgress(direction, value =>
      {
        viewContainer.imageView.SetFillAmount(value);
      });
      viewContainer.progressSubmitView.SubscribeOnComplete(direction, () =>
      {
        viewContainer.progressSubmitView.UnsubscribeAll();

        model.onClick?.Invoke();

        model.gameDataService.SetSelectedStage(model.chapter, model.stage);

        model.sceneProvider.LoadSceneAsync(
          SceneType.Game,
          CancellationToken.None,
          onProgress: null,
          onComplete: null).Forget();
      });
    }

    private void UnsubscribeSubmitView()
    {
      viewContainer.progressSubmitView.UnsubscribeAll();
    }

    private void SubscribeInputAction()
    {
      model.uiInputActionManager.SubscribePerformedEvent(model.inputType, OnInputPerformed);
      model.uiInputActionManager.SubscribeCanceledEvent(model.inputType, OnInputCanceled);
    }

    private void UnsubscribeInputAction()
    {
      model.uiInputActionManager.UnsubscribePerformedEvent(model.inputType, OnInputPerformed);
      model.uiInputActionManager.UnsubscribeCanceledEvent(model.inputType, OnInputCanceled);
    }

    private void OnInputPerformed()
      => viewContainer.progressSubmitView.Perform(model.inputType.ParseToDirection());

    private void OnInputCanceled()
      => viewContainer.progressSubmitView.Cancel(model.inputType.ParseToDirection());
    #endregion
  }
}