using UnityEngine;
using UnityEngine.Events;

public class ClearTriggerTilePresenter : ITriggerTilePresenter
{
  public class Model
  {
    public UnityAction<Collider2D> onEnter;
    public UnityAction<Collider2D> onExit;

    public Model(UnityAction<Collider2D> onEnter,UnityAction<Collider2D> onExit)
    {
      this.onEnter = onEnter;
      this.onExit = onExit;
    }
  }

  private readonly Model model;
  private readonly ClearTriggerTileView view;

  private ITriggerEventSubscriber subscriber;

  public ClearTriggerTilePresenter(Model model, ClearTriggerTileView view)
  {
    this.model = model;
    this.view = view;

    subscriber = view;
    subscriber.SubscribeOnEnter(model.onEnter);
    subscriber.SubscribeOnExit(model.onExit);
  }

  public void Enable(bool enabled)
  {
    
  }

  public void Restart()
  {
    
  }
}
