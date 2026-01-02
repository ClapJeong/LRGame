using UnityEngine;
using UnityEngine.Events;

public interface IEffectService
{
  public void Create(
    EffectType effectType, 
    Vector3 position, 
    Quaternion rotation, 
    Transform root = null,
    UnityAction onComplete = null);

  public void Create(
    EffectType effectType, 
    Vector3 position, 
    Vector3 euler, 
    Transform root = null,
    UnityAction onComplete = null);
}
