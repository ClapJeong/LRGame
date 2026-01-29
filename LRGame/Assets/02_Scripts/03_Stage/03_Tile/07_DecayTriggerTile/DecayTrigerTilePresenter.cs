using LR.Stage.Player;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public class DecayTrigerTilePresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public IPlayerGetter playerGetter;

      public Model(IPlayerGetter playerGetter)
      {
        this.playerGetter = playerGetter;
      }
    }

    private readonly Model model;
    private readonly DecayTrigerTileView view;

    private bool enable = false;

    public DecayTrigerTilePresenter(Model model, DecayTrigerTileView view)
    {
      this.model = model;
      this.view = view;

      view.SubscribeOnEnter(OnEnter);
      view.SubscribeOnExit(OnExit);
    }

    public void Enable(bool enable)
      => this.enable = enable;

    public void Restart()
    {
      
    }

    private void OnEnter(Collider2D collider2D)
    {
      if (!enable)
        return;

      if (!collider2D.CompareTag(Tag.PlayerTileTriggerCollider))
        return;

      var playerType = collider2D
        .GetComponentInParent<BasePlayerView>()
        .GetPlayerType();

      var reactionController = model
        .playerGetter
        .GetPlayer(playerType)
        .GetReactionController();
      reactionController.Decaying(true);
    }

    private void OnExit(Collider2D collider2D)
    {
      if (!enable)
        return;

      if (!collider2D.CompareTag(Tag.PlayerTileTriggerCollider))
        return;

      var playerType = collider2D
        .GetComponentInParent<BasePlayerView>()
        .GetPlayerType();

      var reactionController = model
        .playerGetter
        .GetPlayer(playerType)
        .GetReactionController();
      reactionController.Decaying(false);
    }
  }
}
