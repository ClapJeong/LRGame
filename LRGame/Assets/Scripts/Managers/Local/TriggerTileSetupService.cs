using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTileSetupService : IStageObjectSetupService<ITriggerTilePresenter>
{
  public class SetupData
  {
    public readonly List<TriggerTileViewBase> existViews;
    public SetupData(List<TriggerTileViewBase> existViews) 
    { 
      this.existViews = existViews; 
    }
  }

  private readonly List<ITriggerTilePresenter> cachedTriggers = new();

  private bool isLeftEnter;
  private bool isRightEnter;

  public async UniTask<List<ITriggerTilePresenter>> SetupAsync(object data)
  {
    var presenters = new List<ITriggerTilePresenter>();
    var setupData = data as SetupData;
    foreach(var view in setupData.existViews)
    {
      switch (view.GetTriggerType())
      {
        case TriggerTileType.LeftClearTrigger:
          {
            var presenter = new ClearTriggerTilePresenter();
            var model = new ClearTriggerTileModel();
            presenter.Initialize(model, view);
            presenter.SubscribeOnEnter(OnLeftClearEnter);
            presenter.SubscribeOnExit(OnLeftClearExit);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;

        case TriggerTileType.RightClearTrigger:
          {
            var presenter = new ClearTriggerTilePresenter();
            var model = new ClearTriggerTileModel();
            presenter.Initialize(model, view);
            presenter.SubscribeOnEnter(OnRightClearEnter);
            presenter.SubscribeOnExit(OnRightClearExit);
            presenters.Add(presenter);
            cachedTriggers.Add(presenter);
          }
          break;

        case TriggerTileType.Spike:
          {
            var presenter = new SpikeTriggerTilePresenter();
            var model = new SpikeTriggerTileModel();
            presenter.Initialize(model, view);
            presenter.SubscribeOnEnter(OnSpikeEnter);
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

  public void EnableAllTriggers(bool enabled)
  {
    foreach (var presenter in cachedTriggers)
      presenter.Enable(enabled);
  }

  private void OnLeftClearEnter(Collider2D collider2D)
  {
    isLeftEnter = true;

    if (CheckBothClearEnter())
      LocalManager.instance.StageManager.Complete();
  }

  private void OnLeftClearExit(Collider2D collider2D)
  {
    isLeftEnter = false;
  }

  private void OnRightClearEnter(Collider2D collider2D)
  {
    isRightEnter = true;

    if (CheckBothClearEnter())
      LocalManager.instance.StageManager.Complete();
  }

  private void OnRightClearExit(Collider2D collider2D)
  {
    isRightEnter=false;
  }

  private bool CheckBothClearEnter()
    => isLeftEnter && isRightEnter;

  private void OnSpikeEnter(Collider2D collider2D)
  {
    if(collider2D.gameObject.TryGetComponent<BasePlayerView>(out var playerView))
    {
      var failType = playerView.GetPlayerType() switch
      {
        PlayerType.Left => StageFailType.LeftPlayerDied,
        PlayerType.Right => StageFailType.RightPlayerDied,
        _ => throw new System.NotImplementedException()
      }; ;

      LocalManager.instance.StageManager.Fail(failType);
    }
  }
}
