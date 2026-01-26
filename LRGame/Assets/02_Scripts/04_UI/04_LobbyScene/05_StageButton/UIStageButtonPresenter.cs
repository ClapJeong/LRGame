using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using LR.UI.Enum;

namespace LR.UI.Lobby
{
  public class UIStageButtonPresenter : IUIPresenter
  {
    public class Model
    {
      public int chapter;
      public int stage;
      public bool leftScore;
      public bool rightScore;
      public InputDirection inputType;
      public UnityAction onComplete;

      public IUIInputManager uiInputActionManager;
      public IGameDataService gameDataService;
      public ISceneProvider sceneProvider;

      public Model(int chapter, int stage, bool leftScore, bool rightScore,InputDirection inputType, UnityAction onComplete, IUIInputManager uiInputActionManager, IGameDataService gameDataService, ISceneProvider sceneProvider)
      {
        this.chapter = chapter;
        this.stage = stage;
        this.leftScore = leftScore;
        this.rightScore = rightScore;
        this.inputType = inputType;
        this.onComplete = onComplete;
        this.uiInputActionManager = uiInputActionManager;
        this.gameDataService = gameDataService;
        this.sceneProvider = sceneProvider;
      }
    }

    private readonly Model model;
    private readonly UIStageButtonView view;

    private SubscribeHandle subscribeHandle;

    public UIStageButtonPresenter(Model model, UIStageButtonView view)
    {
      this.model = model;
      this.view = view;
      CreateSubscribeHandle();

      var topClearData = model.gameDataService.GetTopClearData();
      var currentIndex = Mathf.Max(0, (model.chapter - 1)) * 4 + model.stage;
      if(currentIndex > topClearData.ParseIndex() + 1)
      {
        view.CanvasGroup.alpha = 0.5f;
        view.ProgressSubmitView.Enable(false);
      }

      view.LeftScore.SetActive(model.leftScore);
      view.RightScore.SetActive(model.rightScore);

      view.HideAsync(true).Forget();
      view.TMP.text = model.stage.ToString();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Subscribe();
      await view.ShowAsync(isImmediately, token);
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Unsubscribe();
      await view.HideAsync(isImmediately, token);
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

    private void CreateSubscribeHandle()
    {
      subscribeHandle = new SubscribeHandle(
              () =>
              {
                SubscribeSubmitView();
                SubscribeInputAction();
              },
              () =>
              {
                UnsubscribeSubmitView();
                UnsubscribeInputAction();
              });
    }

    #region Subscribes
    private void SubscribeSubmitView()
    {
      var direction = model.inputType.ParseToDirection();

      view.ProgressSubmitView.SubscribeOnProgress(direction, view.FillImage.SetFillAmount);
      view.ProgressSubmitView.SubscribeOnComplete(direction, OnProgressComplete);
    }

    private void OnProgressComplete()
    {
      view.ProgressSubmitView.UnsubscribeAll();

      model.onComplete?.Invoke();

      model.gameDataService.SetSelectedStage(model.chapter, model.stage);
      model.sceneProvider.LoadSceneAsync(SceneType.Game).Forget();
    }

    private void UnsubscribeSubmitView()
    {
      view.ProgressSubmitView.Cancel(model.inputType.ParseToDirection());
      view.ProgressSubmitView.UnsubscribeAll();
      view.FillImage.fillAmount = 0.0f;
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
      => view.ProgressSubmitView.Perform(model.inputType.ParseToDirection());

    private void OnInputCanceled()
      => view.ProgressSubmitView.Cancel(model.inputType.ParseToDirection());
    #endregion
  }
}