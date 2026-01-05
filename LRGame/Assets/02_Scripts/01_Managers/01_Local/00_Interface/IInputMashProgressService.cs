using UnityEngine.Events;

public interface IInputMashProgressService
{
  public void Play(
    CharacterMoveKeyCodeData keyCodeData, 
    InputMashProgressData data, 
    UnityAction<float> onProgress, 
    UnityAction onComplete,
    UnityAction onFail);

  public void Stop();
}
