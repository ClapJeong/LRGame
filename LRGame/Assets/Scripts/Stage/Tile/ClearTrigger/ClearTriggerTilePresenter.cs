using UnityEngine;
using UnityEngine.Events;

public class ClearTriggerTilePresenter : ITriggerTilePresenter
{
  private readonly ClearTriggerTileModel model;
  private readonly ITriggerTileView view;

  public ClearTriggerTilePresenter(ClearTriggerTileModel model, ITriggerTileView view)
  {
    this.model = model;
    this.view = view;
  }

  public void Enable(bool enabled)
    =>view.Enable(enabled);

  public void SubscribeOnEnter(UnityAction<Collider2D> onEnter)
    =>view.SubscribeOnEnter(onEnter);

  public void SubscribeOnExit(UnityAction<Collider2D> onExit)
    => view.SubscribeOnExit(onExit);

  public void UnsubscribeOnEnter(UnityAction<Collider2D> onEnter)
    =>view.UnsubscribeOnEnter(onEnter);

  public void UnsubscribeOnExit(UnityAction<Collider2D> onExit)
    =>view.UnsubscribeOnExit(onExit);
}
