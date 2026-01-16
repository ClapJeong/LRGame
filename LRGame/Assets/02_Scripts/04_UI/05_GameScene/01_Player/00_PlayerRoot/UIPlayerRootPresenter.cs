using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UnityEngine;
using LR.Stage.Player;
using LR.Stage.Player.Enum;
using LR.UI.Enum;
using LR.Stage.StageDataContainer;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerRootPresenter : IUIPresenter
  {
    public class Model
    {
      public TableContainer table;
      public StageManager stageManager;
      public PlayerType playerType;
      public IPlayerGetter playerGetter;
      public IUIInputManager uiInputManager;
      public UIManager uiManager;
      public StageDataContainer StageDataContainer;
      public IStageEventSubscriber stageEventSubscriber;
      public IGameDataService gameDataService;

      public Model(
        TableContainer table, 
        StageManager stageManager, 
        PlayerType playerType, 
        IPlayerGetter playerGetter, 
        IUIInputManager uiInputManager,
        UIManager uiManager,
        StageDataContainer StageDataContainer,
        IStageEventSubscriber stageEventSubscriber,
        IGameDataService gameDataService)
      {
        this.table = table;
        this.stageManager = stageManager;
        this.playerType = playerType;
        this.playerGetter = playerGetter;
        this.uiInputManager = uiInputManager;
        this.uiManager = uiManager;
        this.StageDataContainer = StageDataContainer;
        this.stageEventSubscriber = stageEventSubscriber;
        this.gameDataService = gameDataService;
      }

      public IPlayerPresenter GetPlayer()
        => playerGetter.GetPlayer(playerType);
    }

    private readonly Model model;
    private readonly UIPlayerRootView view;

    private readonly CTSContainer scoreCTS = new();

    private bool isAllPresentersCreated = false;

    private UIPlayerInputPresenter inputActionPresenter;
    private UIPlayerEnergyPresenter energyPresenter;
    private UIPlayerScorePresenter scorePresenter;

    public UIPlayerRootPresenter(Model model, UIPlayerRootView view)
    {
      this.model = model;
      this.view = view;

      model.uiManager.GetIUIPresenterContainer().Add(this);

      UniTask.WhenAll(
        CreateInputPresenterAsync(),
        CreateEnergyPresenterAsync(),
        CreateScorePresenterAsync())
        .ContinueWith(() => isAllPresentersCreated = true)
        .Forget();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      model.uiManager.GetIUIPresenterContainer().Remove(this);

      if (view)
        view.DestroySelf();
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      if (isAllPresentersCreated == false)
        await UniTask.WaitUntil(() => isAllPresentersCreated);

      await UniTask.WhenAll(
      inputActionPresenter.DeactivateAsync(isImmediately, token),
      energyPresenter.DeactivateAsync(isImmediately, token),
      scorePresenter.DeactivateAsync(isImmediately, token));
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      if (isAllPresentersCreated == false)
        await UniTask.WaitUntil(() => isAllPresentersCreated);

      await UniTask.WhenAll(
      inputActionPresenter.ActivateAsync(isImmediately, token),
      energyPresenter.ActivateAsync(isImmediately, token));
    }

    public async UniTask PlayScoreUIAsync()
    {
      scoreCTS.Dispose();
      scoreCTS.Create();
      model.uiInputManager.SubscribePerformedEvent(InputDirection.Space, SkipScoreUI);
      try
      { 
        var token = scoreCTS.token;
        await scorePresenter.ActivateAsync(false, token);
        await UniTask.WhenAll(
          energyPresenter.DecreaseForScoreAsync(token),
          scorePresenter.FillAmountAsync(token));
      }
      catch (OperationCanceledException) { }
      finally
      {
        model.uiInputManager.UnsubscribePerformedEvent(InputDirection.Space, SkipScoreUI);
      }
    }

    private void SkipScoreUI()
    {
      scoreCTS.Cancel();
    }

    private async UniTask CreateInputPresenterAsync()
    {
      await UniTask.WaitUntil(() => this.model.playerGetter.IsAllPlayerExist());

      var inputController = this.model.GetPlayer().GetInputActionController();

      var model = new UIPlayerInputPresenter.Model(inputController);
      var view = this.view.InputView;

      inputActionPresenter = new UIPlayerInputPresenter(model, view);
      inputActionPresenter.AttachOnDestroy(this.view.gameObject);
    }

    private async UniTask CreateEnergyPresenterAsync()
    {
      await UniTask.WaitUntil(() => this.model.playerGetter.IsAllPlayerExist());

      var playerTable = this.model.table.GetPlayerModelSO(this.model.playerType);
      var energyProvider = this.model.GetPlayer().GetEnergyProvider();

      var model = new UIPlayerEnergyPresenter.Model(
        energyProvider: energyProvider,
        playerTable.Energy,
        this.model.stageEventSubscriber,
        this.model.table.UISO);
      var view = this.view.EnergyView;

      energyPresenter = new UIPlayerEnergyPresenter(model, view);
      energyPresenter.AttachOnDestroy(this.view.gameObject);
    }

    private async UniTask CreateScorePresenterAsync()
    {
      await UniTask.WaitUntil(() => this.model.playerGetter.IsAllPlayerExist());

      var energyProvider = this.model.GetPlayer().GetEnergyProvider();
      var model = new UIPlayerScorePresenter.Model(
        this.model.table.UISO,
        this.model.gameDataService,
        energyProvider,
        this.model.playerType,
        this.model.StageDataContainer.scoreData,
        this.model.stageEventSubscriber);
      var view = this.view.ScoreView;

      scorePresenter = new UIPlayerScorePresenter(model, view);
      scorePresenter.AttachOnDestroy(this.view.gameObject);

      scorePresenter.DeactivateAsync(true).Forget();
    }
  }
}