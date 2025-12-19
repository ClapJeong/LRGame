using UnityEngine.Events;
using UnityEngine;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueSelectionData : DialogueSequenceBase
  {
    private UnityAction onDirty;
    public override IDialogueSequence.Type SequenceType => IDialogueSequence.Type.Selection;
    public override string FormatedName => $"{SequenceType}_{selectionID}_{subName}";

    public override string SubName
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
    public int SelectionID
    {
      get => this.selectionID;
      set
      {
        if (selectionID == value)
          return;

        onDirty?.Invoke();
        selectionID = value;
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

    [SerializeField] private int selectionID;

    [SerializeField] private DialogueCondition condition;

    [SerializeField] private int leftUpKey;
    [SerializeField] private int leftRightKey;
    [SerializeField] private int leftDownKey;
    [SerializeField] private int leftLeftKey;

    [SerializeField] private int rightUpKey;
    [SerializeField] private int rightRightKey;
    [SerializeField] private int rightDownKey;
    [SerializeField] private int rightLeftKey;


    public DialogueSelectionData(string conditionName, UnityAction onDirty)
    {
      this.onDirty = onDirty;
      condition = new DialogueCondition(conditionName, onDirty);
    }

    public override void SetOnDirty(UnityAction onDirty)
    {
      this.onDirty = onDirty;
      condition.SetOnDirty(onDirty);
    }

    public override DialogueCondition GetCondition()
    {
      return condition;
    }
  }
}