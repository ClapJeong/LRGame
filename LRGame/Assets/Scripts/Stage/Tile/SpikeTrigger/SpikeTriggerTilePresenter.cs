using UnityEngine;
using UnityEngine.Events;

public class SpikeTriggerTilePresenter : ITriggerTilePresenter
{
  public class Model
  {
    public UnityAction<Collider2D> onEnter;
    public BounceData bounceData;

    public Model(UnityAction<Collider2D> onEnter, BounceData bounceData)
    {
      this.onEnter = onEnter;
      this.bounceData = bounceData;
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
      IPlayerHPController hpcontroller = playerPresenter;
      hpcontroller.DamageHP(1);
      var bounceDirection = (collider2D.transform.position - view.transform.position).normalized;
      IPlayerReactionController reactionController = playerPresenter;
      reactionController.Bounce(model.bounceData, bounceDirection);
    }
  }
}
