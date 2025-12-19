using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueCondition: IDirtyPatcher
  {
    private UnityAction onDirty;

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

    [SerializeField] private int targetID;
    [SerializeField] private int leftKey;
    [SerializeField] private int rightKey;

    public DialogueCondition(bool isDefault, UnityAction onDirty)
    {
      this.onDirty = onDirty;
      if (isDefault)
        targetID = -1;
    }

    public bool IsCondition(int leftKey, int rightKey)
       => this.leftKey == leftKey && this.rightKey == rightKey;

    public void SetOnDirty(UnityAction onDirty)
        => this.onDirty = onDirty;
  }
}