using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Stage.Effect
{
  public abstract class BaseEffectObject : MonoBehaviour
  {
    private EffectTableSO effectTable;
    protected EffectTableSO EffectTable
    {
      get
      {
        if (effectTable == null)
          effectTable = GlobalManager.instance.Table.EffectTableSO;

        return effectTable;
      }
    }

    public abstract UniTask PlayAsync(UnityAction onComplete = null);

    public abstract void DestoryImmediately();
  }
}