using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Stage.TriggerTile
{
  public class ClearTriggerTilePresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public IStageResultHandler stageResultHandler;

      public Model(IStageResultHandler stageResultHandler)
      {
        this.stageResultHandler = stageResultHandler;
      }
    }

    private readonly Model model;
    private readonly ClearTriggerTileView view;

    private bool isEnable = true;

    public ClearTriggerTilePresenter(Model model, ClearTriggerTileView view)
    {
      this.model = model;
      this.view = view;

      view.SubscribeOnEnter(OnEnter);
      view.SubscribeOnExit(OnExit);
    }

    public void Enable(bool enabled)
    {
      isEnable = enabled;
    }

    public void Restart()
    {

    }

    private void OnEnter(Collider2D collider2D)
    {
      if (!isEnable)
        return;

      switch (view.GetTriggerType())
      {
        case TriggerTileType.LeftClearTrigger:
          model.stageResultHandler.LeftClearEnter();
          break;

        case TriggerTileType.RightClearTrigger:
          model.stageResultHandler.RightClearEnter();
          break;

        default: throw new System.NotImplementedException();
      }
    }

    private void OnExit(Collider2D collider2D)
    {
      if (!isEnable)
        return;

      switch (view.GetTriggerType())
      {
        case TriggerTileType.LeftClearTrigger:
          model.stageResultHandler.LeftClearExit();
          break;

        case TriggerTileType.RightClearTrigger:
          model.stageResultHandler.RightClearExit();
          break;

        default: throw new System.NotImplementedException();
      }
    }
  }
}