#if UNITY_EDITOR
using System.Text;
using UnityEditor;
#endif

using UnityEngine;
using UnityEngine.Events;
using LR.Stage.TriggerTile.Enum;

namespace LR.Stage.TriggerTile
{
  public class InputSignalTriggerView : MonoBehaviour, ITriggerTileView
  {
    [field: SerializeField] public Transform IconTransform { get; private set; }
    [field: SerializeField] public SpriteRenderer IconSpriteRenderer { get; private set; }
    [field: SerializeField] public SpriteRenderer InputSpriteRenderer {  get; private set; } 
    [field: Header("[ Key ]")]    
    [field: SerializeField] public string Key { get; private set; }

    [field: Header("[ Input ]")]
    [field: SerializeField] public SignalInput Input { get; private set; }
    [field: SerializeField] public SignalInputFail InputFail { get; private set; }

    [field: Header("[ Life ]")]
    [field: SerializeField] public SignalLife SignalLife { get; private set; }    

    [Space(10)]
    [SerializeField] private TriggerTileType triggerTileType = TriggerTileType.InputSignal;

    public bool IsEnterKeyExist
      => string.IsNullOrEmpty(Key) == false;

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

    public void SetAlpha(float alpha)
    {
      IconSpriteRenderer.SetAlpha(alpha);
      if(InputSpriteRenderer!=null)
        InputSpriteRenderer.SetAlpha(alpha);
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
        var stb = new StringBuilder("{ " + Key +" }");
        var index = 0;

        stb.Append($"\n{Input}");
        index++;

        stb.Append($"\nFail: {InputFail}");
        index++;

        stb.Append($"\n{SignalLife}");
        index++;

        var labelCenterStyle = new GUIStyle(EditorStyles.label)
        {
          alignment = TextAnchor.MiddleCenter
        };
        labelCenterStyle.normal.textColor = Color.red;
        Handles.Label(transform.position + DebuggingTextSpace * index * Vector3.up, stb.ToString(), labelCenterStyle);
      }        
    }
#endif
  }
}
