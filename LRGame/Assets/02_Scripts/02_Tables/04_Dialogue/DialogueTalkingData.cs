using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  public class DialogueTalkingData
  {
    private readonly UnityAction onDirty;
    public DialogueTalkingData(UnityAction onDirty)
    {
      this.onDirty = onDirty;
      left = new(this.onDirty);
      doctor = new(this.onDirty);
      right = new(this.onDirty);
      narrator = new(this.onDirty);
    }

    [SerializeField] private string subName;

    [SerializeField] private List<DialogueCondition> conditions;
    [SerializeField] private int background;

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

    public List<DialogueCondition> Conditions => conditions;

    public void AddCondition(DialogueCondition condition)
    {
      conditions ??= new();
      conditions.Add(condition);
      onDirty?.Invoke();
    }

    public void RemoveCondition(DialogueCondition condition)
    {
      if (conditions == null || !conditions.Contains(condition))
        return;

      conditions.Remove(condition);
      onDirty?.Invoke();
    }
  }
}