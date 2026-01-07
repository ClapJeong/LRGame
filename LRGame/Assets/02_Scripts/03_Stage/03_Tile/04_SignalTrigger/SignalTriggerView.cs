#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;
using UnityEngine.Events;

namespace LR.Stage.TriggerTile
{
  public class SignalTriggerView : MonoBehaviour, ITriggerTileView
  {
    public enum EnterSignalType
    {
      None,
      QTE,
      Progress,
    }

    public enum AftersignalType
    {
      None,
      Deactivate,
    }

    public enum InputFailType
    {
      Destroy,
      Bounce,
    }

    [field: Header("[ Key ]")]
    [field: SerializeField] public EnterSignalType EnterType {  get; private set; }
    [field: SerializeField] public string EnterKey { get; private set; }

    [field: Header("[ After Signal ]")]
    [field: SerializeField] public AftersignalType AfterSignal { get; private set; }

    [field: Header("[ Input Fail ]")]
    [field: SerializeField] public InputFailType InputFail { get; private set; }

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
        var labelCenterStyle = new GUIStyle(EditorStyles.label)
        {
          alignment = TextAnchor.MiddleCenter
        };
        var textIndex = 2;
        Handles.Label(transform.position + DebuggingTextSpace * textIndex * Vector3.up, $"EnterType: {EnterKey}", labelCenterStyle);
        textIndex++;

        if(EnterType != EnterSignalType.None)
        {          
          Handles.Label(transform.position + DebuggingTextSpace * textIndex * Vector3.up, $"Input Fail: {InputFail}", labelCenterStyle);
          textIndex++;
        }

        Handles.Label(transform.position + DebuggingTextSpace * textIndex * Vector3.up, $"After Signal: {AfterSignal}", labelCenterStyle);
      }        
    }
#endif
  }
}
