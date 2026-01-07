using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;
using LR.Stage.Player;
using LR.Table.Input;

public class PlayerService : 
  IStageObjectSetupService<IPlayerPresenter>, 
  IStageObjectControlService<IPlayerPresenter>,
  IPlayerGetter
{
  public class SetupData
  {
    public readonly Vector3 leftPosition;
    public readonly Vector3 rightPosition;
    public SetupData(Vector3 leftPosition, Vector3 rightPosition) 
    { 
      this.leftPosition = leftPosition; 
      this.rightPosition = rightPosition; 
    }
  }

  private readonly IStageStateHandler stageService;
  private readonly IStageResultHandler stageResultHandler;
  private readonly InputActionFactory inputActionFactory;
  private readonly IInputSequenceStopController inputQTEStopController;
  private readonly IInputSequenceStopController inputProgressStopController;

  private IPlayerPresenter leftPlayer;
  private IPlayerPresenter rightPlayer;

  private bool isSetupComplete = false;

  public PlayerService(IStageStateHandler stageService, IStageResultHandler stageResultHandler, InputActionFactory inputActionFactory, IInputSequenceStopController inputQTEStopController, IInputSequenceStopController inputProgressStopController)
  {
    this.stageService = stageService;
    this.stageResultHandler = stageResultHandler;
    this.inputActionFactory = inputActionFactory;
    this.inputQTEStopController = inputQTEStopController;
    this.inputProgressStopController = inputProgressStopController;
  }

  public async UniTask<List<IPlayerPresenter>> SetupAsync(object data, bool isEnableImmediately = false)
  {
    var setupData = data as SetupData;
    leftPlayer = await CreatePlayerAsync(PlayerType.Left, setupData.leftPosition);
    rightPlayer = await CreatePlayerAsync(PlayerType.Right, setupData.rightPosition);

    leftPlayer.Enable(isEnableImmediately);
    rightPlayer.Enable(isEnableImmediately);

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

  private async UniTask<IPlayerPresenter> CreatePlayerAsync(PlayerType playerType, Vector3 beginPosition)
  {
    var modelSO = GlobalManager.instance.Table.GetPlayerModelSO(playerType);
    var playerKey = 
      GlobalManager.instance.Table.AddressableKeySO.Path.Player +
      GlobalManager.instance.Table.AddressableKeySO.PlayerName.GetPlayerName(playerType);
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;

    var view = await resourceManager.CreateAssetAsync<BasePlayerView>(playerKey);
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
}
