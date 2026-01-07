using UnityEngine;

namespace LR.Stage.InteractiveObject
{
  public abstract class BaseInteractiveObject : MonoBehaviour, IInteractiveObject
  {
    public abstract void Initialize(IStageStateProvider stageStateProvider);

    public abstract void Enable(bool enable);

    public abstract void Restart();
  }
}
