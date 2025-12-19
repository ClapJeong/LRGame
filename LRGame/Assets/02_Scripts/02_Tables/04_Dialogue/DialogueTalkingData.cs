using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueTalkingData : DialogueSequenceBase
  {
    private UnityAction onDirty;
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
    public int Background
    {
      get => this.background;
      set
      {
        if (background == value)
          return;

        onDirty?.Invoke();
        background = value;
      }
    }

    public override IDialogueSequence.Type SequenceType => IDialogueSequence.Type.Talking;

    public override string FormatedName => $"{SequenceType}_{subName}";

    public DialogueCharacterData left;
    public DialogueCharacterData center;
    public DialogueCharacterData right;

    [SerializeField] private int background;
    [SerializeField] private DialogueCondition condition;

    public DialogueTalkingData(bool isDefault, string subName, UnityAction onDirty)
    {
      this.onDirty = onDirty;
      this.subName = subName;
      left = new(this.onDirty);
      center = new(this.onDirty);
      right = new(this.onDirty);
      condition = condition = new DialogueCondition(isDefault, onDirty);
    }

    public override void SetOnDirty(UnityAction onDirty)
    {
      this.onDirty = onDirty;
      condition.SetOnDirty(onDirty);
      left.SetOnDirty(onDirty);
      center.SetOnDirty(onDirty);
      right.SetOnDirty(onDirty);
    }

    public override DialogueCondition GetCondition()
    {
      return condition;
    }
  }
}