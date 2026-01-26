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

      var reactionController = playerPresenter.GetReactionController();
      if (playerPresenter.GetEnergyProvider().IsInvincible == false)
        reactionController.DamageEnergy(model.data.DamageValue);
      //TODO: 에너지는안깎이는데피격바운스랑이펙트이런건계속중첩ㄷ이됨

      var bounceDirection = (collider2D.transform.position - view.transform.position).normalized;      
      reactionController.Bounce(model.data.BounceData, bounceDirection);
    }
  }
}