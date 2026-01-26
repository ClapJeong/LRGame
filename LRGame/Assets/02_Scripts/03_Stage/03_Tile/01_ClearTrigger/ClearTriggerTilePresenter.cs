using UnityEngine;
using LR.Stage.TriggerTile.Enum;
using LR.Stage.Player;
using LR.Table.TriggerTile;

namespace LR.Stage.TriggerTile
{
  public class ClearTriggerTilePresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public ClearTriggerData data;
      public IPlayerGetter playerGetter;
      public IStageResultHandler stageResultHandler;
      public IEffectService effectService;

      public Model(ClearTriggerData data, IPlayerGetter playerGetter, IStageResultHandler stageResultHandler, IEffectService effectService)
      {
        this.data = data;
        this.playerGetter = playerGetter;
        this.stageResultHandler = stageResultHandler;
        this.effectService = effectService;
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
      if (collider2D.CompareTag(Tag.PlayerTileTriggerCollider) == false)
        return;
      if (!isEnable)
        return;
     
      switch (view.GetTriggerType())
      {
        case TriggerTileType.LeftClearTrigger:
          {
            model.stageResultHandler.LeftClearEnter();            
            view.Animator.Play(AnimatorHash.ClearTriggerTile.Clip.LeftEnter);
          }          
          break;

        case TriggerTileType.RightClearTrigger:
          {
            model.stageResultHandler.RightClearEnter();
            view.Animator.Play(AnimatorHash.ClearTriggerTile.Clip.RightEnter);
          }          
          break;

        default: throw new System.NotImplementedException();
      }
      model.effectService.Create(model.data.EffectType, view.transform.position, Quaternion.identity);

      var playerType = collider2D.GetComponentInParent<IPlayerView>().GetPlayerType();
      model
        .playerGetter
        .GetPlayer(playerType)
        .GetReactionController()
        .Clear();
      collider2D.transform.parent.transform.position = view.transform.position;
    }

    private void OnExit(Collider2D collider2D)
    {
      if (collider2D.CompareTag(Tag.PlayerTileTriggerCollider) == false)
        return;
      if (!isEnable)
        return;

      view.Animator.Play(AnimatorHash.ClearTriggerTile.Clip.Idle);
    }
  }
}