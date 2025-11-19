using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvent
{
  public enum HPEventType
  {
    Damage,
    Restore
  }
  public class ScriptableHPEventListener : MonoBehaviour
  {
    [SerializeField] private PlayerType playerType;
    [SerializeField] private HPEventType type;
    [SerializeField] private UnityEvent<int> action;

    private void OnEnable()
    {
      switch (playerType)
      {
        case PlayerType.Left:
          ScriptableEventSO.instance.RegisterLeftHPEvent(this);
          break;

        case PlayerType.Right:
          ScriptableEventSO.instance.RegisterRightHPEvent(this);
          break;
      }      
    }

    private void OnDisable()
    {
      switch (playerType)
      {
        case PlayerType.Left:
          ScriptableEventSO.instance.UnregisterLeftHPEvent(this);
          break;

        case PlayerType.Right:
          ScriptableEventSO.instance.UnregisterRightHPEvent(this);
          break;
      }
    }

    public void Raise(int value)
    {
      switch (type)
      {
        case HPEventType.Damage:
          if (value < 0) 
            action?.Invoke(Mathf.Abs(value));
          break;

        case HPEventType.Restore:
          if(value > 0)
            action?.Invoke(value);
          break;

        default: throw new System.NotImplementedException();
      }
    }
  }
}