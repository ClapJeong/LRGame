using UnityEngine.Events;

public interface ITriggerTileEventSubscriber
{
  public void SubscribeOnEnter(PlayerType playerType, TriggerTileType type, UnityAction onEnter);

  public void SubscribeOnExit(PlayerType playerType, TriggerTileType type, UnityAction onExit);

  public void UnsubscribeOnEnter(PlayerType playerType, TriggerTileType type, UnityAction onEnter);

  public void UnsubscribeOnExit(PlayerType playerType, TriggerTileType type, UnityAction onExit);
}
