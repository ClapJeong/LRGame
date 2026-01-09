using UnityEngine;
using LR.Stage.Player;
using LR.Table.TriggerTile;

namespace LR.Stage.TriggerTile
{
  public class SpikeTriggerTilePresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public SpikeTriggerData data;
      public IPlayerGetter playerGetter;
      public IEffectService effectService;

      public Model(SpikeTriggerData data, IPlayerGetter playerGetter, IEffectService effectService)
      {
        this.data = data;
        this.playerGetter = playerGetter;
        this.effectService = effectService;
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
      isEnable = true;
    }

    private void OnSpikeEnter(Collider2D collider2D)
    {
      if (collider2D.CompareTag(Tag.Player) == false)
        return;

      if (!isEnable)
        return;

      var playerView = collider2D.gameObject.GetComponent<IPlayerView>();
      var playerType = playerView.GetPlayerType();
      var playerPresenter = model.playerGetter.GetPlayer(playerType);

      if (playerPresenter.GetEnergyProvider().IsInvincible == false)
        playerPresenter.GetEnergyController().Damage(model.data.DamageValue);

      var bounceDirection = (collider2D.transform.position - view.transform.position).normalized;
      var reactionController = playerPresenter.GetReactionController();
      reactionController.Bounce(model.data.BounceData, bounceDirection);

      var playerPosition = playerView.Transform.position;
      model.effectService.Create(
        model.data.EffectType,
        playerPosition,
        Quaternion.identity);

    }
  }
}