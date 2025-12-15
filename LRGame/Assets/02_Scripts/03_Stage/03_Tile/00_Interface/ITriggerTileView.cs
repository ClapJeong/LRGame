using Cysharp.Threading.Tasks;
using System.Threading;

namespace LR.Stage.TriggerTile
{
  public interface ITriggerTileView : ITriggerEventSubscriber
  {
    public TriggerTileType GetTriggerType();
  }
}