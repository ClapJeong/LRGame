using UnityEngine.Events;
using UnityEngine;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueSelectionData : DialogueSequenceBase
  {
    private UnityAction onDirty;
    public override IDialogueSequence.Type SequenceType => IDialogueSequence.Type.Selection;
    public override string FormatedName => $"{SequenceType}_{subName}";

    public override string SubName
    {
      get => this.subName;
      set
      {
        if (subName == value)
          return;

        subName = value;
        onDirty?.Invoke();        
      }
    }

    public string DescriptionKey
    {
      get => this.descriptionKey;
      set
      {
        if (descriptionKey == value)
          return;

        descriptionKey = value;
        onDirty?.Invoke();        
      }
    }

    public string LeftUpKey
    {
      get => this.leftUpKey;
      set
      {
        if (leftUpKey == value)
          return;

        leftUpKey = value;
        onDirty?.Invoke();        
      }
    }
    public string LeftRightKey
    {
      get => this.leftRightKey;
      set
      {
        if (leftRightKey == value)
          return;

        leftRightKey = value;
        onDirty?.Invoke();        
      }
    }
    public string LeftDownKey
    {
      get => this.leftDownKey;
      set
      {
        if (leftDownKey == value)
          return;

        leftDownKey = value;
        onDirty?.Invoke();        
      }
    }
    public string LeftLeftKey
    {
      get => this.leftLeftKey;
      set
      {
        if (leftLeftKey == value)
          return;

        leftLeftKey = value;
        onDirty?.Invoke();        
      }
    }

    public string RightUpKey
    {
      get => this.rightUpKey;
      set
      {
        if (rightUpKey == value)
          return;

        rightUpKey = value;
        onDirty?.Invoke();        
      }
    }
    public string RightRightKey
    {
      get => this.rightRightKey;
      set
      {
        if (rightRightKey == value)
          return;

        rightRightKey = value;
        onDirty?.Invoke();        
      }
    }
    public string RightDownKey
    {
      get => this.rightDownKey;
      set
      {
        if (rightDownKey == value)
          return;

        rightDownKey = value;
        onDirty?.Invoke();        
      }
    }
    public string RightLeftKey
    {
      get => this.rightLeftKey;
      set
      {
        if (rightLeftKey == value)
          return;

        rightLeftKey = value;
        onDirty?.Invoke();        
      }
    }

    [SerializeField] private DialogueCondition condition;

    [SerializeField] private string descriptionKey;

    [SerializeField] private string leftUpKey;
    [SerializeField] private string leftRightKey;
    [SerializeField] private string leftDownKey;
    [SerializeField] private string leftLeftKey;

    [SerializeField] private string rightUpKey;
    [SerializeField] private string rightRightKey;
    [SerializeField] private string rightDownKey;
    [SerializeField] private string rightLeftKey;


    public DialogueSelectionData(string subName, UnityAction onDirty)
    {
      this.onDirty = onDirty;
      this.subName = subName;
      condition = new DialogueCondition( onDirty);
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