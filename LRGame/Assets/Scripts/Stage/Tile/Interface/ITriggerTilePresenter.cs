using UnityEngine;
using UnityEngine.Events;

public interface ITriggerTilePresenter: ITriggerEventSubscriber, IStageObjectEnabler
{
  public void Initialize(object model, ITriggerTileView view);
}
