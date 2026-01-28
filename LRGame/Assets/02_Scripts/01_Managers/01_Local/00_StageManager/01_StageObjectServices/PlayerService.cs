using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using LR.Stage.Player.Enum;
using LR.Stage.StageDataContainer;
using LR.Table.Input;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : 
  IStageObjectSetupService<IPlayerPresenter>, 
  IStageObjectControlService<IPlayerPresenter>,
  IPlayerGetter,
  IDisposable
{
  private readonly TableContainer table;
  private readonly IResourceManager resourceManager;
  private readonly IStageStateHandler stageService;
  private readonly IStageResultHandler stageResultHandler;
  private readonly InputActionFactory inputActionFactory;
  private readonly IInputSequenceStopController inputQTEStopController;
  private readonly IInputSequenceStopController inputProgressStopController;

  private IPlayerPresenter leftPlayer;
  private IPlayerPresenter rightPlayer;

  private bool isSetupComplete = false;

  public PlayerService(
    TableContainer table,
    IResourceManager resourceManager,
    IStageStateHandler stageService, 
    IStageResultHandler stageResultHandler, 
    InputActionFactory inputActionFactory, 
    IInputSequenceStopController inputQTEStopController, 
    IInputSequenceStopController inputProgressStopController)
  {
    this.table = table;
    this.resourceManager = resourceManager;
    this.stageService = stageService;
    this.stageResultHandler = stageResultHandler;
    this.inputActionFactory = inputActionFactory;
    this.inputQTEStopController = inputQTEStopController;
    this.inputProgressStopController = inputProgressStopController;
  }

  public async UniTask<List<IPlayerPresenter>> SetupAsync(StageDataContainer stageDataContainer, bool isEnableImmediately = false)
  {
    var root = stageDataContainer.playerRoot;
    var leftPosition = stageDataContainer.leftPlayerBeginTransform.position;
    var rightPosition = stageDataContainer.rightPlayerBeginTransform.position;

    leftPlayer = await CreatePlayerAsync(PlayerType.Left, leftPosition, root);
    rightPlayer = await CreatePlayerAsync(PlayerType.Right, rightPosition, root);

    leftPlayer.Enable(false);
    rightPlayer.Enable(false);

    isSetupComplete = true;

    return new List<IPlayerPresenter>() { leftPlayer, rightPlayer };
  }

  public void Release()
  {
    leftPlayer
      .GetInputActionController()
      .Dispose();
    rightPlayer
      .GetInputActionController()
      .Dispose();
  }

  private async UniTask<IPlayerPresenter> CreatePlayerAsync(PlayerType playerType, Vector3 beginPosition, Transform root)
  {
    var modelSO = table.GetPlayerModelSO(playerType);
    var playerKey =
      table.AddressableKeySO.Path.Player +
      table.AddressableKeySO.GameObjectName.GetPlayerName(playerType);

    var view = await resourceManager.CreateAssetAsync<BasePlayerView>(playerKey, root);
    var model = new PlayerModel(
      modelSO,
      playerType,
      beginPosition,
      stageService: stageService,
      stageResultHandler: stageResultHandler,
      playerGetter: this,
      inputActionFactory,
      playerType switch
      {
        PlayerType.Left => inputQTEStopController,
        PlayerType.Right => inputProgressStopController,
        _ => throw new System.NotImplementedException()
      });
    var presenter = new BasePlayerPresenter(model, view);

    presenter
      .GetInputActionController()
      .CreateMoveInputAction(new Dictionary<string, Direction>()
    {
      { InputActionPaths.ParshPath(modelSO.Movement.KeyCodeData.UP), Direction.Up },
      { InputActionPaths.ParshPath(modelSO.Movement.KeyCodeData.Right), Direction.Right },
      { InputActionPaths.ParshPath(modelSO.Movement.KeyCodeData.Down), Direction.Down },
      { InputActionPaths.ParshPath(modelSO.Movement.KeyCodeData.Left), Direction.Left },
    });

    return presenter;
  }

  public void EnableAll(bool isEnable)
  {
    leftPlayer
      .GetInputActionController()
      .EnableAllInputActions(isEnable);
    rightPlayer
      .GetInputActionController()
      .EnableAllInputActions(isEnable);
    if (isEnable)
    {
      rightPlayer
        .GetEnergyUpdater()
        .Resume();
      leftPlayer
        .GetEnergyUpdater()
        .Resume();
    }
    else
    {
      rightPlayer
        .GetEnergyUpdater()
        .Pause();
      leftPlayer
        .GetEnergyUpdater()
        .Pause();
    }
  }

  public void RestartAll()
  {
    leftPlayer.Restart();
    rightPlayer.Restart();
  }

  public IPlayerPresenter GetPlayer(PlayerType playerType)
  {
    if (!isSetupComplete)
      AwaitUntilSetupCompleteAsync().GetAwaiter().GetResult();

    return playerType switch
    {
      PlayerType.Left => leftPlayer,
      PlayerType.Right => rightPlayer,
      _ => throw new System.NotImplementedException(),
    };
  }

  public async UniTask AwaitUntilSetupCompleteAsync()
  {
    await UniTask.WaitUntil(() => isSetupComplete);
  }

  public bool IsAllPlayerExist()
    => leftPlayer != null && rightPlayer != null;

  public void Dispose()
  {
    resourceManager.ReleaseAsset(table.AddressableKeySO.Path.Player +
      table.AddressableKeySO.GameObjectName.GetPlayerName(PlayerType.Left));
    resourceManager.ReleaseAsset(table.AddressableKeySO.Path.Player +
      table.AddressableKeySO.GameObjectName.GetPlayerName(PlayerType.Right));
  }
}
