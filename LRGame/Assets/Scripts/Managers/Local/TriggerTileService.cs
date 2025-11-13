using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTileService : IStageObjectSetupService<ITriggerTilePresenter>, IStageObjectEnableService<ITriggerTilePresenter>
{
  public class Model
  {
    public readonly IStageController stageController;
    public readonly List<ITriggerTileView> existViews;
    public Model(List<ITriggerTileView> existViews, IStageController stageController) 
    { 
      this.existViews = existViews; 
      this.stageController = stageController;
    }
  }

  private readonly List<ITriggerTilePresenter> cachedTriggers = new();

  private Model model;
  private bool isLeftEnter;
  private bool isRightEnter;

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
            var model = new ClearTriggerTileModel();
            var presenter = new ClearTriggerTilePresenter(model, view);
            presenter.SubscribeOnEnter(OnLeftClearEnter);
            presenter.SubscribeOnExit(OnLeftClearExit);
            presenter.Enable(isEnableImmediately);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;

        case TriggerTileType.RightClearTrigger:
          {
            var model = new ClearTriggerTileModel();
            var presenter = new ClearTriggerTilePresenter(model, view);
            presenter.SubscribeOnEnter(OnRightClearEnter);
            presenter.SubscribeOnExit(OnRightClearExit);
            presenter.Enable(isEnableImmediately);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;

        case TriggerTileType.Spike:
          {
            var model = new SpikeTriggerTileModel();
            var presenter = new SpikeTriggerTilePresenter(model, view);
            presenter.SubscribeOnEnter(OnSpikeEnter);
            presenter.Enable(isEnableImmediately);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;
      }
    }

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
      IStageController stageController = LocalManager.instance.StageManager;
      stageController.Complete();
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
      IStageController stageController = LocalManager.instance.StageManager;
      stageController.Complete();
    }
  }

  private void OnRightClearExit(Collider2D collider2D)
  {
    isRightEnter=false;
  }

  private bool CheckBothClearEnter()
    => isLeftEnter && isRightEnter;

  private void OnSpikeEnter(Collider2D collider2D)
  {
    if(collider2D.gameObject.TryGetComponent<IPlayerView>(out var playerView))
    {
      switch (playerView.GetPlayerType())
      {
        case PlayerType.Left:
          model.stageController.OnLeftFailed();
          break;

        case PlayerType.Right:
          model.stageController.OnRightFailed();
          break;

        default: throw new System.NotImplementedException();
      }
    }
  }

  public void EnableAll(bool isEnable)
  {
    foreach (var presenter in cachedTriggers)
      presenter.Enable(isEnable);
  }
}
