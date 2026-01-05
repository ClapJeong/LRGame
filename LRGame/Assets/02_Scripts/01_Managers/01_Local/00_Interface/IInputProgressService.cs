using UnityEngine;
using UnityEngine.Events;

public interface IInputProgressService
{
  public void Play(
    InputProgressEnum.InputProgressUIType type,
    CharacterMoveKeyCodeData keyCodeData, 
    InputMashProgressData data,
    Transform followTarget,
    UnityAction<float> onProgress, 
    UnityAction onComplete,
    UnityAction onFail);

  public void Play(
    InputProgressEnum.InputProgressUIType type,
    CharacterMoveKeyCodeData keyCodeData,
    InputMashProgressData data,
    Vector3 worldPosition,
    UnityAction<float> onProgress,
    UnityAction onComplete,
    UnityAction onFail);

  public void Stop();
}
