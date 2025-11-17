using UnityEngine;
using UnityEngine.Events;

public class SpikeTriggerTileView : MonoBehaviour, ITriggerTileView, IGameObjectView
{
  [SerializeField] private TriggerTileType triggerTileType;

  private ITriggerTilePresenter presenter;
  private bool enable = true;
  private UnityAction<Collider2D> onEnter;
  private UnityAction<Collider2D> onExit;

  public TriggerTileType GetTriggerType()
    => triggerTileType;

  public void Initialize( ITriggerTilePresenter presenter)
  {
    this.presenter = presenter;
  }

  public void SetActive(bool active)
    =>gameObject.SetActive(active);

  public void SetRoot(Transform root)
    =>transform.SetParent(root);

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
    if (!enable) return;

    onEnter?.Invoke(collision);
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    if (!enable) return;

    onExit?.Invoke(collision);
  }
}
