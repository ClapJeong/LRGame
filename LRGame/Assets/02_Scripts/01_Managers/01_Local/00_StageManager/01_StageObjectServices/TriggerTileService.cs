using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using LR.Stage.TriggerTile;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using LR.Stage.Player.Enum;
using LR.Stage.TriggerTile.Enum;
using LR.Stage.StageDataContainer;

public class TriggerTileService : 
  IStageObjectSetupService<ITriggerTilePresenter>, 
  IStageObjectControlService<ITriggerTilePresenter>,
  ITriggerTileEventSubscriber
{
  private readonly IEffectService effectService;
  private readonly IStageResultHandler stageResultHandler;
  private readonly IPlayerGetter playerGetter;
  private readonly TableContainer table;
  private readonly IInputProgressService inputProgressService;
  private readonly IInputQTEService inputQTEService;
  private readonly SignalService signalService;

  private readonly List<ITriggerTilePresenter> cachedTriggers = new();

  private readonly Dictionary<PlayerType, Dictionary<TriggerTileType, UnityEvent>> onEnterEvents = new();
  private readonly Dictionary<PlayerType, Dictionary<TriggerTileType, UnityEvent>> onExitEvents = new();

  private bool isSetupComplete = false;

  public TriggerTileService(IEffectService effectService, IStageResultHandler stageResultHandler, IPlayerGetter playerGetter, TableContainer table, IInputProgressService inputProgressService, IInputQTEService inputQTEService, SignalService signalService)
  {
    this.effectService = effectService;
    this.stageResultHandler = stageResultHandler;
    this.playerGetter = playerGetter;
    this.table = table;
    this.inputProgressService = inputProgressService;
    this.inputQTEService = inputQTEService;
    this.signalService = signalService;
  }

  public async UniTask<List<ITriggerTilePresenter>> SetupAsync(StageDataContainer stageDataContainer, bool isEnableImmediately = false)
  {
    var presenters = new List<ITriggerTilePresenter>();
    var views = stageDataContainer.TriggerTiles;
    var triggerDataSO = GlobalManager.instance.Table.TriggerTileModelSO;

    onEnterEvents[PlayerType.Left] = new();
    onEnterEvents[PlayerType.Right] = new();
    onExitEvents[PlayerType.Left] = new();
    onExitEvents[PlayerType.Right] = new();

    ITriggerTilePresenter presenter = null;

    foreach (var view in views)
    {
      var tileType = view.GetTriggerType();
      switch (tileType)
      {
        case TriggerTileType.LeftClear:
          {
            var model = new ClearTriggerTilePresenter.Model(
              table.TriggerTileModelSO.ClearTrigger,
              playerGetter, 
              stageResultHandler,
              effectService);
            var clearTriggerTileView = view as ClearTriggerTileView;
            presenter = new ClearTriggerTilePresenter(model, clearTriggerTileView);
          }
          break;

        case TriggerTileType.RightClear:
          {
            var model = new ClearTriggerTilePresenter.Model(
              table.TriggerTileModelSO.ClearTrigger, 
              playerGetter, 
              stageResultHandler,
              effectService); 
            var clearTriggerTileView = view as ClearTriggerTileView;
            presenter = new ClearTriggerTilePresenter(model, clearTriggerTileView);
          }
          break;

        case TriggerTileType.Spike:
          {
            var model = new SpikeTriggerTilePresenter.Model(triggerDataSO.SpikeTrigger, playerGetter, effectService);
            var spikeTriggerTileView = view as SpikeTriggerTileView;
            presenter = new SpikeTriggerTilePresenter(model, spikeTriggerTileView);
          }
          break;

        case TriggerTileType.DefaultEnergy:
          {
            var model = new EnergyItemTriggerPresenter.Model(
              table.TriggerTileModelSO.DefaultEnergyItemTriggerData,
              playerGetter,
              table);
            var defaultEnergyItemView = view as EnergyItemTriggerView;
            presenter = new EnergyItemTriggerPresenter(model, defaultEnergyItemView);
          }
          break;

        case TriggerTileType.InputtingEnergy:
          {
            var model = new InputtingEnergyItemTriggerPresenter.Model(
              table.TriggerTileModelSO.InputtingEnergyItemTriggerData,
              inputQTEService,
              inputProgressService,
              playerGetter,
              table);
            var inputtingEnergyItemTriggerView = view as InputtingEnergyItemTriggerView;
            presenter = new InputtingEnergyItemTriggerPresenter(model, inputtingEnergyItemTriggerView);
          }
          break;

        case TriggerTileType.DefaultSignal:
          {
            var model = new SignalTriggerPresenter.Model(
              table.TriggerTileModelSO.SignalTriggerData,
              table,
              signalService,
              signalService,
              playerGetter);
            var defaultSignalView = view as SignalTriggerView;
            presenter = new SignalTriggerPresenter(model, defaultSignalView);
          }
          break;

        case TriggerTileType.InputSignal:
          {
            var model = new InputSignalTriggerPresenter.Model(
              table.TriggerTileModelSO.SignalTriggerData,
              table,
              signalService,
              signalService,
              inputProgressService,
              inputQTEService,
              playerGetter);
            var inputSignalView = view as InputSignalTriggerView;
            presenter = new InputSignalTriggerPresenter(model, inputSignalView);
          }
          break;

        case TriggerTileType.Decay:
          {
            var model = new DecayTrigerTilePresenter.Model(
              playerGetter);
            var decayView = view as DecayTrigerTileView;
            presenter = new DecayTrigerTilePresenter(model, decayView);
          }
          break;

        default: throw new System.NotImplementedException();
      }

      if(presenter != null)
      {
        presenter.Enable(isEnableImmediately);
        presenters.Add(presenter);
        cachedTriggers.Add(presenter);

        view.SubscribeOnEnter(OnTriggerEnter);
        view.SubscribeOnEnter(OnTriggerExit);


        void OnTriggerEnter(Collider2D collider2D)
        {
          if (collider2D.CompareTag(Tag.PlayerTileTriggerCollider) == false)
            return;

          var playerType = collider2D
            .GetComponentInParent<IPlayerView>()
            .GetPlayerType();
          onEnterEvents[playerType].TryInvoke(tileType);
        }

        void OnTriggerExit(Collider2D collider2D)
        {
          if (collider2D.CompareTag(Tag.PlayerTileTriggerCollider) == false)
            return;

          var playerType = collider2D
            .GetComponentInParent<IPlayerView>()
            .GetPlayerType();
          onExitEvents[playerType].TryInvoke(tileType);
        }
      }      
    }

    isSetupComplete = true;
    await UniTask.CompletedTask;
    return presenters;
  }

  public void Release()
  {
    throw new System.NotImplementedException();
  }

  public void EnableAll(bool isEnable)
  {
    foreach (var presenter in cachedTriggers)
      presenter.Enable(isEnable);
  }

  public void RestartAll()
  {
    foreach (var presenter in cachedTriggers)
      presenter.Restart();
  }

  public async UniTask AwaitUntilSetupCompleteAsync()
  {
    await UniTask.WaitUntil(()=>isSetupComplete);
  }

  #region ITriggerTileEventHandler
  public void SubscribeOnEnter(PlayerType playerType, TriggerTileType type, UnityAction onEnter)
    => onEnterEvents[playerType].AddEvent(type, onEnter);

  public void SubscribeOnExit(PlayerType playerType, TriggerTileType type, UnityAction onExit)
    => onExitEvents[playerType].AddEvent(type, onExit);

  public void UnsubscribeOnEnter(PlayerType playerType, TriggerTileType type, UnityAction onEnter)
    => onEnterEvents[playerType].RemoveEvent(type, onEnter);

  public void UnsubscribeOnExit(PlayerType playerType, TriggerTileType type, UnityAction onExit)
    => onEnterEvents[playerType].RemoveEvent(type, onExit);
  #endregion
}
