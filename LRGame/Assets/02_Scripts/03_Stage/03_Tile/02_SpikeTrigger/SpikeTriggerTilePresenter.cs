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
      public UnityAction<Collider2D> onEnter;

      public Model(SpikeTriggerData data, UnityAction<Collider2D> onEnter)
      {
        this.data = data;
        this.onEnter = onEnter;
      }
    }

    private readonly Model model;
    private readonly SpikeTriggerTileView view;

    public SpikeTriggerTilePresenter(Model model, SpikeTriggerTileView view)
    {
      this.model = model;
      this.view = view;

      view.SubscribeOnEnter(model.onEnter);
      view.SubscribeOnEnter(OnSpikeEnter);
    }

    public void Enable(bool enabled)
    {

    }

    public void Restart()
    {

    }

    private async void OnSpikeEnter(Collider2D collider2D)
    {
      if (collider2D.gameObject.TryGetComponent<IPlayerView>(out var playerView))
      {
        var playerType = playerView.GetPlayerType();
        var playerPresenter = await LocalManager.instance.StageManager.GetPresenterAsync(playerType);
        IPlayerEnergyController energyController = playerPresenter.GetEnergyController();
        if (energyController.IsInvincible() == false)
          energyController.Damage(model.data.DamageValue);

        var bounceDirection = (collider2D.transform.position - view.transform.position).normalized;
        IPlayerReactionController reactionController = playerPresenter.GetReactionController();
        reactionController.Bounce(model.data.BounceData, bounceDirection);
      }
    }
  }
}