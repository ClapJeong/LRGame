using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using LR.Stage.TriggerTile;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using LR.Stage.Player.Enum;
using LR.Stage.TriggerTile.Enum;

public class TriggerTileService : 
  IStageObjectSetupService<ITriggerTilePresenter>, 
  IStageObjectControlService<ITriggerTilePresenter>,
  ITriggerTileEventSubscriber
{
  public class Model
  {
    public readonly IEffectService effectService;
    public readonly IStageResultHandler stageResultHandler;
    public readonly IPlayerGetter playerGetter;
    public readonly List<ITriggerTileView> existViews;
    public readonly TableContainer table;
    public readonly IInputProgressService inputProgressService;
    public readonly IInputQTEService inputQTEService;
    public readonly SignalService signalService;

    public Model(IEffectService effectService, IStageResultHandler stageResultHandler, IPlayerGetter playerGetter, List<ITriggerTileView> existViews, TableContainer table, IInputProgressService inputProgressService, IInputQTEService inputQTEService, SignalService signalService)
    {
      this.effectService = effectService;
      this.stageResultHandler = stageResultHandler;
      this.playerGetter = playerGetter;
      this.existViews = existViews;
      this.table = table;
      this.inputProgressService = inputProgressService;
      this.inputQTEService = inputQTEService;
      this.signalService = signalService;
    }
  }

  private readonly List<ITriggerTilePresenter> cachedTriggers = new();

  private readonly Dictionary<PlayerType, Dictionary<TriggerTileType, UnityEvent>> onEnterEvents = new();
  private readonly Dictionary<PlayerType, Dictionary<TriggerTileType, UnityEvent>> onExitEvents = new();

  private Model model;

  private bool isSetupComplete = false;

  public async UniTask<List<ITriggerTilePresenter>> SetupAsync(object data, bool isEnableImmediately = false)
  {
    var presenters = new List<ITriggerTilePresenter>();
    this.model = data as Model;
    var triggerDataSO = GlobalManager.instance.Table.TriggerTileModelSO;

    onEnterEvents[PlayerType.Left] = new();
    onEnterEvents[PlayerType.Right] = new();
    onExitEvents[PlayerType.Left] = new();
    onExitEvents[PlayerType.Right] = new();

    ITriggerTilePresenter presenter = null;

    foreach (var view in model.existViews)
    {
      var tileType = view.GetTriggerType();
      switch (tileType)
      {
        case TriggerTileType.LeftClearTrigger:
          {
            var model = new ClearTriggerTilePresenter.Model(this.model.playerGetter, this.model.stageResultHandler);
            var clearTriggerTileView = view as ClearTriggerTileView;
            presenter = new ClearTriggerTilePresenter(model, clearTriggerTileView);
          }
          break;

        case TriggerTileType.RightClearTrigger:
          {
            var model = new ClearTriggerTilePresenter.Model(this.model.playerGetter, this.model.stageResultHandler); 
            var clearTriggerTileView = view as ClearTriggerTileView;
            presenter = new ClearTriggerTilePresenter(model, clearTriggerTileView);
          }
          break;

        case TriggerTileType.Spike:
          {
            var model = new SpikeTriggerTilePresenter.Model(triggerDataSO.SpikeTrigger, this.model.playerGetter, this.model.effectService);
            var spikeTriggerTileView = view as SpikeTriggerTileView;
            presenter = new SpikeTriggerTilePresenter(model, spikeTriggerTileView);
          }
          break;

        case TriggerTileType.RightEnergyItem:
          {
            var model = new RightEnergyItemTriggerPresenter.Model(
              this.model.table.TriggerTileModelSO.RightEnergyItemTrigger,
              this.model.inputProgressService,
              this.model.playerGetter,
              this.model.table);
            var rightEnergyItemView = view as RightEnergyItmeTriggerView;
            presenter = new RightEnergyItemTriggerPresenter(model, rightEnergyItemView);
          }
          break;

        case TriggerTileType.LeftEnergyItem:
          {
            var model = new LeftEnergyItemTriggerPresenter.Model(
              this.model.table.TriggerTileModelSO.LeftEnergyItemTrigger,
              this.model.inputQTEService,
              this.model.playerGetter,
              this.model.table);
            var leftEnergyItemView = view as LeftEnergyItemTriggerView;
            presenter = new LeftEnergyItemTriggerPresenter(model, leftEnergyItemView);
          }
          break;

        case TriggerTileType.DefaultSignal:
          {
            var model = new SignalTriggerPresenter.Model(
              this.model.table.TriggerTileModelSO.SignalTriggerData,
              this.model.table,
              this.model.signalService,
              this.model.signalService,
              this.model.playerGetter);
            var defaultSignalView = view as SignalTriggerView;
            presenter = new SignalTriggerPresenter(model, defaultSignalView);
          }
          break;

        case TriggerTileType.InputSignal:
          {
            var model = new InputSignalTriggerPresenter.Model(
              this.model.table.TriggerTileModelSO.SignalTriggerData,
              this.model.table,
              this.model.signalService,
              this.model.signalService,
              this.model.inputProgressService,
              this.model.inputQTEService,
              this.model.playerGetter);
            var inputSignalView = view as InputSignalTriggerView;
            presenter = new InputSignalTriggerPresenter(model, inputSignalView);
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
          if (collider2D.CompareTag(Tag.Player) == false)
            return;

          if (collider2D.TryGetComponent<IPlayerView>(out var playerView))
            onEnterEvents[playerView.GetPlayerType()].TryInvoke(tileType);
        }

        void OnTriggerExit(Collider2D collider2D)
        {
          if (collider2D.CompareTag(Tag.Player) == false)
            return;

          if (collider2D.TryGetComponent<IPlayerView>(out var playerView))
            onExitEvents[playerView.GetPlayerType()].TryInvoke(tileType);
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
