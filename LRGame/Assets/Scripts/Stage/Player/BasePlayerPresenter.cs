using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;

public class BasePlayerPresenter : IPlayerPresenter
{
  private BasePlayerView view;
  private PlayerModel model;

  private BasePlayerHPController hpController;
  private BasePlayerMoveController moveController;
  private BasePlayerReactionController reactionController;
  private BasePlayerInputActionController inputActionController;
  private PlayerStateController stateController;

  private CompositeDisposable disposables = new();

  public BasePlayerPresenter(PlayerType playerType, BasePlayerView view, PlayerModel model)
  {
    this.view = view;
    this.model = model;

    view.SetWorldPosition(model.beginPosition);    

    hpController = new BasePlayerHPController(playerType, model, spriteRenderer: view).AddTo(disposables);
    inputActionController = new BasePlayerInputActionController(model).AddTo(disposables);
    moveController = new BasePlayerMoveController(view, inputActionController: this, model).AddTo(disposables);
    reactionController = new BasePlayerReactionController(moveController: this, stateController: this).AddTo(disposables);    

    stateController = new PlayerStateController();
    disposables.Add(stateController);
    stateController.AddState(PlayerStateType.Idle, new PlayerIdleState(moveController: this, inputActionController:this, stateController: this));
    stateController.AddState(PlayerStateType.Move, new PlayerMoveState(moveController: this, inputActionController: this, stateController: this));
    var bounceData = GlobalManager.instance.Table.TriggerTileModelSO.SpikeTrigger.BounceData;
    stateController.AddState(PlayerStateType.Bounce, new PlayerBounceState(moveController: this, inputActionController:this, stateController: this, bounceData));

    stateController.ChangeState(PlayerStateType.Idle);

    SubscribeObservable();
  }

  private void SubscribeObservable()
  {
    view
      .FixedUpdateAsObservable()
      .Subscribe(_ => stateController.FixedUpdate()).AddTo(disposables);
    view
      .OnDestroyAsObservable()
      .Subscribe(_ => disposables.Dispose());
  }

  #region IStageObjectController
  public void Enable(bool enable)
  {
    EnableAllInputActions(enable);
  }

  public void Restart()
  {
    EnableAllInputActions(true);

    view.SetWorldPosition(model.beginPosition);
    SetHP(model.maxHP);
  }
  #endregion

  #region IPlayerMoveController
  public void SetLinearVelocity(Vector3 velocity)
    =>moveController.SetLinearVelocity(velocity);

  public void ApplyMoveAcceleration()
    => moveController.ApplyMoveAcceleration();

  public void ApplyMoveDeceleration()
    => moveController.ApplyMoveDeceleration();
  #endregion

  #region IPlayerInputActionController
  public void CreateMoveInputAction(Dictionary<string, Direction> pathDirectionPairs)
    => inputActionController.CreateMoveInputAction(pathDirectionPairs);

  public void CreateMoveInputAction(string path, Direction direction)
    => inputActionController.CreateMoveInputAction(path, direction);

  public void EnableInputAction(Direction direction, bool enable)
    => inputActionController.EnableInputAction(direction, enable);

  public void EnableAllInputActions(bool enable)
    => inputActionController.EnableAllInputActions(enable);

  public void SubscribeOnPerformed(UnityAction<Direction> performed)
    => inputActionController.SubscribeOnPerformed(performed);

  public void SubscribeOnCanceled(UnityAction<Direction> canceled)
    => inputActionController.SubscribeOnCanceled(canceled);

  public void UnsubscribePerfoemd(UnityAction<Direction> performed)
    => inputActionController.UnsubscribePerfoemd(performed);

  public void UnsubscribeCanceled(UnityAction<Direction> canceled)
    => inputActionController.UnsubscribeCanceled(canceled);

  public bool IsAnyInput()
    => inputActionController.IsAnyInput();
  #endregion

  #region IPlayerHPController
  public void SetHP(int value)
    =>hpController.SetHP(value);

  public void DamageHP(int damage)
    =>hpController.DamageHP(damage);

  public void RestoreHP(int value)
    =>hpController.RestoreHP(value);

  public void SubscribeOnHPChanged(UnityAction<int> onHPChanged)
    =>hpController.SubscribeOnHPChanged(onHPChanged);

  public void UnsubscribeOnHPChanged(UnityAction<int> onHPChanged)
    => hpController.UnsubscribeOnHPChanged(onHPChanged);

  public bool IsInvincible()
    => hpController.IsInvincible();

  public async UniTask PlayInvincible(float duration, UnityAction onFinished = null, CancellationToken token = default)
    => await hpController.PlayInvincible(duration, onFinished, token);
  #endregion

  #region IPlayerReactionController
  public void Bounce(BounceData data, Vector3 direction)
    => reactionController.Bounce(data, direction);

  public void ChangeState(PlayerStateType playerState)
    =>stateController.ChangeState(playerState);
  #endregion

  public void Dispose()
  {
    disposables.Dispose();
  }
}
