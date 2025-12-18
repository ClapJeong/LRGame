using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueConditionSet
  {
    private readonly UnityAction onDirty;

    public DialogueConditionSet(string subName, UnityAction onDirty)
    {
      this.onDirty = onDirty;
      this.subName = subName;
      var defaultCondition = DialogueCondition.CreateDefault(onDirty);
      defaultCondition.TargetID = -1;
      conditions.Add(defaultCondition);

      this.onDirty?.Invoke();
    }

    [SerializeField] private string subName;

    public string SubName
    {
      get { return subName; }
      set
      {
        if(subName == value) return;

        subName = value;
        this.onDirty?.Invoke();
      }
    }

    [SerializeField] private List<DialogueCondition> conditions = new();
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
