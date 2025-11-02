using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetupService : MonoBehaviour, IStageObjectSetupService<BasePlayerPresenter>
{
  private IPlayerPresenter leftPlayer;
  private IPlayerPresenter rightPlayer;

  public async UniTask SetupAsync()
  {
    leftPlayer = await CreateLeftPlayer();
    rightPlayer = await CreateRighPlayer();

    leftPlayer.EnableAllInputActions(true);
    rightPlayer.EnableAllInputActions(true);
  }

  public void Release()
  {
    throw new System.NotImplementedException();
  }

  private async UniTask<IPlayerPresenter> CreateLeftPlayer()
  {
    var leftPlayerKey = GameManager.instance.Table.AddressableKeySO.LeftPlayer;
    var leftView = await GameManager.instance.ResourceManager.CreateAssetAsync<BasePlayerView>(leftPlayerKey);
    var model = new PlayerModel(Vector3.up,Vector3.down,Vector3.left,Vector3.right);
    var presenter = new BasePlayerPresenter();
    presenter.Initialize(leftView, model);

    var modelSO = GameManager.instance.Table.LeftPlayerModelSO;
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.UpKeyCode), Direction.Up);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.RightKeyCode), Direction.Right);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.DownKeyCode), Direction.Down);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.LeftKeyCode), Direction.Left);

    await UniTask.CompletedTask;
    return presenter;
  }

  private async UniTask<IPlayerPresenter> CreateRighPlayer()
  {
    var rightPlayerKey = GameManager.instance.Table.AddressableKeySO.RightPlayer;
    var rightView = await GameManager.instance.ResourceManager.CreateAssetAsync<BasePlayerView>(rightPlayerKey);
    var model = new PlayerModel(Vector3.up, Vector3.down, Vector3.left, Vector3.right);
    var presenter = new BasePlayerPresenter();
    presenter.Initialize(rightView, model);

    var modelSO = GameManager.instance.Table.RightPlayerModelSO;
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.UpKeyCode), Direction.Up);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.RightKeyCode), Direction.Right);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.DownKeyCode), Direction.Down);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(modelSO.LeftKeyCode), Direction.Left);

    await UniTask.CompletedTask;
    return presenter;
  }
}
