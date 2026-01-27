using LR.Table.TriggerTile;
using UnityEngine;

namespace LR.Stage.SignalListener
{
  public abstract class BaseSignalPreview : MonoBehaviour
  {
    private SignalTriggerData signalTriggerData;
    protected SignalTriggerData SignalTriggerData
    {
      get
      {
        signalTriggerData ??= GlobalManager.instance.Table.TriggerTileModelSO.SignalTriggerData;
        return signalTriggerData;
      }
    }

    public abstract void Initialize(Vector3 worldPosition, Color color);

    public abstract void Activate();

    public abstract void Deactivate();

    public abstract void Restart();
  }
}
