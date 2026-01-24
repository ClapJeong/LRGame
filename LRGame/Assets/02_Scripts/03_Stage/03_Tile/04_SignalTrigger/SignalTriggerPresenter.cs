using LR.Stage.Player;
using LR.Table.TriggerTile;
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

    public SignalTriggerPresenter(Model model, SignalTriggerView view)
    {
      this.model = model;
      this.view = view;

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
      view.gameObject.SetActive(true);
    }

    private void RegisterKeys()
    {
      if(view.IsEnterKeyExist)
        model.signalKeyRegister.RegisterKey(view.EnterKey);
    }

    private void OnEnter(Collider2D collider2D)
    {
      if (!enable)
        return;
      if (collider2D.CompareTag(Tag.Player) == false)
        return;

      if (view.IsEnterKeyExist)
      {
        switch (view.EnterType)
        {
          case Enum.SignalEnter.None:
            {
              OnSignalSuccess();
            }
            break;

          case Enum.SignalEnter.QTE:
            {
              PlayQTE(collider2D);
            }
            break;

          case Enum.SignalEnter.Progress:
            {
              PlayProgress(collider2D);
            }
            break;
        }
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
      model.signalConsumer.AcquireSignal(view.EnterKey);
      isSignalAcquired = true;

      if(view.IsRecycable == false)
      {
        Enable(false);
        view.gameObject.SetActive(false);
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
      if (!enable)
        return;

      if (isSignalAcquired && view.IsEnterKeyExist)
        model.signalConsumer.ReleaseSignal(view.EnterKey);
    }
  }
}
