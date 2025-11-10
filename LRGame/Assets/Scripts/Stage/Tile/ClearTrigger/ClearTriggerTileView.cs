using UnityEngine;
using UnityEngine.Events;

public class ClearTriggerTileView : MonoBehaviour, ITriggerTileView
{
  [SerializeField] private TriggerTileType triggerTileType;
  [SerializeField] private Animator animator;

  private readonly int enterHash = Animator.StringToHash("Enter");

  private UnityAction<Collider2D> onEnter;
  private UnityAction<Collider2D> onExit;
  private new bool enabled = true;

  public void Enable(bool enabled)
  {
    this.enabled = enabled;
  }

  public TriggerTileType GetTriggerType()
    => triggerTileType;

  public void SubscribeOnEnter(UnityAction<Collider2D> onEnter)
  {
    this.onEnter -= onEnter;
    this.onEnter += onEnter;
  }

  public void SubscribeOnExit(UnityAction<Collider2D> onExit)
  {
    this.onExit -= onExit;
    this.onExit += onExit;
  }

  public void UnsubscribeOnEnter(UnityAction<Collider2D> onEnter)
  {
    this.onEnter -= onEnter;
  }

  public void UnsubscribeOnExit(UnityAction<Collider2D> onExit)
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
