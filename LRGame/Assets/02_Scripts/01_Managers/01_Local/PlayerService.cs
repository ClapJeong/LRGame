using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;
using LR.Stage.Player;

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

  private IPlayerPresenter leftPlayer;
  private IPlayerPresenter rightPlayer;

  private bool isSetupComplete = false;

  public PlayerService(IStageStateHandler stageService, IStageResultHandler stageResultHandler)
  {
    this.stageService = stageService;
    this.stageResultHandler = stageResultHandler;
  }

  public async UniTask<List<IPlayerPresenter>> SetupAsync(object data, bool isEnableImmediately = false)
  {
    var setupData = data as SetupData;
    leftPlayer = await CreateLeftPlayerAsync(setupData.leftPosition);
    rightPlayer = await CreateRighPlayerAsync(setupData.rightPosition);

    leftPlayer.Enable(isEnableImmediately);
    rightPlayer.Enable(isEnableImmediately);

    isSetupComplete = true;

    return new List<IPlayerPresenter>() { leftPlayer, rightPlayer };
  }

  public void Release()
  {
    leftPlayer
      .GetInputActionController()
      .EnableAllInputActions(false);
    rightPlayer
      .GetInputActionController()
      .EnableAllInputActions(false);
  }

  private async UniTask<IPlayerPresenter> CreateLeftPlayerAsync(Vector3 beginPosition)
  {
    var modelSO = GlobalManager.instance.Table.LeftPlayerModelSO;
    var leftPlayerKey = 
      GlobalManager.instance.Table.AddressableKeySO.Path.Player +
      GlobalManager.instance.Table.AddressableKeySO.PlayerName.LeftPlayer;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;

    var leftView = await resourceManager.CreateAssetAsync<BasePlayerView>(leftPlayerKey);
    var leftModel = new PlayerModel(
      modelSO,
      PlayerType.Left,
      beginPosition,
      stageService: stageService,
      stageResultHandler: stageResultHandler);
    var presenter = new BasePlayerPresenter(leftModel, leftView);

    presenter
      .GetInputActionController()
      .CreateMoveInputAction(new Dictionary<string, Direction>()
    {
      { InputActionPaths.ParshPath(modelSO.Movement.UpKeyCode), Direction.Up },
      { InputActionPaths.ParshPath(modelSO.Movement.RightKeyCode), Direction.Right },
      { InputActionPaths.ParshPath(modelSO.Movement.DownKeyCode), Direction.Down },
      { InputActionPaths.ParshPath(modelSO.Movement.LeftKeyCode), Direction.Left },
    }); 

    await UniTask.CompletedTask;
    return presenter;
  }

  private async UniTask<IPlayerPresenter> CreateRighPlayerAsync(Vector3 beginPosition)
  {
    var modelSO = GlobalManager.instance.Table.RightPlayerModelSO;
    var rightPlayerKey =
      GlobalManager.instance.Table.AddressableKeySO.Path.Player + 
      GlobalManager.instance.Table.AddressableKeySO.PlayerName.RightPlayer;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;

    var rightView = await resourceManager.CreateAssetAsync<BasePlayerView>(rightPlayerKey);
    var rightModel = new PlayerModel(
      modelSO,
      PlayerType.Right,
      beginPosition,
      stageService: stageService,
      stageResultHandler: stageResultHandler);
    var presenter = new BasePlayerPresenter(rightModel, rightView);

    presenter
      .GetInputActionController()
      .CreateMoveInputAction(new Dictionary<string, Direction>()
    {
      { InputActionPaths.ParshPath(modelSO.Movement.UpKeyCode), Direction.Up },
      { InputActionPaths.ParshPath(modelSO.Movement.RightKeyCode), Direction.Right },
      { InputActionPaths.ParshPath(modelSO.Movement.DownKeyCode), Direction.Down },
      { InputActionPaths.ParshPath(modelSO.Movement.LeftKeyCode), Direction.Left },
    });

    await UniTask.CompletedTask;
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
