using LR.Stage.Player;
using LR.Table.TriggerTile;
using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public class SignalTriggerPresenter : ITriggerTilePresenter
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
    private readonly SignalTriggerView view;

    private bool enable;
    private bool isSignalAcquired = false;
    private IDisposable rotatingDisposable;

    public SignalTriggerPresenter(Model model, SignalTriggerView view)
    {
      this.model = model;
      this.view = view;

      view.GlowEffect.enabled = false;
      view.SpriteRenderer.SetAlpha(model.data.DeactivateAlpha);
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
      view.GlowEffect.enabled = false;
      isSignalAcquired = false;
      view.SpriteRenderer.SetAlpha(model.data.DeactivateAlpha);
    }

    private void RegisterKeys()
    {
      if(view.IsEnterKeyExist)
        model.signalKeyRegister.RegisterKey(view.Key, view.GetHashCode(), view.SignalLife);
    }

    private void OnEnter(Collider2D collider2D)
    {
      if (!enable ||
          !collider2D.CompareTag(Tag.Player)||
          !view.IsEnterKeyExist)
        return;

      switch (view.Input)
      {
        case Enum.SignalInput.None:
          {
            OnSignalSuccess();
          }
          break;

        case Enum.SignalInput.QTE:
          {
            PlayQTE(collider2D);
          }
          break;

        case Enum.SignalInput.Progress:
          {
            PlayProgress(collider2D);
          }
          break;
      }

    }

    private void PlayQTE(Collider2D collider2D)
    {
      var enterPlayerType = collider2D.GetComponent<IPlayerView>().GetPlayerType();
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

      model.inputQTEService.Play(
        model.data.QTEData,
        enterPlayerKeyCodeData,
        view.transform.position,
        onSuccess: () =>
        {
          OnSignalSuccess();
          reactionController.SetInputting(false);
        },
        onFail: () =>
        {
          OnInputFail(collider2D);
          reactionController.SetInputting(false);
        });
    }

    private void PlayProgress(Collider2D collider2D)
    {
      var enterPlayerType = collider2D.GetComponent<IPlayerView>().GetPlayerType();
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

      model.inputProgressService.Play(
        model.data.ProgressData,
        enterPlayerKeyCodeData,
        view.transform.position,
        onProgress: null,
        onComplete: () =>
        {
          OnSignalSuccess();
          reactionController.SetInputting(false);
        },
        onFail: () =>
        {
          OnInputFail(collider2D);
          reactionController.SetInputting(false);
        });
    }

    private void OnSignalSuccess()
    {
      model.signalConsumer.AcquireSignal(view.Key, view.GetHashCode());
      isSignalAcquired = true;
      view.GlowEffect.enabled = true;
      view.SpriteRenderer.SetAlpha(model.data.ActivateAlpha);

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
                view.transform.Rotate(-360.0f * Time.deltaTime * model.data.RotateSpeed * Vector3.forward);
              });
          }
          break;
      }
    }

    private void OnInputFail(Collider2D collider2D)
    {
      var playerView = collider2D.gameObject.GetComponent<IPlayerView>();
      var playerType = playerView.GetPlayerType();
      var playerPresenter = model.playerGetter.GetPlayer(playerType);
      var reactionController = playerPresenter.GetReactionController();

      switch (view.InputFail)
      {
        case Enum.SignalInputFail.Bounce:
          {            
            var bounceDirection = (collider2D.transform.position - view.transform.position).normalized;            
            reactionController.Bounce(model.data.FailBounceData, bounceDirection);
          }
          break;

        case Enum.SignalInputFail.BounceAndStun:
          {
            var bounceDirection = (collider2D.transform.position - view.transform.position).normalized;
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
            view.GlowEffect.enabled = false;
            view.SpriteRenderer.SetAlpha(model.data.DeactivateAlpha);
          }
          break;
      }
    }
  }
}
