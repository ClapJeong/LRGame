using UnityEngine;
using UnityEngine.Events;

public abstract class DynamicObstacleBase : MonoBehaviour
{
  public abstract void Initialize();

  public abstract void SubscribeListener(UnityEvent<ObstacleSignal> handler);

  public abstract void Enable(bool enabled);
}
