using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueCondition: IDirtyPatcher
  {
    private UnityAction onDirty;

    public string SubName
    {
      get => this.subName;
      set
      {
        if (subName == value)
          return;

        onDirty?.Invoke();
        subName = value;
      }
    }
    public int TargetID
    {
      get => this.targetID;
      set
      {
        if (targetID == value)
          return;

        onDirty?.Invoke();
        targetID = value;
      }
    }
    public int LeftKey
    {
      get => this.leftKey;
      set
      {
        if (leftKey == value)
          return;

        onDirty?.Invoke();
        leftKey = value;
      }
    }
    public int RightKey
    {
      get => this.rightKey;
      set
      {
        if (rightKey == value)
          return;

        onDirty?.Invoke();
        rightKey = value;
      }
    }

    [SerializeField] private string subName;
    [SerializeField] private int targetID;
    [SerializeField] private int leftKey;
    [SerializeField] private int rightKey;

    public DialogueCondition(string subName, UnityAction onDirty)
    {
      this.subName = subName;
      this.onDirty = onDirty;
    }

    public bool IsCondition(int leftKey, int rightKey)
       => this.leftKey == leftKey && this.rightKey == rightKey;

    public static DialogueCondition CreateDefault(UnityAction onDirty)
    {
      var defaultCondition = new DialogueCondition("default", onDirty);
      defaultCondition.TargetID = -1;
      return defaultCondition;
    }

    public void SetOnDirty(UnityAction onDirty)
        => this.onDirty = onDirty;
  }
}