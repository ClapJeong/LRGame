using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;
using LR.Stage.TriggerTile;

public class TriggerTileService : IStageObjectSetupService<ITriggerTilePresenter>, IStageObjectControlService<ITriggerTilePresenter>
{
  public class Model
  {
    public readonly IStageService stageService;
    public readonly List<ITriggerTileView> existViews;
    public Model(List<ITriggerTileView> existViews, IStageService stageService) 
    { 
      this.existViews = existViews; 
      this.stageService = stageService;
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
    foreach(var view in model.existViews)
    {
      switch (view.GetTriggerType())
      {
        case TriggerTileType.LeftClearTrigger:
          {
            var model = new ClearTriggerTilePresenter.Model(OnLeftClearEnter,OnLeftClearExit);
            var clearTriggerTileView = view as ClearTriggerTileView;
            var presenter = new ClearTriggerTilePresenter(model, clearTriggerTileView);
            presenter.Enable(isEnableImmediately);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;

        case TriggerTileType.RightClearTrigger:
          {
            var model = new ClearTriggerTilePresenter.Model(OnRightClearEnter, OnRightClearExit); 
            var clearTriggerTileView = view as ClearTriggerTileView;
            var presenter = new ClearTriggerTilePresenter(model, clearTriggerTileView);
            presenter.Enable(isEnableImmediately);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;

        case TriggerTileType.Spike:
          {
            var model = new SpikeTriggerTilePresenter.Model(
              GlobalManager.instance.Table.TriggerTileModelSO.SpikeTrigger,
              onEnter: null);
            var spikeTriggerTileView = view as SpikeTriggerTileView;
            var presenter = new SpikeTriggerTilePresenter(model, spikeTriggerTileView);
            presenter.Enable(isEnableImmediately);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;
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

  private void OnLeftClearEnter(Collider2D collider2D)
  {
    isLeftEnter = true;

    if (CheckBothClearEnter())
    {
      IStageService stageService = LocalManager.instance.StageManager;
      stageService.Complete();
    }
  }

  private void OnLeftClearExit(Collider2D collider2D)
  {
    isLeftEnter = false;
  }

  private void OnRightClearEnter(Collider2D collider2D)
  {
    isRightEnter = true;

    if (CheckBothClearEnter())
    {
      IStageService stageService = LocalManager.instance.StageManager;
      stageService.Complete();
    }
  }

  private void OnRightClearExit(Collider2D collider2D)
  {
    isRightEnter=false;
  }

  private bool CheckBothClearEnter()
    => isLeftEnter && isRightEnter;

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
