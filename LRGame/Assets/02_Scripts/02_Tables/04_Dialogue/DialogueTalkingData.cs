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

    public DialogueTalkingData(DialogueTalkingData previousTalkingData, string subName, UnityAction onDirty)
    {
      this.onDirty = onDirty;
      this.subName = subName;
      left = new(previousTalkingData != null ? previousTalkingData.left.Portrait : 0,  "name_left_idle", "dialogue_sample", this.onDirty);
      center = new(previousTalkingData != null ? previousTalkingData.center.Portrait : 0, "name_doctor_idle", "dialogue_sample", this.onDirty);
      right = new(previousTalkingData != null ? previousTalkingData.right.Portrait : 0, "name_right_idle", "dialogue_sample", this.onDirty);
      condition = condition = new DialogueCondition(onDirty);
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