using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueData
  {
    [System.Serializable]
    public class TurnData
    {
      public enum Type
      {
        Talking,
        Selection,
      }
      
      [SerializeField] public Type dataType;
      public string FieldName => $"Dialogue: {dataType.ToString()}_{subName}";

      public UnityAction onDirty;      

      [SerializeField] private string subName = "none";

      [SerializeField] private List<DialogueTalkingData> talkingSequences;
      [SerializeField] private List<DialogueSelectionData> selectionSequences;

      public List<DialogueTalkingData> TalkingSequences => talkingSequences;
      public List<DialogueSelectionData> SelectionSequences => selectionSequences;

      public List<DialogueConditionSet> SelectedDataConditionSets 
        => dataType switch
        {
          Type.Talking => TalkingSequences.Select(set => set.ConditionSet).ToList(),
          Type.Selection => SelectionSequences.Select(set => set.ConditionSet).ToList(),
          _ => throw new System.NotImplementedException()
        };

      public TurnData(DialogueTalkingData turnData, UnityAction onDirty)
      {
        this.onDirty = onDirty;
        dataType = Type.Talking;
        talkingSequences = new()
        {
          turnData
        };

        onDirty?.Invoke();
      }

      public TurnData(DialogueSelectionData selectionData, UnityAction onDirty)
      {
        this.onDirty = onDirty;
        dataType = Type.Selection;
        selectionSequences = new()
        {
          selectionData
        };

        onDirty?.Invoke();
      }

      public void RemoveConditionSet(DialogueConditionSet set)
      {
        switch (dataType)
        {
          case Type.Talking:
            {
              var target = talkingSequences.FirstOrDefault(data => data.ConditionSet == set);
              RemoveTalkingCondition(target);
            }
            break;

          case Type.Selection:
            {
              var target = selectionSequences.FirstOrDefault(data => data.ConditionSet== set);
              RemoveSelectionCondition(target);
            }
            break;
        }

        onDirty?.Invoke();
      }

      public void AddNewConditionSet()
      {
        switch (dataType)
        {
          case Type.Talking:
            AddTalkingCondition();

            break;
          case Type.Selection:
            AddSelectionCondition();
            break;
        }

        onDirty?.Invoke();
      }

      private void AddTalkingCondition()
      {
        talkingSequences.Add(new DialogueTalkingData("none", onDirty));
        onDirty?.Invoke();
      }

      public void RemoveTalkingCondition(DialogueTalkingData talkingData)
      {
        if (talkingSequences == null || !talkingSequences.Contains(talkingData))
          return;

        talkingSequences.Remove(talkingData);
        onDirty?.Invoke();
      }

      private void AddSelectionCondition()
      {
        selectionSequences ??= new();
        selectionSequences.Add(new DialogueSelectionData("none", onDirty));
        onDirty?.Invoke();
      }

      public void RemoveSelectionCondition(DialogueSelectionData selectionData)
      {
        if (selectionSequences == null || !selectionSequences.Contains(selectionData))
          return;

        selectionSequences.Remove(selectionData);
        onDirty?.Invoke();
      }

    }

    public UnityAction onDirty;
    public DialogueData(UnityAction onDirty)
      => this.onDirty = onDirty;

    [SerializeField] private List<TurnData> turnDatas;

    public List<TurnData> TurnDatas => turnDatas;

    public void CreateTurnData(TurnData.Type type)
    {
      turnDatas ??= new();
      switch (type)
      {
        case TurnData.Type.Talking:
          turnDatas.Add(new TurnData(new DialogueTalkingData("default", this.onDirty), this.onDirty));
          break;

        case TurnData.Type.Selection:
          turnDatas.Add(new TurnData(new DialogueSelectionData("default", this.onDirty), this.onDirty));
          break;
      }

      onDirty?.Invoke();
    }

    public void RemoveTurnData(TurnData turnData)
    {
      if (turnDatas == null || !turnDatas.Contains(turnData))
        return;

      turnDatas.Remove(turnData);
      onDirty?.Invoke();
    }
  }
}