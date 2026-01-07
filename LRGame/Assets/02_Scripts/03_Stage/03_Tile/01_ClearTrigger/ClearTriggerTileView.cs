using UnityEngine;
using UnityEngine.Events;

namespace LR.Stage.TriggerTile
{
  public class ClearTriggerTileView : MonoBehaviour, ITriggerTileView
  {
    [SerializeField] private TriggerTileType triggerTileType;
    [field: SerializeField] public Animator Animator { get; private set; }

    private readonly UnityEvent<Collider2D> onEnter = new();
    private readonly UnityEvent<Collider2D> onExit = new();

    private void OnValidate()
    {
      if(triggerTileType!=TriggerTileType.LeftClearTrigger &&
        triggerTileType!=TriggerTileType.RightClearTrigger)
        triggerTileType = TriggerTileType.LeftClearTrigger;
    }

    public TriggerTileType GetTriggerType()
      => triggerTileType;

    public void SubscribeOnEnter(UnityAction<Collider2D> onEnter)
    {
      this.onEnter.RemoveListener(onEnter);
      this.onEnter.AddListener(onEnter);
    }

    public void SubscribeOnExit(UnityAction<Collider2D> onExit)
    {
      this.onExit.RemoveListener(onExit);
      this.onExit.AddListener(onExit);
    }

    public void UnsubscribeOnEnter(UnityAction<Collider2D> onEnter)
    {
      this.onEnter.AddListener(onEnter);
    }

    public void UnsubscribeOnExit(UnityAction<Collider2D> onExit)
    {
      this.onExit.AddListener(onExit);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      onEnter?.Invoke(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      onExit?.Invoke(collision);
    }
  }
}