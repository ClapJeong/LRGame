using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
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

      public Model(IUIDepthService depthService, IUIInputActionManager uiInputActionManager,IResourceManager resourceManager, int chapter)
      {
        this.depthService = depthService;
        this.uiInputActionManager = uiInputActionManager;
        this.resourceManager = resourceManager;
        this.chapter = chapter;
      }
    }

    private readonly Model model;
    private readonly UIChapterButtonViewContainer viewContainer;
    private readonly Transform panelRoot;

    private UIChapterPanelPresenter panelPresenter;

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
        this.model.uiInputActionManager);
      var path = table.Path.Ui + table.UIName.LobbyChapterPanel;
      var view = await this.model.resourceManager.CreateAssetAsync<UIChapterPanelViewContainer>(path, panelRoot);
      panelPresenter = new UIChapterPanelPresenter(model, view);
      panelPresenter.AttachOnDestroy(viewContainer.gameObject);
    }

    #region Subscribe
    private void SubscribeSubmit()
    {
      viewContainer.progressSubmitView.SubscribeOnProgress(Direction.Right, value => viewContainer.rightProgressImageView.SetFillAmount(value));
      viewContainer.progressSubmitView.SubscribeOnComplete(Direction.Right, () => panelPresenter.ShowAsync().Forget());
      viewContainer.progressSubmitView.SubscribeOnCanceled(Direction.Right, () => viewContainer.rightProgressImageView.SetFillAmount(0.0f));

      viewContainer.progressSubmitView.SubscribeOnProgress(Direction.Left, value => viewContainer.leftProgressImageView.SetFillAmount(value));
      viewContainer.progressSubmitView.SubscribeOnComplete(Direction.Left, () => panelPresenter.ShowAsync().Forget());
      viewContainer.progressSubmitView.SubscribeOnCanceled(Direction.Left, () => viewContainer.leftProgressImageView.SetFillAmount(0.0f));
    }

    private void UnsubscribeSubmit()
    {
      viewContainer.progressSubmitView.UnsubscribeAll();
    }
    #endregion
  }
}