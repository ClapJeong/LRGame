using UnityEngine;

public interface ITriggerTile
{
  public abstract void Initialize();

  public void SubscribeOnEnter(Collider2D collider2D);

  public void UnsubscribeOnEnter(Collider2D collider2D);

  public void Enable(bool enabled);
}
