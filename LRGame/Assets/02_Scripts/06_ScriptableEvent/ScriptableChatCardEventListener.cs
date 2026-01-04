using ScriptableEvent;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvent
{

  public class ScriptableChatCardEventListener : MonoBehaviour
  {
    [SerializeField] private UnityEvent<int> action;

    private void OnEnable()
    {
      ScriptableEventSO.instance.RegisterChatCardEvent(this);      
    }

    private void OnDisable()
    {
      ScriptableEventSO.instance.UnRegisterChatCardEvent();
    }

    public void Raise(int index)
      => action?.Invoke(index);
  }
}