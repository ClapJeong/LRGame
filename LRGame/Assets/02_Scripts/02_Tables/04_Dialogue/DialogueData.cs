using System.Collections.Generic;
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
      public string FieldName => $"{dataType.ToString()}_{subName}";

      public UnityAction onDirty;      

      [SerializeField] private string subName = "none";

      [SerializeField] private List<DialogueTalkingData> talkingDatas;
      [SerializeField] private List<DialogueSelectionData> selectionDatas;

      public List<DialogueTalkingData> TalkingDatas => talkingDatas;
      public void AddTalkingData(DialogueTalkingData talkingData)
      {
        talkingDatas ??= new();
        talkingDatas.Add(talkingData);
        onDirty?.Invoke();
      }
      public void RemoveTalkingData(DialogueTalkingData talkingData)
      {
        if (talkingDatas == null || !talkingDatas.Contains(talkingData))
          return;

        talkingDatas.Remove(talkingData);
        onDirty?.Invoke();
      }

      public List<DialogueSelectionData> SelectionDatas => selectionDatas;
      public void AddSelectionData(DialogueSelectionData selectionData)
      {
        selectionDatas ??= new();
        selectionDatas.Add(selectionData);
        onDirty?.Invoke();
      }
      public void RemoveSelectionData(DialogueSelectionData selectionData)
      {
        if (selectionDatas == null || !selectionDatas.Contains(selectionData))
          return;

        selectionDatas.Remove(selectionData);
        onDirty?.Invoke();
      }

      public TurnData(DialogueTalkingData turnData, UnityAction onDirty)
      {
        this.onDirty = onDirty;
        dataType = Type.Talking;
        talkingDatas = new()
        {
          turnData
        };

        onDirty?.Invoke();
      }

      public TurnData(DialogueSelectionData selectionData, UnityAction onDirty)
      {
        this.onDirty = onDirty;
        dataType = Type.Selection;
        selectionDatas = new()
        {
          selectionData
        };

        onDirty?.Invoke();
      }
    }

    public UnityAction onDirty;
    public DialogueData(UnityAction onDirty)
      => this.onDirty = onDirty;

    [SerializeField] private List<TurnData> turnDatas;

    public List<TurnData> TurnDatas => turnDatas;

    public void AddTurnData(TurnData.Type type)
    {
      turnDatas ??= new();
      switch (type)
      {
        case TurnData.Type.Talking:
          turnDatas.Add(new TurnData(new DialogueTalkingData(this.onDirty), this.onDirty));
          break;

        case TurnData.Type.Selection:
          turnDatas.Add(new TurnData(new DialogueSelectionData(this.onDirty), this.onDirty));
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