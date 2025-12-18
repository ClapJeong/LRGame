using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueTalkingData : IDialogueSequence
  {
    private readonly UnityAction onDirty;
    public DialogueTalkingData(string conditonName, UnityAction onDirty)
    {
      this.onDirty = onDirty;
      left = new(this.onDirty);
      doctor = new(this.onDirty);
      right = new(this.onDirty);
      narrator = new(this.onDirty);
      conditionSet = new DialogueConditionSet(conditonName, onDirty);
    }

    [SerializeField] private string subName;

    [SerializeField] private int background;

    [SerializeField] private DialogueConditionSet conditionSet;
    public DialogueConditionSet ConditionSet => conditionSet;

    public DialogueCharacterData left;
    public DialogueCharacterData doctor;
    public DialogueCharacterData right;
    public DialogueCharacterData narrator;

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

    public void AddNewCondition()
      => conditionSet.AddCondition(new DialogueCondition(onDirty));

    public void RemoveCondition(DialogueCondition condition)
      => conditionSet.RemoveCondition(condition);
  }
}