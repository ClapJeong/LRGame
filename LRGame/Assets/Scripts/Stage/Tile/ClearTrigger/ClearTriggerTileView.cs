using UnityEngine;
using UnityEngine.Events;

public class ClearTriggerTileView : TriggerTileViewBase
{
  [SerializeField] private Animator animator;

  private readonly int enterHash = Animator.StringToHash("Enter");

  private ITriggerTilePresenter presenter;
  private UnityAction<Collider2D> onEnter;
  private UnityAction<Collider2D> onExit;
  private new bool enabled = true;

  public override void Initialize(object model, ITriggerTilePresenter presenter)
  {
    this.presenter = presenter;
  }

  public override void Enable(bool enabled)
  {
    this.enabled = enabled;
  }

  public override TriggerTileType GetTriggerType()
    => triggerTileType;

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
    if (!enabled) return;

    onEnter?.Invoke(collision);
    animator.SetBool(enterHash, true);
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    if (!enabled) return;

    onExit?.Invoke(collision);
    animator.SetBool(enterHash, false);
  }
}
