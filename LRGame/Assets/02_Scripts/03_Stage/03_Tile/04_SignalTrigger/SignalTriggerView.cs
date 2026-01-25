#if UNITY_EDITOR
using System.Text;
using UnityEditor;
#endif

using UnityEngine;
using UnityEngine.Events;
using LR.Stage.TriggerTile.Enum;

namespace LR.Stage.TriggerTile
{
  public class SignalTriggerView : MonoBehaviour, ITriggerTileView
  {
    [field: Header("[ Key ]")]
    [field: SerializeField] public SignalEnter EnterType {  get; private set; }
    [field: SerializeField] public string EnterKey { get; private set; }

    [field: Header("[ Recycle ]")]
    [field: SerializeField] public SignalLife SignalLife { get; private set; }

    [field: Header("[ Input Fail ]")]
    [field: SerializeField] public SignalInputFail InputFail { get; private set; }

    [Space(10)]
    [SerializeField] private TriggerTileType triggerTileType = TriggerTileType.DefaultSignal;

    public bool IsEnterKeyExist
      => string.IsNullOrEmpty(EnterKey) == false;

    private const float DebuggingTextSpace = 0.6f;

    private readonly UnityEvent<Collider2D> onEnter = new();
    private readonly UnityEvent<Collider2D> onExit = new();

    public TriggerTileType GetTriggerType()
      => triggerTileType;

    public void SubscribeOnEnter(UnityAction<Collider2D> onEnter)
    {
      this.onEnter.RemoveListener(onEnter);
      this.onEnter.AddListener(onEnter);
    }

    public void SubscribeOnExit(UnityAction<Collider2D> onExit)
    {
      this.onExit.RemoveListener(onExit);
      this.onExit.AddListener(onExit);
    }

    public void UnsubscribeOnEnter(UnityAction<Collider2D> onEnter)
    {
      this.onEnter.AddListener(onEnter);
    }

    public void UnsubscribeOnExit(UnityAction<Collider2D> onExit)
    {
      this.onExit.AddListener(onExit);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      onEnter?.Invoke(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      onExit?.Invoke(collision);
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
      if (IsEnterKeyExist)
      {        
        Gizmos.color = Color.yellow;
        var stb = new StringBuilder("{ " + EnterKey +" }");
        var index = 0;

        stb.Append($"\nEnterType: {EnterType}");
        index++;

        if (EnterType != SignalEnter.None)
        {
          stb.Append($"\nInput Fail: {InputFail}");
          index++;
        }
        
        stb.Append($"\nSignalLife: {SignalLife}");
        index++;

        var labelCenterStyle = new GUIStyle(EditorStyles.label)
        {
          alignment = TextAnchor.MiddleCenter
        };
        Handles.Label(transform.position + DebuggingTextSpace * index * Vector3.up, stb.ToString(), labelCenterStyle);
      }        
    }
#endif
  }
}
