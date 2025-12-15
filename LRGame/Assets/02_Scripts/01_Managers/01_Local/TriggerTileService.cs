using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;
using LR.Stage.TriggerTile;

public class TriggerTileService : IStageObjectSetupService<ITriggerTilePresenter>, IStageObjectControlService<ITriggerTilePresenter>
{
  public class Model
  {
    public readonly IStageResultHandler stageResultHandler;
    public readonly IPlayerGetter playerGetter;
    public readonly List<ITriggerTileView> existViews;

    public Model(IStageResultHandler stageResultHandler, IPlayerGetter playerGetter, List<ITriggerTileView> existViews)
    {
      this.stageResultHandler = stageResultHandler;
      this.playerGetter = playerGetter;
      this.existViews = existViews;
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

    foreach (var view in model.existViews)
    {
      switch (view.GetTriggerType())
      {
        case TriggerTileType.LeftClearTrigger:
          {
            var model = new ClearTriggerTilePresenter.Model(this.model.stageResultHandler);
            var clearTriggerTileView = view as ClearTriggerTileView;
            var presenter = new ClearTriggerTilePresenter(model, clearTriggerTileView);
            presenter.Enable(isEnableImmediately);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;

        case TriggerTileType.RightClearTrigger:
          {
            var model = new ClearTriggerTilePresenter.Model(this.model.stageResultHandler); 
            var clearTriggerTileView = view as ClearTriggerTileView;
            var presenter = new ClearTriggerTilePresenter(model, clearTriggerTileView);
            presenter.Enable(isEnableImmediately);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;

        case TriggerTileType.Spike:
          {
            var model = new SpikeTriggerTilePresenter.Model(triggerDataSO.SpikeTrigger, this.model.playerGetter);
            var spikeTriggerTileView = view as SpikeTriggerTileView;
            var presenter = new SpikeTriggerTilePresenter(model, spikeTriggerTileView);
            presenter.Enable(isEnableImmediately);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;

        case TriggerTileType.EnergyItem:
          {
            var model = new EnergyItemTriggerPresenter.Model(triggerDataSO.EnergyItem, this.model.playerGetter);
            var energyItemView = view as EnergyItemTriggerView;
            var presenter = new EnergyItemTriggerPresenter(model, energyItemView);
            presenter.Enable(isEnableImmediately);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;


        default: throw new System.NotImplementedException();
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
