using UnityEngine;
using UnityEngine.Events;

namespace LR.Stage.TriggerTile
{
  public class SpikeTriggerTileView : MonoBehaviour, ITriggerTileView
  {
    [SerializeField] private TriggerTileType triggerTileType;

    private bool enable = true;
    private UnityAction<Collider2D> onEnter;
    private UnityAction<Collider2D> onExit;

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
      if (!enable) return;

      onEnter?.Invoke(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      if (!enable) return;

      onExit?.Invoke(collision);
    }
  }
}