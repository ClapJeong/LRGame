using UnityEngine;
using UnityEngine.Events;

public class SpikeTriggerTilePresenter : ITriggerTilePresenter
{
  private SpikeTriggerTileModel model;
  private ITriggerTileView view;

  public void Initialize(object model, ITriggerTileView view)
  {
    this.model = model as SpikeTriggerTileModel;
    this.view = view;
  }

  public void Enable(bool enabled)
    => view.Enable(enabled);

  public void SubscribeOnEnter(UnityAction<Collider2D> onEnter)
    => view.SubscribeOnEnter(onEnter);

  public void SubscribeOnExit(UnityAction<Collider2D> onExit)
    => view.SubscribeOnExit(onExit);

  public void UnsubscribeOnEnter(UnityAction<Collider2D> onEnter)
    => view.UnsubscribeOnEnter(onEnter);

  public void UnsubscribeOnExit(UnityAction<Collider2D> onExit)
    => view.UnsubscribeOnExit(onExit);
}
