using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public class ClearTriggerTilePresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public readonly int LeftEnterHash = Animator.StringToHash("LeftEnter");
      public readonly int RightEnterHash = Animator.StringToHash("RightEnter");
      public readonly int IdleHash = Animator.StringToHash("Idle");

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
      isEnable = true;
    }

    private void OnEnter(Collider2D collider2D)
    {
      if (collider2D.CompareTag(Tag.Player) == false)
        return;
      if (!isEnable)
        return;
      

      switch (view.GetTriggerType())
      {
        case TriggerTileType.LeftClearTrigger:
          {
            model.stageResultHandler.LeftClearEnter();
            view.Animator.Play(model.LeftEnterHash);
          }          
          break;

        case TriggerTileType.RightClearTrigger:
          {
            model.stageResultHandler.RightClearEnter();
            view.Animator.Play(model.RightEnterHash);
          }          
          break;

        default: throw new System.NotImplementedException();
      }
    }

    private void OnExit(Collider2D collider2D)
    {
      if (collider2D.CompareTag(Tag.Player) == false)
        return;
      if (!isEnable)
        return;

      view.Animator.Play(model.IdleHash);

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