using LR.Table.Input;
using UnityEngine;
using UnityEngine.Events;

public interface IInputQTEService
{
  public void Play(
    InputQTEEnum.UIType uiType, 
    InputQTEData data, 
    CharacterMoveKeyCodeData keyCodeData, 
    Transform targetTransform,
    UnityAction onSuccess,
    UnityAction onFail);
  
  public void Play(
    InputQTEEnum.UIType uiType, 
    InputQTEData data, 
    CharacterMoveKeyCodeData keyCodeData, 
    Vector2 worldPosition,
    UnityAction onSuccess,
    UnityAction onFail);

  public void Stop();
}
