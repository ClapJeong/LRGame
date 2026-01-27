using LR.Stage.TriggerTile.Enum;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Stage.TriggerTile
{
  public class InputtingEnergyItemTriggerView : MonoBehaviour, ITriggerTileView
  {
    public enum EnergyItemInput
    {
      QTE,
      Progress,
    }
    [field: SerializeField] public EnergyItemInput Input { get; private set; }

    private readonly UnityEvent<Collider2D> onEnter = new();
    private readonly UnityEvent<Collider2D> onExit = new();

    public TriggerTileType GetTriggerType()
      => TriggerTileType.InputtingEnergy;

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
