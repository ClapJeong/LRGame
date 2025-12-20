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

      public SequenceSet(IDialogueSequence.Type type, UnityAction onDirty, SequenceSet previousTalkingSequenceSet)
      {
        this.onDirty = onDirty;
        this.sequenceType = type;

        switch (sequenceType)
        {
          case IDialogueSequence.Type.Talking:
            {
              var previousTalkingData = previousTalkingSequenceSet != null ? previousTalkingSequenceSet.sequences.First() as DialogueTalkingData : null;
              sequences.Add(new DialogueTalkingData(previousTalkingData, "default", onDirty));
            }
            break;

          case IDialogueSequence.Type.Selection:
            {
              sequences.Add(new DialogueSelectionData("default", onDirty));
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
              sequences.Add(new DialogueTalkingData(null, "talking", onDirty));
            }
            break;

          case IDialogueSequence.Type.Selection:
            {
              sequences.Add(new DialogueSelectionData("selection", onDirty));
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

    private UnityAction onDirty;

    [SerializeField] private List<SequenceSet> sequenceSets = new();
    public List<SequenceSet> SequenceSets => sequenceSets;

    public DialogueData(UnityAction onDirty)
    {
      this.onDirty = onDirty;
    }

    public void AddSequenceSet(IDialogueSequence.Type type)
    {
      var lastSequenceSet = sequenceSets.LastOrDefault();
      sequenceSets.Add(new SequenceSet(type, onDirty, lastSequenceSet != null && lastSequenceSet.SequenceType == IDialogueSequence.Type.Talking ? lastSequenceSet : null));
      onDirty?.Invoke();
    }

    public void RemoveSequenceSet(SequenceSet sequenceSet)
    {
      sequenceSets.Remove(sequenceSet);
      onDirty?.Invoke();
    }

    public void SetOnDirty(UnityAction onDirty)
    {
      this.onDirty = onDirty;
      foreach(var sequenceSet in sequenceSets)
        sequenceSet.SetOnDirty(onDirty);
    }
  }
}