using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIChapterButtonPresenter : IUIPresenter
  {
    public class Model
    {
      public int chapter;

      public Transform panelRoot;

      public IUIDepthService depthService;
      public IUIInputActionManager uiInputActionManager;
      public IResourceManager resourceManager;
      
      public IGameDataService gameDataService;
      public ISceneProvider sceneProvider;
      public IUIIndicatorService indicatorService;

      public Model(int chapter, Transform panelRoot, IUIDepthService depthService, IUIInputActionManager uiInputActionManager, IResourceManager resourceManager, IGameDataService gameDataService, ISceneProvider sceneProvider, IUIIndicatorService indicatorService)
      {
        this.chapter = chapter;
        this.panelRoot = panelRoot;
        this.depthService = depthService;
        this.uiInputActionManager = uiInputActionManager;
        this.resourceManager = resourceManager;
        this.gameDataService = gameDataService;
        this.sceneProvider = sceneProvider;
        this.indicatorService = indicatorService;
      }
    }

    private readonly Model model;
    private readonly UIChapterButtonView view;

    private readonly ReactiveProperty<float> leftSubmitProgress = new(0.0f);
    private readonly ReactiveProperty<float> rightSubmitProgress = new(0.0f);

    private UIChapterPanelPresenter panelPresenter;    

    public UIChapterButtonPresenter(Model model, UIChapterButtonView view)
    {
      this.model = model;
      this.view = view;

      leftSubmitProgress.Subscribe(view.leftProgressImageView.SetFillAmount);
      rightSubmitProgress.Subscribe(view.rightProgressImageView.SetFillAmount);

      view.tmpView.SetText(model.chapter.ToString());
      CreatePanelPresenterAsync()
        .ContinueWith(() =>
        {
          panelPresenter.DeactivateAsync().Forget();
        }).Forget();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if (view)
        view.DestroySelf();
    }    

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      UnsubscribeSubmit();
      await view.HideAsync(isImmediately, token);
      await UniTask.CompletedTask;
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      SubscribeSubmit();
      await view.ShowAsync(isImmediately, token);
      await UniTask.CompletedTask;
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    private async UniTask CreatePanelPresenterAsync()
    {
      var table = GlobalManager.instance.Table.AddressableKeySO;

      var model = new UIChapterPanelPresenter.Model(
        this.model.chapter,
        this.model.depthService,
        this.model.uiInputActionManager,
        onHide: () =>
        {
          rightSubmitProgress.Value = 0.0f;
          this.view.rightProgressImageView.SetFillAmount(0.0f);
          leftSubmitProgress.Value = 0.0f;
          this.view.leftProgressImageView.SetFillAmount(0.0f);
        },
        gameDataService: this.model.gameDataService,
        sceneProvider: this.model.sceneProvider,
        indicatorService: this.model.indicatorService);
      var path = table.Path.UI + table.UIName.LobbyChapterPanel;
      var view = await this.model.resourceManager.CreateAssetAsync<UIChapterPanelView>(path, this.model.panelRoot);
      panelPresenter = new UIChapterPanelPresenter(model, view);
      panelPresenter.AttachOnDestroy(this.view.gameObject);
    }

    #region Subscribe
    private void SubscribeSubmit()
    {
      var rightDirection = Direction.Right;
      view.progressSubmitView.SubscribeOnProgress(rightDirection, OnRightSubmitProgress);
      view.progressSubmitView.SubscribeOnCanceled(rightDirection, OnRightSubmitCancel);

      var leftDirection = Direction.Left;
      view.progressSubmitView.SubscribeOnProgress(leftDirection, OnLeftSubmitProgress);
      view.progressSubmitView.SubscribeOnCanceled(leftDirection, OnLeftSubmitCancel);
    }

    private void UnsubscribeSubmit()
    {
      view.progressSubmitView.UnsubscribeAll();
    }

    private void OnRightSubmitProgress(float value)
    {
      if (IsSubmitProgressComplete())
        return;

      rightSubmitProgress.Value = value;

      if (IsSubmitProgressComplete())
        panelPresenter.ActivateAsync().Forget();
    }
    
    private void OnRightSubmitCancel()
    {
      if (IsSubmitProgressComplete())
        return;

      rightSubmitProgress.Value = 0.0f;
    }

    private void OnLeftSubmitProgress(float value)
    {
      if (IsSubmitProgressComplete())
        return;

      leftSubmitProgress.Value = value;

      if (IsSubmitProgressComplete())
        panelPresenter.ActivateAsync().Forget();
    }

    private void OnLeftSubmitCancel()
    {
      if (IsSubmitProgressComplete())
        return;

      leftSubmitProgress.Value = 0.0f;
    }

    private bool IsSubmitProgressComplete()
      => rightSubmitProgress.Value + leftSubmitProgress.Value >= 1.0f;
    #endregion
  }
}