using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetupService : MonoBehaviour, IStageObjectSetupService<BasePlayerPresenter>
{
  [SerializeField] private BasePlayerView testLeftPlayerView;
  [SerializeField] private BasePlayerView testRightPlayerView;

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
    var leftView = testLeftPlayerView;
    var model = new PlayerModel(Vector3.up,Vector3.down,Vector3.left,Vector3.right);
    var presenter = new BasePlayerPresenter();
    presenter.Initialize(leftView, model);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(KeyCode.W), Direction.Up);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(KeyCode.D), Direction.Right);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(KeyCode.S), Direction.Down);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(KeyCode.A), Direction.Left);

    await UniTask.CompletedTask;
    return presenter;
  }

  private async UniTask<IPlayerPresenter> CreateRighPlayer()
  {
    var leftView = testRightPlayerView;
    var model = new PlayerModel(Vector3.up, Vector3.down, Vector3.left, Vector3.right);
    var presenter = new BasePlayerPresenter();
    presenter.Initialize(leftView, model);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(KeyCode.UpArrow), Direction.Up);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(KeyCode.RightArrow), Direction.Right);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(KeyCode.DownArrow), Direction.Down);
    presenter.CreateMoveInputAction(InputActionPaths.ParshPath(KeyCode.LeftArrow), Direction.Left);

    await UniTask.CompletedTask;
    return presenter;
  }
}
