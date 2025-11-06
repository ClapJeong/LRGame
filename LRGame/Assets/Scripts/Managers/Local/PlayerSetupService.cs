using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetupService : IStageObjectSetupService<IPlayerPresenter>
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

  public async UniTask<List<IPlayerPresenter>> SetupAsync(object data)
  {
    var setupData = data as SetupData;
    leftPlayer = await CreateLeftPlayer(setupData.leftPosition);
    rightPlayer = await CreateRighPlayer(setupData.rightPosition);

    return new List<IPlayerPresenter>() { leftPlayer, rightPlayer };
  }

  public void Release()
  {
    leftPlayer.EnableAllInputActions(false);
    rightPlayer.EnableAllInputActions(false);
  }

  public void EnablePlayers(bool enable)
  {
    leftPlayer.EnableAllInputActions(enable);
    rightPlayer.EnableAllInputActions(enable);
  }

  private async UniTask<IPlayerPresenter> CreateLeftPlayer(Vector3 startPosition)
  {
    var leftPlayerKey = GlobalManager.instance.Table.AddressableKeySO.LeftPlayer;
    var leftView = await GlobalManager.instance.ResourceManager.CreateAssetAsync<BasePlayerView>(leftPlayerKey);
    var model = new PlayerModel(Vector3.up,Vector3.down,Vector3.left,Vector3.right);
    var presenter = new BasePlayerPresenter();
    presenter.Initialize(leftView, model);
    presenter.SetWorldPosition(startPosition);

    var modelSO = GlobalManager.instance.Table.LeftPlayerModelSO;
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.UpKeyCode), Direction.Up);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.RightKeyCode), Direction.Right);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.DownKeyCode), Direction.Down);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.LeftKeyCode), Direction.Left);

    await UniTask.CompletedTask;
    return presenter;
  }

  private async UniTask<IPlayerPresenter> CreateRighPlayer(Vector3 startPosition)
  {
    var rightPlayerKey = GlobalManager.instance.Table.AddressableKeySO.RightPlayer;
    var rightView = await GlobalManager.instance.ResourceManager.CreateAssetAsync<BasePlayerView>(rightPlayerKey);
    var model = new PlayerModel(Vector3.up, Vector3.down, Vector3.left, Vector3.right);
    var presenter = new BasePlayerPresenter();
    presenter.Initialize(rightView, model);
    presenter.SetWorldPosition(startPosition);

    var modelSO = GlobalManager.instance.Table.RightPlayerModelSO;
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.UpKeyCode), Direction.Up);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.RightKeyCode), Direction.Right);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.DownKeyCode), Direction.Down);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.LeftKeyCode), Direction.Left);

    await UniTask.CompletedTask;
    return presenter;
  }

}
