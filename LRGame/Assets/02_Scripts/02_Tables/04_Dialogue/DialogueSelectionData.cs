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

    public string LeftUpKey
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
    public string LeftRightKey
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
    public string LeftDownKey
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
    public string LeftLeftKey
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

    public string RightUpKey
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
    public string RightRightKey
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
    public string RightDownKey
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
    public string RightLeftKey
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

    [SerializeField] private string leftUpKey;
    [SerializeField] private string leftRightKey;
    [SerializeField] private string leftDownKey;
    [SerializeField] private string leftLeftKey;

    [SerializeField] private string rightUpKey;
    [SerializeField] private string rightRightKey;
    [SerializeField] private string rightDownKey;
    [SerializeField] private string rightLeftKey;


    public DialogueSelectionData(bool isDefault, string subName, UnityAction onDirty)
    {
      this.onDirty = onDirty;
      this.subName = subName;
      condition = new DialogueCondition(isDefault, onDirty);
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