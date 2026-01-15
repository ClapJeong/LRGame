using LR.Table.Input;
using UnityEngine;
using UnityEngine.Events;

public interface IInputProgressService : IInputSequenceStopController
{
  public void Play(
    InputProgressData data,
    CharacterMoveKeyCodeData keyCodeData,
    Transform followTarget,
    UnityAction<float> onProgress, 
    UnityAction onComplete,
    UnityAction onFail);

  public void Play(
    InputProgressData data,
    CharacterMoveKeyCodeData keyCodeData,
    Vector3 worldPosition,
    UnityAction<float> onProgress,
    UnityAction onComplete,
    UnityAction onFail);
}
