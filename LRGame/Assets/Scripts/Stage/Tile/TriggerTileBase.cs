using UnityEngine;

public abstract class TriggerTileBase : MonoBehaviour
{
  public abstract void Enable(bool enabled);

  public abstract void Initialize();

  public abstract void SubscribeOnEnter(Collider2D collider2D);

  public abstract void UnsubscribeOnEnter(Collider2D collider2D);
}
