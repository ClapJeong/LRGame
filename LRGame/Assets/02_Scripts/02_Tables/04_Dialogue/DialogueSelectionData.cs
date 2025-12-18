using UnityEngine.Events;
using UnityEngine;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueSelectionData : IDialogueSequence
  {
    private readonly UnityAction onDirty;
    public DialogueSelectionData(string conditionName, UnityAction onDirty)
    {
      this.onDirty = onDirty;
      conditionSet = new DialogueConditionSet(conditionName, onDirty);
    }

    [SerializeField] private int selctionID;
    [SerializeField] private string subName;

    [SerializeField] private DialogueConditionSet conditionSet;
    public DialogueConditionSet ConditionSet => conditionSet;

    [SerializeField] private int leftUpKey;
    [SerializeField] private int leftRightKey;
    [SerializeField] private int leftDownKey;
    [SerializeField] private int leftLeftKey;

    [SerializeField] private int rightUpKey;
    [SerializeField] private int rightRightKey;
    [SerializeField] private int rightDownKey;
    [SerializeField] private int rightLeftKey;

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
    public int SelctionID
    {
      get => this.selctionID;
      set
      {
        if (selctionID == value)
          return;

        onDirty?.Invoke();
        selctionID = value;
      }
    }

    public int LeftUpKey
    {
      get => this.leftUpKey;
      set
      {
        if (leftUpKey == value)
          return;

        onDirty?.Invoke();
        leftUpKey = value;
      }
    }
    public int LeftRightKey
    {
      get => this.leftRightKey;
      set
      {
        if (leftRightKey == value)
          return;

        onDirty?.Invoke();
        leftRightKey = value;
      }
    }
    public int LeftDownKey
    {
      get => this.leftDownKey;
      set
      {
        if (leftDownKey == value)
          return;

        onDirty?.Invoke();
        leftDownKey = value;
      }
    }
    public int LeftLeftKey
    {
      get => this.leftLeftKey;
      set
      {
        if (leftLeftKey == value)
          return;

        onDirty?.Invoke();
        leftLeftKey = value;
      }
    }

    public int RightUpKey
    {
      get => this.rightUpKey;
      set
      {
        if (rightUpKey == value)
          return;

        onDirty?.Invoke();
        rightUpKey = value;
      }
    }
    public int RightRightKey
    {
      get => this.rightRightKey;
      set
      {
        if (rightRightKey == value)
          return;

        onDirty?.Invoke();
        rightRightKey = value;
      }
    }
    public int RightDownKey
    {
      get => this.rightDownKey;
      set
      {
        if (rightDownKey == value)
          return;

        onDirty?.Invoke();
        rightDownKey = value;
      }
    }
    public int RightLeftKey
    {
      get => this.rightLeftKey;
      set
      {
        if (rightLeftKey == value)
          return;

        onDirty?.Invoke();
        rightLeftKey = value;
      }
    }

    public void AddNewCondition()
      => conditionSet.AddCondition(new DialogueCondition(onDirty));

    public void RemoveCondition(DialogueCondition condition)
      => conditionSet.RemoveCondition(condition);
  }
}