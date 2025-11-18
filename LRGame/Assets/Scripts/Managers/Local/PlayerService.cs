using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : IStageObjectSetupService<IPlayerPresenter>, IStageObjectControlService<IPlayerPresenter>
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

  private IPlayerPresenter leftPlayer;
  private IPlayerPresenter rightPlayer;

  private bool isSetupComplete = false;

  public async UniTask<List<IPlayerPresenter>> SetupAsync(object data, bool isEnableImmediately = false)
  {
    var setupData = data as SetupData;
    leftPlayer = await CreateLeftPlayer(setupData.leftPosition);
    rightPlayer = await CreateRighPlayer(setupData.rightPosition);

    leftPlayer.Enable(isEnableImmediately);
    rightPlayer.Enable(isEnableImmediately);

    isSetupComplete = true;

    return new List<IPlayerPresenter>() { leftPlayer, rightPlayer };
  }

  public void Release()
  {
    leftPlayer.EnableAllInputActions(false);
    rightPlayer.EnableAllInputActions(false);
  }

  private async UniTask<IPlayerPresenter> CreateLeftPlayer(Vector3 startPosition)
  {
    var modelSO = GlobalManager.instance.Table.LeftPlayerModelSO;
    var leftPlayerKey = 
      GlobalManager.instance.Table.AddressableKeySO.Path.Player +
      GlobalManager.instance.Table.AddressableKeySO.PlayerName.LeftPlayer;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;

    var leftView = await resourceManager.CreateAssetAsync<BasePlayerView>(leftPlayerKey);
    var model = new PlayerModel(
      modelSO,
      startPosition);
    var presenter = new BasePlayerPresenter();

    presenter.Initialize(leftView, model);

    presenter.CreateMoveInputAction(new Dictionary<string, Direction>()
    {
      { InputActionPaths.ParshPath(modelSO.Movement.UpKeyCode), Direction.Up },
      { InputActionPaths.ParshPath(modelSO.Movement.RightKeyCode), Direction.Right },
      { InputActionPaths.ParshPath(modelSO.Movement.DownKeyCode), Direction.Down },
      { InputActionPaths.ParshPath(modelSO.Movement.LeftKeyCode), Direction.Left },
    }); 

    await UniTask.CompletedTask;
    return presenter;
  }

  private async UniTask<IPlayerPresenter> CreateRighPlayer(Vector3 startPosition)
  {
    var modelSO = GlobalManager.instance.Table.RightPlayerModelSO;
    var rightPlayerKey =
      GlobalManager.instance.Table.AddressableKeySO.Path.Player + 
      GlobalManager.instance.Table.AddressableKeySO.PlayerName.RightPlayer;
    IResourceManager resourceManager = GlobalManager.instance.ResourceManager;

    var rightView = await resourceManager.CreateAssetAsync<BasePlayerView>(rightPlayerKey);
    var model = new PlayerModel(
          modelSO,
          startPosition);
    var presenter = new BasePlayerPresenter();

    presenter.Initialize(rightView, model);

    presenter.CreateMoveInputAction(new Dictionary<string, Direction>()
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
    leftPlayer.EnableAllInputActions(isEnable);
    rightPlayer.EnableAllInputActions(isEnable);
  }

  public void RestartAll()
  {
    leftPlayer.Restart();
    rightPlayer.Restart();
  }

  public IPlayerPresenter GetPresenter(PlayerType type)
    => type switch
    {
      PlayerType.Left => leftPlayer,
      PlayerType.Right => rightPlayer,
      _ => throw new System.NotImplementedException(),
    };

  public async UniTask AwaitUntilSetupCompleteAsync()
  {
    await UniTask.WaitUntil(()=> isSetupComplete);
  }
}
