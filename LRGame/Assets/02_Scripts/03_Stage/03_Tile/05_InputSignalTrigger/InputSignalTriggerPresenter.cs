using LR.Stage.Player;
using LR.Table.Input;
using LR.Table.TriggerTile;
using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public class InputSignalTriggerPresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public SignalTriggerData data;

      public TableContainer table;
      public ISignalKeyRegister signalKeyRegister;
      public ISignalConsumer signalConsumer;
      public IInputProgressService inputProgressService;
      public IInputQTEService inputQTEService;
      public IPlayerGetter playerGetter;

      public Model(SignalTriggerData data, TableContainer table, ISignalKeyRegister signalKeyRegister, ISignalConsumer signalConsumer, IInputProgressService inputProgressService, IInputQTEService inputQTEService, IPlayerGetter playerGetter)
      {
        this.data = data;
        this.table = table;
        this.signalKeyRegister = signalKeyRegister;
        this.signalConsumer = signalConsumer;
        this.inputProgressService = inputProgressService;
        this.inputQTEService = inputQTEService;
        this.playerGetter = playerGetter;
      }
    }

    private readonly Model model;
    private readonly InputSignalTriggerView view;

    private bool enable;
    private bool isSignalAcquired = false;
    private IDisposable rotatingDisposable;

    public InputSignalTriggerPresenter(Model model, InputSignalTriggerView view)
    {
      this.model = model;
      this.view = view;

      view.SetAlpha(model.data.DeactivateAlpha);
      view.SubscribeOnEnter(OnEnter);
      view.SubscribeOnExit(OnExit);
      RegisterKeys();
    }

    public void Enable(bool enable)
    {
      this.enable = enable; 
    }

    public void Restart()
    {
      Enable(true);
      isSignalAcquired = false;
      view.SetAlpha(model.data.DeactivateAlpha);
    }

    private void RegisterKeys()
    {
      if(view.IsEnterKeyExist)
        model.signalKeyRegister.RegisterKey(view.Key, view.GetHashCode(), view.SignalLife);
    }

    private void OnEnter(Collider2D collider2D)
    {
      if (!enable ||
          !collider2D.CompareTag(Tag.PlayerTileTriggerCollider) ||
          !view.IsEnterKeyExist)
        return;

      var enterPlayerType = collider2D.GetComponentInParent<IPlayerView>().GetPlayerType();
      var enterPlayerKeyCodeData = model
        .table
        .GetPlayerModelSO(enterPlayerType)
        .Movement
        .KeyCodeData;

      var reactionController = model
        .playerGetter
        .GetPlayer(enterPlayerType)
        .GetReactionController();
      reactionController.SetInputting(true);

      switch (view.Input)
      {
        case Enum.SignalInput.QTE:
          {
            PlayQTE(collider2D.transform, enterPlayerKeyCodeData, reactionController);
          }
          break;

        case Enum.SignalInput.Progress:
          {
            PlayProgress(collider2D.transform, enterPlayerKeyCodeData, reactionController);
          }
          break;
      }

    }

    private void PlayQTE(Transform playerTransform, CharacterMoveKeyCodeData keyCodeData, IPlayerReactionController reactionController)
    {
      model.inputQTEService.Play(
        model.data.QTEData,
        keyCodeData,
        view.transform.position,
        onSuccess: () =>
        {
          OnSignalSuccess();
          reactionController.SetInputting(false);
        },
        onFail: () =>
        {
          OnInputFail(playerTransform, reactionController);
          reactionController.SetInputting(false);
        });
    }

    private void PlayProgress(Transform playerTransform, CharacterMoveKeyCodeData keyCodeData, IPlayerReactionController reactionController)
    {
      model.inputProgressService.Play(
        model.data.ProgressData,
        keyCodeData,
        view.transform.position,
        onProgress: null,
        onComplete: () =>
        {
          OnSignalSuccess();
          reactionController.SetInputting(false);
        },
        onFail: () =>
        {
          OnInputFail(playerTransform, reactionController);
          reactionController.SetInputting(false);
        });
    }

    private void OnSignalSuccess()
    {
      model.signalConsumer.AcquireSignal(view.Key, view.GetHashCode());
      isSignalAcquired = true;
      view.SetAlpha(model.data.ActivateAlpha);

      switch (view.SignalLife)
      {
        case Enum.SignalLife.OnlyActivate:
          {
            Enable(false);
          }
          break;

        case Enum.SignalLife.ActivateAndDeactivate:
          {
            rotatingDisposable = view
              .gameObject
              .UpdateAsObservable()
              .Subscribe(_ =>
              {
                view.BackgroundTransform.Rotate(-360.0f * Time.deltaTime * model.data.RotateSpeed * Vector3.forward);
              });
          }
          break;
      }
    }

    private void OnInputFail(Transform playerTransform, IPlayerReactionController reactionController)
    {
      switch (view.InputFail)
      {
        case Enum.SignalInputFail.Bounce:
          {            
            var bounceDirection = (playerTransform.position - view.transform.position).normalized;            
            reactionController.Bounce(model.data.FailBounceData, bounceDirection);
          }
          break;

        case Enum.SignalInputFail.BounceAndStun:
          {
            var bounceDirection = (playerTransform.position - view.transform.position).normalized;
            reactionController.Bounce(model.data.FailBounceData, bounceDirection);
            reactionController.Stun();
          }
          break;
      }
    }

    private void OnExit(Collider2D collider2D)
    {
      if (!enable ||
          !isSignalAcquired ||
          !collider2D.CompareTag(Tag.PlayerTileTriggerCollider) ||
          !view.IsEnterKeyExist)
        return;

      switch (view.SignalLife)
      {
        case Enum.SignalLife.OnlyActivate:
          {
            
          }
          break;

        case Enum.SignalLife.ActivateAndDeactivate:
          {
            model.signalConsumer.ReleaseSignal(view.Key, view.GetHashCode());
            rotatingDisposable?.Dispose();
            view.transform.eulerAngles = Vector3.zero;
            view.SetAlpha(model.data.DeactivateAlpha);
          }
          break;
      }
    }
  }
}
