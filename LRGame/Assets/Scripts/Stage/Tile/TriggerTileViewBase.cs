using UnityEngine;
using UnityEngine.Events;

public abstract class TriggerTileViewBase : MonoBehaviour, ITriggerTileView
{
  [SerializeField] protected TriggerTileType triggerTileType;

  public abstract TriggerTileType GetTriggerType();
  public abstract void Initialize(object model, ITriggerTilePresenter presenter);

  public abstract void Enable(bool enabled);

  public abstract void SubscribeOnEnter(UnityAction<Collider2D> onEnter);

  public abstract void SubscribeOnExit(UnityAction<Collider2D> onExit);

  public abstract void UnsubscribeOnEnter(UnityAction<Collider2D> onEnter);

  public abstract void UnsubscribeOnExit(UnityAction<Collider2D> onExit);
}
