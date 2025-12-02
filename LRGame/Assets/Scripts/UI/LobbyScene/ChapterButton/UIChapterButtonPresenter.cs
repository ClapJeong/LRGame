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
      public IUIDepthService depthService;
      public IUIInputActionManager uiInputActionManager;
      public IResourceManager resourceManager;
      public int chapter;
      public IGameDataService gameDataService;
      public ISceneProvider sceneProvider;
      public IUIIndicatorService indicatorService;

      public Model(IUIDepthService depthService, IUIInputActionManager uiInputActionManager, IResourceManager resourceManager, int chapter, IGameDataService gameDataService, ISceneProvider sceneProvider, IUIIndicatorService indicatorService)
      {
        this.depthService = depthService;
        this.uiInputActionManager = uiInputActionManager;
        this.resourceManager = resourceManager;
        this.chapter = chapter;
        this.gameDataService = gameDataService;
        this.sceneProvider = sceneProvider;
        this.indicatorService = indicatorService;
      }
    }

    private readonly Model model;
    private readonly UIChapterButtonViewContainer viewContainer;
    private readonly Transform panelRoot;

    private UIChapterPanelPresenter panelPresenter;
    private float leftSubmitProgress;
    private float rightSubmitProgress;

    public UIChapterButtonPresenter(Model model, UIChapterButtonViewContainer viewContainer, Transform panelRoot)
    {
      this.model = model;
      this.viewContainer = viewContainer;
      this.panelRoot = panelRoot;

      CreatePanelPresenterAsync().Forget();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {

    }    

    public async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      UnsubscribeSubmit();
      await UniTask.CompletedTask;
    }

    public async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      SubscribeSubmit();
      await UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public UIVisibleState GetVisibleState()
    {
      throw new NotImplementedException();
    }

    private async UniTask CreatePanelPresenterAsync()
    {
      var table = GlobalManager.instance.Table.AddressableKeySO;

      var model = new UIChapterPanelPresenter.Model(
        this.model.chapter,
        this.model.depthService,
        this.model.uiInputActionManager,
        onHide: () =>
        {
          rightSubmitProgress = 0.0f;
          viewContainer.rightProgressImageView.SetFillAmount(0.0f);
          leftSubmitProgress = 0.0f;
          viewContainer.leftProgressImageView.SetFillAmount(0.0f);
        },
        gameDataService: this.model.gameDataService,
        sceneProvider: this.model.sceneProvider,
        indicatorService: this.model.indicatorService);
      var path = table.Path.Ui + table.UIName.LobbyChapterPanel;
      var view = await this.model.resourceManager.CreateAssetAsync<UIChapterPanelViewContainer>(path, panelRoot);
      panelPresenter = new UIChapterPanelPresenter(model, view);
      panelPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    #region Subscribe
    private void SubscribeSubmit()
    {
      var rightDirection = Direction.Right;
      viewContainer.progressSubmitView.SubscribeOnProgress(rightDirection, value =>
      {
        if (IsSubmitProgressComplete())
          return;

        rightSubmitProgress = value;
        viewContainer.rightProgressImageView.SetFillAmount(value);

        if (IsSubmitProgressComplete())
          panelPresenter.ShowAsync().Forget();
      });
      viewContainer.progressSubmitView.SubscribeOnCanceled(rightDirection, () =>
      {
        if (IsSubmitProgressComplete())
          return;

        rightSubmitProgress = 0.0f;
        viewContainer.rightProgressImageView.SetFillAmount(0.0f);        
      });

      var leftDirection = Direction.Left;
      viewContainer.progressSubmitView.SubscribeOnProgress(leftDirection, value =>
      {
        if (IsSubmitProgressComplete())
          return;

        leftSubmitProgress = value;
        viewContainer.leftProgressImageView.SetFillAmount(value);

        if (IsSubmitProgressComplete())
          panelPresenter.ShowAsync().Forget();
      });
      viewContainer.progressSubmitView.SubscribeOnCanceled(leftDirection, () =>
      {
        if (IsSubmitProgressComplete())
          return;

        leftSubmitProgress = 0.0f;
        viewContainer.leftProgressImageView.SetFillAmount(0.0f);
      });
    }

    private void UnsubscribeSubmit()
    {
      viewContainer.progressSubmitView.UnsubscribeAll();
    }

    private bool IsSubmitProgressComplete()
      => rightSubmitProgress + leftSubmitProgress >= 1.0f;
    #endregion
  }
}