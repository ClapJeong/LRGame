using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIStageButtonSetPresenter : IUIPresenter
  {
    public class Model
    {
      public int chapter;

      public IUIInputActionManager uiInputActionManager;
      public IGameDataService gameDataService;
      public ISceneProvider sceneProvider;

      public Model(int chapter, IUIInputActionManager uiInputActionManager, IGameDataService gameDataService, ISceneProvider sceneProvider)
      {
        this.chapter = chapter;
        this.uiInputActionManager = uiInputActionManager;
        this.gameDataService = gameDataService;
        this.sceneProvider = sceneProvider;
      }
    }

    private readonly Model model;
    private readonly UIStageButtonSetView view;

    private readonly UIStageButtonPresenter upPresenter;
    private readonly UIStageButtonPresenter rightPresenter;
    private readonly UIStageButtonPresenter downPresenter;
    private readonly UIStageButtonPresenter leftPresenter;

    private readonly SubscribeHandle subscribeHandle;

    public UIStageButtonSetPresenter(Model model, UIStageButtonSetView view)
    {
      this.model = model;
      this.view = view;

      var upModel = new UIStageButtonPresenter.Model(
        model.chapter,
        1,
        UIInputDirectionType.RightUp,
        Dispose,
        model.uiInputActionManager,
        model.gameDataService,
        model.sceneProvider);
      upPresenter = new(upModel, view.UpStageButtonView);

      var rightModel = new UIStageButtonPresenter.Model(
        model.chapter,
        2,
        UIInputDirectionType.RightRight,
        Dispose,
        model.uiInputActionManager,
        model.gameDataService,
        model.sceneProvider);
      rightPresenter = new(rightModel, view.RightStageButtonView);

      var downModel = new UIStageButtonPresenter.Model(
        model.chapter,
        3,
        UIInputDirectionType.RightDown,
        Dispose,
        model.uiInputActionManager,
        model.gameDataService,
        model.sceneProvider);
      downPresenter = new(downModel, view.DownStageButtonView);

      var leftModel = new UIStageButtonPresenter.Model(
        model.chapter,
        4,
        UIInputDirectionType.RightLeft,
        Dispose,
        model.uiInputActionManager,
        model.gameDataService,
        model.sceneProvider);
      leftPresenter = new(leftModel, view.LeftStageButtonView);

      subscribeHandle = new(
        onSubscribe: () =>
        {
          upPresenter.ActivateAsync().Forget();
          rightPresenter.ActivateAsync().Forget();
          downPresenter.ActivateAsync().Forget();
          leftPresenter.ActivateAsync().Forget();
        },
        onUnsubscribe: () =>
        {
          upPresenter.DeactivateAsync().Forget();
          rightPresenter.DeactivateAsync().Forget();
          downPresenter.DeactivateAsync().Forget();
          leftPresenter.DeactivateAsync().Forget();
        });
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      subscribeHandle.Subscribe();
      await view.ShowAsync(isImmedieately, token);
    }


    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      subscribeHandle.Unsubscribe();
      await view.HideAsync(isImmedieately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
      if (view)
        view.DestroySelf();
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();
  }
}
