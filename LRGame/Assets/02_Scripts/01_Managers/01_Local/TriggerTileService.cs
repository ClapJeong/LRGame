using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using LR.Stage.TriggerTile;

public class TriggerTileService : IStageObjectSetupService<ITriggerTilePresenter>, IStageObjectControlService<ITriggerTilePresenter>
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

    public Model(IEffectService effectService, IStageResultHandler stageResultHandler, IPlayerGetter playerGetter, List<ITriggerTileView> existViews, TableContainer table, IInputProgressService inputProgressService, IInputQTEService inputQTEService)
    {
      this.effectService = effectService;
      this.stageResultHandler = stageResultHandler;
      this.playerGetter = playerGetter;
      this.existViews = existViews;
      this.table = table;
      this.inputProgressService = inputProgressService;
      this.inputQTEService = inputQTEService;
    }
  }

  private readonly List<ITriggerTilePresenter> cachedTriggers = new();

  private Model model;
  private bool isLeftEnter;
  private bool isRightEnter;

  private bool isSetupComplete = false;

  public async UniTask<List<ITriggerTilePresenter>> SetupAsync(object data, bool isEnableImmediately = false)
  {
    var presenters = new List<ITriggerTilePresenter>();
    this.model = data as Model;
    var triggerDataSO = GlobalManager.instance.Table.TriggerTileModelSO;
    ITriggerTilePresenter presenter = null;

    foreach (var view in model.existViews)
    {
      switch (view.GetTriggerType())
      {
        case TriggerTileType.LeftClearTrigger:
          {
            var model = new ClearTriggerTilePresenter.Model(this.model.stageResultHandler);
            var clearTriggerTileView = view as ClearTriggerTileView;
            presenter = new ClearTriggerTilePresenter(model, clearTriggerTileView);
          }
          break;

        case TriggerTileType.RightClearTrigger:
          {
            var model = new ClearTriggerTilePresenter.Model(this.model.stageResultHandler); 
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

        default: throw new System.NotImplementedException();
      }

      if(presenter != null)
      {
        presenter.Enable(isEnableImmediately);
        presenters.Add(presenter);
        cachedTriggers.Add(presenter);
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
}
