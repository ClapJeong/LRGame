using System;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  [Serializable]
  public abstract class DialogueSequenceBase : IDialogueSequence, IDirtyPatcher
  {
    [SerializeField] protected string subName;
    public abstract IDialogueSequence.Type SequenceType { get; }
    public abstract string SubName { get; set; }

    public abstract string FormatedName { get; }

    public abstract DialogueCondition GetCondition();

    public abstract void SetOnDirty(UnityAction onDirty);
  }
}
