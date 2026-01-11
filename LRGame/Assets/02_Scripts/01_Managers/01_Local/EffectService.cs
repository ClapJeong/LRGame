using Cysharp.Threading.Tasks;
using LR.Stage.Effect;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EffectService : IEffectService
{
  private class EffectPool
  {
    private readonly EffectType effectType;
    private readonly string basePath;
    private readonly IResourceManager resourceManager;
    private readonly int poolingCount;

    private readonly List<BaseEffectObject> enables = new();
    private readonly Queue<BaseEffectObject> disables = new();

    public EffectPool(EffectType effectType, string basePath, IResourceManager resourceManager, int poolingCount)
    {
      this.effectType = effectType;
      this.basePath = basePath;
      this.resourceManager = resourceManager;
      this.poolingCount = poolingCount;
    }

    public async UniTask PlayOnceAsync(EffectType effectType, Vector3 position, Quaternion rotation, Transform root, UnityAction onComplete)
    {
      var baseEffectObject = disables.Count > 0 ? disables.Dequeue()
                                                : await CreateAsync(root);
      baseEffectObject.transform.SetPositionAndRotation(position, rotation);
      baseEffectObject.gameObject.SetActive(true);

      enables.Add(baseEffectObject);

      baseEffectObject.PlayAsync(() =>
      {
        onComplete?.Invoke();
        if(disables.Count < poolingCount)
        {
          enables.Remove(baseEffectObject);
          if(baseEffectObject != null)
          {
            baseEffectObject.gameObject.SetActive(false);
            disables.Enqueue(baseEffectObject);
          }          
        }
        else
        {
          baseEffectObject.DestoryImmediately();
        }
      }).Forget();
    }

    private async UniTask<BaseEffectObject> CreateAsync(Transform root)
    {
      var path =
        basePath +
        effectType.ToString() +
        ".prefab";
      var baseEffectObject = await resourceManager.CreateAssetAsync<BaseEffectObject>(path, root);

      return baseEffectObject;
    }
  }
  private readonly Dictionary<EffectType, EffectPool> pools = new();

  private readonly IResourceManager resourceManager;
  private readonly AddressableKeySO addressableKeySO;
  private readonly EffectTableSO effectTableSO;
  private readonly Transform defaultRoot;

  public EffectService(IResourceManager resourceManager, AddressableKeySO addressableKeySO, EffectTableSO effectTableSO, Transform defaultRoot)
  {
    this.resourceManager = resourceManager;
    this.addressableKeySO = addressableKeySO;
    this.effectTableSO = effectTableSO;
    this.defaultRoot = defaultRoot;
  }

  public void Create(EffectType effectType, Vector3 position, Quaternion rotation, Transform root = null, UnityAction onComplete = null)
  {
    if(pools.TryGetValue(effectType, out var pool))
    {
      pool.PlayOnceAsync(effectType, position, rotation, root, onComplete).Forget();
    }
    else
    {
      var newPool = new EffectPool(effectType, addressableKeySO.Path.Effect, resourceManager, effectTableSO.PoolingCount);
      pools[effectType] = newPool;
      newPool.PlayOnceAsync(effectType,position,rotation, root, onComplete).Forget();
    }
  }

  public void Create(EffectType effectType, Vector3 position, Vector3 euler, Transform root = null,  UnityAction onComplete = null)
    => Create(effectType, position, Quaternion.Euler(euler), root, onComplete);
}
