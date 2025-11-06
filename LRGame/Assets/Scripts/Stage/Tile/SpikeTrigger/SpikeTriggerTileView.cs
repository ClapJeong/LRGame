using UnityEngine;
using UnityEngine.Events;

public class SpikeTriggerTileView : TriggerTileViewBase
{
  private ITriggerTilePresenter presenter;
  private bool enable = true;
  private UnityAction<Collider2D> onEnter;
  private UnityAction<Collider2D> onExit;

  public override void Enable(bool enabled)
  {
    this.enable = enabled;
  }

  public override TriggerTileType GetTriggerType()
    => triggerTileType;

  public override void Initialize( ITriggerTilePresenter presenter)
  {
    this.presenter = presenter;
  }

  public override void SubscribeOnEnter(UnityAction<Collider2D> onEnter)
  {
    this.onEnter -= onEnter;
    this.onEnter += onEnter;
  }

  public override void SubscribeOnExit(UnityAction<Collider2D> onExit)
  {
    this.onExit -= onExit;
    this.onExit += onExit;
  }

  public override void UnsubscribeOnEnter(UnityAction<Collider2D> onEnter)
  {
    this.onEnter -= onEnter;
  }

  public override void UnsubscribeOnExit(UnityAction<Collider2D> onExit)
  {
    this.onExit -= onExit;
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (!enable) return;

    onEnter?.Invoke(collision);
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    if (!enable) return;

    onExit?.Invoke(collision);
  }
}
