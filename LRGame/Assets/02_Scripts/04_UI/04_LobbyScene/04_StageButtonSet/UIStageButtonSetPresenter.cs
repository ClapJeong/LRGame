using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.Lobby
{
  public class UIStageButtonSetPresenter : IUIPresenter
  {
    public class Model
    {
      public int chapter;

      public IUIInputManager uiInputActionManager;
      public IGameDataService gameDataService;
      public ISceneProvider sceneProvider;

      public Model(int chapter, IUIInputManager uiInputActionManager, IGameDataService gameDataService, ISceneProvider sceneProvider)
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

      var upStage = 1;
      model.gameDataService.GetScoreData(this.model.chapter, upStage, out var upLeft, out var upRight);
      var upModel = new UIStageButtonPresenter.Model(
        model.chapter,
        upStage,
        upLeft,
        upRight,
        InputDirection.RightUp,
        null,
        model.uiInputActionManager,
        model.gameDataService,
        model.sceneProvider);
      upPresenter = new(upModel, view.UpStageButtonView);

      var rightStage = 2;
      model.gameDataService.GetScoreData(this.model.chapter, rightStage, out var rightLeft, out var rightRight);
      var rightModel = new UIStageButtonPresenter.Model(
        model.chapter,
        rightStage,
        rightLeft,
        rightRight,
        InputDirection.RightRight,
        null,
        model.uiInputActionManager,
        model.gameDataService,
        model.sceneProvider);
      rightPresenter = new(rightModel, view.RightStageButtonView);

      var downStage = 3;
      model.gameDataService.GetScoreData(this.model.chapter, downStage, out var downLeft, out var downRight);
      var downModel = new UIStageButtonPresenter.Model(
        model.chapter,
        downStage,
        downLeft,
        downRight,
        InputDirection.RightDown,
        null,
        model.uiInputActionManager,
        model.gameDataService,
        model.sceneProvider);
      downPresenter = new(downModel, view.DownStageButtonView);

      var leftStage = 4;
      model.gameDataService.GetScoreData(this.model.chapter, leftStage, out var leftLeft, out var leftRight);
      var leftModel = new UIStageButtonPresenter.Model(
        model.chapter,
        leftStage,
        leftLeft,
        leftRight,
        InputDirection.RightLeft,
        null,
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

    public VisibleState GetVisibleState()
      => view.GetVisibleState();
  }
}
