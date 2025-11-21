using System;
using System.Collections.Generic;
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
  private PlayerStateController stateController;

  private IDisposable viewFixedUpdate;

  public BasePlayerPresenter(PlayerType playerType, BasePlayerView view, PlayerModel model)
  {
    this.view = view;
    this.model = model;

    view.SetWorldPosition(model.beginPosition);    

    hpController = new BasePlayerHPController(playerType, model);
    moveController = new BasePlayerMoveController(view, model);

    stateController = new PlayerStateController();
    stateController.AddState(PlayerStateType.Idle, new PlayerIdleState(moveController,this));
    stateController.AddState(PlayerStateType.Move, new PlayerMoveState(this,moveController));
    stateController.AddState(PlayerStateType.Bounced, new PlayerBouncedState());

    stateController.ChangeState(PlayerStateType.Idle);

    viewFixedUpdate = view
      .FixedUpdateAsObservable()
      .Subscribe(_ => stateController.FixedUpdate());
    view
      .OnDestroyAsObservable()
      .Subscribe(_ => viewFixedUpdate.Dispose());
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
  public void CreateMoveInputAction(Dictionary<string, Direction> pathDirectionPairs)
    =>moveController.CreateMoveInputAction(pathDirectionPairs);

  public void CreateMoveInputAction(string path, Direction direction)
    =>moveController.CreateMoveInputAction(path, direction);  

  public void EnableInputAction(Direction direction, bool enable)
    =>moveController.EnableInputAction(direction, enable);

  public void EnableAllInputActions(bool enable)
    =>moveController.EnableAllInputActions(enable);

  public void SubscribeOnPerformed(UnityAction<Direction> performed)
    => moveController.SubscribeOnPerformed(performed);

  public void SubscribeOnCanceled(UnityAction<Direction> canceled)
    => moveController.SubscribeOnCanceled(canceled);

  public void UnsubscribePerfoemd(UnityAction<Direction> performed)
    => moveController.UnsubscribePerfoemd(performed);

  public void UnsubscribeCanceled(UnityAction<Direction> canceled)
    => moveController.UnsubscribeCanceled(canceled);

  public void ApplyMoveAcceleration()
    => moveController.ApplyMoveAcceleration();

  public void ApplyMoveDeceleration()
    => moveController.ApplyMoveDeceleration();
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
  #endregion

  #region IPlayerReactionController
  public void Bounce(BounceData data, Vector3 direction)
  {
    
    throw new System.NotImplementedException();
  }
  #endregion

  #region IStateController
  public void ChangeState(PlayerStateType playerState)
    => stateController.ChangeState(playerState);  
  #endregion
}
