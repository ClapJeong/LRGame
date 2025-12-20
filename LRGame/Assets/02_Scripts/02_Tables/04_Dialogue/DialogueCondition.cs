using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueCondition: IDirtyPatcher
  {
    private UnityAction onDirty;

    public string TargetSubName
    {
      get => this.targetSubName;
      set
      {
        if (targetSubName == value)
          return;

        onDirty?.Invoke();
        targetSubName = value;
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

    [SerializeField] private string targetSubName;
    [SerializeField] private int leftKey;
    [SerializeField] private int rightKey;

    public DialogueCondition( UnityAction onDirty)
    {
      this.onDirty = onDirty;
    }

    public bool IsCondition(int leftKey, int rightKey)
       => this.leftKey == leftKey && this.rightKey == rightKey;

    public void SetOnDirty(UnityAction onDirty)
        => this.onDirty = onDirty;
  }
}