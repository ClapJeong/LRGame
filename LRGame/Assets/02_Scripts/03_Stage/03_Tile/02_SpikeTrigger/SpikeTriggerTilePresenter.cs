using UnityEngine;
using UnityEngine.Events;
using LR.Stage.Player;

namespace LR.Stage.TriggerTile
{
  public class SpikeTriggerTilePresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public SpikeTriggerData data;
      public IPlayerGetter playerGetter;

      public Model(SpikeTriggerData data, IPlayerGetter playerGetter)
      {
        this.data = data;
        this.playerGetter = playerGetter;
      }
    }

    private readonly Model model;
    private readonly SpikeTriggerTileView view;

    private bool isEnable = true;

    public SpikeTriggerTilePresenter(Model model, SpikeTriggerTileView view)
    {
      this.model = model;
      this.view = view;

      view.SubscribeOnEnter(OnSpikeEnter);
    }

    public void Enable(bool enabled)
    {
      isEnable = enabled;
    }

    public void Restart()
    {

    }

    private void OnSpikeEnter(Collider2D collider2D)
    {
      if (collider2D.CompareTag("Player") == false)
        return;

      if (!isEnable)
        return;

      if (collider2D.gameObject.TryGetComponent<IPlayerView>(out var playerView))
      {
        var playerType = playerView.GetPlayerType();
        var playerPresenter = model.playerGetter.GetPlayer(playerType);
        
        if (playerPresenter.GetEnergyProvider().IsInvincible == false)
          playerPresenter.GetEnergyController().Damage(model.data.DamageValue);

        var bounceDirection = (collider2D.transform.position - view.transform.position).normalized;
        IPlayerReactionController reactionController = playerPresenter.GetReactionController();
        reactionController.Bounce(model.data.BounceData, bounceDirection);
      }
    }
  }
}