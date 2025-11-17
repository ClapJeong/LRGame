using UnityEngine;
using UnityEngine.Events;

public class SpikeTriggerTilePresenter : ITriggerTilePresenter
{
  private readonly SpikeTriggerTileModel model;
  private readonly ITriggerTileView view;

  public SpikeTriggerTilePresenter(SpikeTriggerTileModel model, ITriggerTileView view)
  {
    this.model = model as SpikeTriggerTileModel;
    this.view = view;
  }

  public void Enable(bool enabled)
  {

  }

  public void Restart()
  {
    
  }

  public void SubscribeOnEnter(UnityAction<Collider2D> onEnter)
    => view.SubscribeOnEnter(onEnter);

  public void SubscribeOnExit(UnityAction<Collider2D> onExit)
    => view.SubscribeOnExit(onExit);

  public void UnsubscribeOnEnter(UnityAction<Collider2D> onEnter)
    => view.UnsubscribeOnEnter(onEnter);

  public void UnsubscribeOnExit(UnityAction<Collider2D> onExit)
    => view.UnsubscribeOnExit(onExit);
}
