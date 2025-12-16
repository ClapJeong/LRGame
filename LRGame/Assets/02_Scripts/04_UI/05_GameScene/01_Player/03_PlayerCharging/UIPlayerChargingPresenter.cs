using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using System;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerChargingPresenter : IUIPresenter
  {
    public class Model
    {
      public IPlayerStateProvider playerStateProvider;
      public IPlayerStateSubscriber playerStateSubscriber;

      public Model(IPlayerStateProvider playerStateProvider, IPlayerStateSubscriber playerStateSubscriber)
      {
        this.playerStateProvider = playerStateProvider;
        this.playerStateSubscriber = playerStateSubscriber;
      }
    }

    private readonly Model model;
    private readonly UIPlayerChargingView view;

    public UIPlayerChargingPresenter(Model model, UIPlayerChargingView view)
    {
      this.model = model;
      this.view = view;

      view.HideAsync(true).Forget();
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {     
      var currentState = model.playerStateProvider.GetCurrentState();
      if(currentState.IsCharging())
        view.ShowAsync(true).Forget();
      else
        view.HideAsync(true).Forget();

      SubscribePlayerState();
      await UniTask.CompletedTask;
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      view.HideAsync(true).Forget();
      UnsubscribePlayerState();
      await UniTask.CompletedTask;
    }

    public void Dispose()
    {
      if (view)
        view.DestroySelf();
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    private bool IsShowable()
      => GetVisibleState() == UIVisibleState.Hiding || GetVisibleState() == UIVisibleState.Hidden;

    private bool IsHidable()
      => GetVisibleState() == UIVisibleState.Showing || GetVisibleState() == UIVisibleState.Showen;

    private void SubscribePlayerState()
    {
      model.playerStateSubscriber.SubscribeOnEnter(PlayerStateType.ChargingIdle, OnEnterCharging);
      model.playerStateSubscriber.SubscribeOnEnter(PlayerStateType.ChargingMove, OnEnterCharging);

      model.playerStateSubscriber.SubscribeOnEnter(PlayerStateType.Idle, OnExitCharging);
      model.playerStateSubscriber.SubscribeOnEnter(PlayerStateType.Move, OnExitCharging);
      model.playerStateSubscriber.SubscribeOnEnter(PlayerStateType.Bounce, OnExitCharging);
    }

    private void UnsubscribePlayerState()
    {
      model.playerStateSubscriber.UnsubscribeOnEnter(PlayerStateType.ChargingIdle, OnEnterCharging);
      model.playerStateSubscriber.UnsubscribeOnEnter(PlayerStateType.ChargingMove, OnEnterCharging);

      model.playerStateSubscriber.UnsubscribeOnEnter(PlayerStateType.Idle, OnExitCharging);
      model.playerStateSubscriber.UnsubscribeOnEnter(PlayerStateType.Move, OnExitCharging);
      model.playerStateSubscriber.UnsubscribeOnEnter(PlayerStateType.Bounce, OnExitCharging);
    }

    private void OnEnterCharging()
    {
      if (IsShowable() == false)
        return;

      view.ShowAsync().Forget();
    }

    private void OnExitCharging()
    {
      if(IsHidable() == false) 
        return;

      view.HideAsync().Forget();
    }
  }
}