using Cysharp.Threading.Tasks;
using LR.Stage.Effect;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EffectService : IEffectService
{
  private readonly Dictionary<EffectType, List<BaseEffectObject>> createdEffects = new();
  private readonly IResourceManager resourceManager;
  private readonly AddressableKeySO addressableKeySO;
  private Transform DefaultRoot
  {
    get
    {
      if (LocalManager.instance != null)
        return LocalManager.instance.StageManager.GetDefaultEffectRoot();
      else
        return null;
    }
  }

  public EffectService(IResourceManager resourceManager, AddressableKeySO addressableKeySO)
  {
    this.resourceManager = resourceManager;
    this.addressableKeySO = addressableKeySO;
  }

  public void Create(EffectType effectType, Vector3 position, Quaternion rotation, Transform root = null, bool autoDestroy = true, UnityAction onComplete = null)
    => CreateAsync(effectType, position, rotation, root ?? DefaultRoot, autoDestroy, onComplete).Forget();

  public void Create(EffectType effectType, Vector3 position, Vector3 euler, Transform root = null, bool autoDestroy = true, UnityAction onComplete = null)
    => Create(effectType, position, Quaternion.Euler(euler), root, autoDestroy, onComplete);

  private async UniTask CreateAsync(EffectType effectType, Vector3 position, Quaternion rotation, Transform root, bool autoDestroy, UnityAction onComplete)
  {
    var path =
      addressableKeySO.Path.Effect +
      effectType.ToString() +
      ".prefab";
    var baseEffectObject = await resourceManager.CreateAssetAsync<BaseEffectObject>(path, root);
    baseEffectObject.transform.SetPositionAndRotation(position, rotation);

    AddBaseEffectObject(effectType, baseEffectObject);

    baseEffectObject.PlayAsync(() =>
    {
      onComplete?.Invoke();
      RemoveBaseEffectObject(effectType, baseEffectObject);
    }, autoDestroy).Forget();
  }


  private void AddBaseEffectObject(EffectType effectType, BaseEffectObject baseEffectObject)
  {
    if (createdEffects.TryGetValue(effectType, out var existList))
      existList.Add(baseEffectObject);
    else
      createdEffects[effectType] = new() { baseEffectObject };
  }

  private void RemoveBaseEffectObject(EffectType effectType, BaseEffectObject baseEffectObject)
  {
    if (createdEffects.TryGetValue(effectType, out var existList))
      existList.Remove(baseEffectObject);
  }
}
