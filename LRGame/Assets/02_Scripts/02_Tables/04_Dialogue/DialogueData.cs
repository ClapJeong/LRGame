using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueData : IDirtyPatcher
  {
    [System.Serializable]
    public class SequenceSet : IDirtyPatcher
    {
      public IDialogueSequence.Type SequenceType => sequenceType;

      public IReadOnlyList<DialogueSequenceBase> Sequences => sequences;

      [SerializeField] private IDialogueSequence.Type sequenceType;      
      [SerializeReference] private List<DialogueSequenceBase> sequences = new();
      private UnityAction onDirty;

      public SequenceSet(IDialogueSequence.Type type, UnityAction onDirty)
      {
        this.onDirty = onDirty;
        this.sequenceType = type;

        switch (sequenceType)
        {
          case IDialogueSequence.Type.Talking:
            {
              sequences.Add(new DialogueTalkingData(true, "default", onDirty));
            }
            break;

          case IDialogueSequence.Type.Selection:
            {
              sequences.Add(new DialogueSelectionData(true, "default", onDirty));
            }
            break;
        }

        onDirty?.Invoke();
      }

      public void CreateNewSequence()
      {
        switch (sequenceType)
        {
          case IDialogueSequence.Type.Talking:
            {
              sequences.Add(new DialogueTalkingData(false, "talking", onDirty));
            }
            break;

          case IDialogueSequence.Type.Selection:
            {
              sequences.Add(new DialogueSelectionData(false, "selection", onDirty));
            }
            break;
        }

        onDirty?.Invoke();
      }

      public void RemoveSequence(DialogueSequenceBase sequence)
      {
        if (sequences.Contains(sequence) == false)
          return;

        sequences.Remove(sequence);
        onDirty?.Invoke();
      }

      public void SetOnDirty(UnityAction onDirty)
      {
        this.onDirty = onDirty;
        foreach(var sequence in sequences)
          sequence.SetOnDirty(onDirty);
      }
    }

    private readonly UnityAction onDirty;

    [SerializeField] private List<SequenceSet> sequenceSets = new();
    public List<SequenceSet> SequenceSets => sequenceSets;

    public DialogueData(UnityAction onDirty)
    {
      this.onDirty = onDirty;
    }

    public void AddSequenceSet(IDialogueSequence.Type type)
    {
      sequenceSets.Add(new SequenceSet(type, onDirty));
      onDirty?.Invoke();
    }

    public void RemoveSequenceSet(SequenceSet sequenceSet)
    {
      sequenceSets.Remove(sequenceSet);
      onDirty?.Invoke();
    }

    public void SetOnDirty(UnityAction onDirty)
    {
      foreach(var sequenceSet in sequenceSets)
        sequenceSet.SetOnDirty(onDirty);
    }
  }
}