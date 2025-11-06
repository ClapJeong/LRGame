using UnityEngine;
using UnityEngine.Events;

public interface ITriggerTilePresenter: ITriggerEventSubscriber, ITriggerTileEnabler
{
  public void Initialize(object model, ITriggerTileView view);
}
