
using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueCharacterData: IDirtyPatcher
  {
    private UnityAction onDirty;

    [SerializeField] private int portrait;
    [SerializeField] private int portraitChangeType;
    [SerializeField] private int portraitAnimationType;
    [SerializeField] private int portraitAlphaType;
    [SerializeField] private string nameKey;
    [SerializeField] private string dialogueKey;

    public int Portrait 
    {  
      get => this.portrait;
      set 
      {
        if (portrait == value)
          return;

        portrait = value;
        onDirty?.Invoke();        
      }}
    public int PortraitChangeType
    {
      get => this.portraitChangeType;
      set
      {
        if (portraitChangeType == value)
          return;

        onDirty?.Invoke();
        portraitChangeType = value;
      }
    }
    public int PortraitAnimationType
    {
      get => this.portraitAnimationType;
      set
      {
        if (portraitAnimationType == value)
          return;

        portraitAnimationType = value;
        onDirty?.Invoke();        
      }
    }
    public int PortraitAlphaType
    {
      get => this.portraitAlphaType;
      set
      {
        if (portraitAlphaType == value)
          return;

        portraitAlphaType = value;
        onDirty?.Invoke();        
      }
    }
    public string NameKey
    {
      get => this.nameKey;
      set
      {
        if (nameKey == value)
          return;

        nameKey = value;
        onDirty?.Invoke();        
      }
    }
    public string DialogueKey
    {
      get => this.dialogueKey;
      set
      {
        if (dialogueKey == value)
          return;

        dialogueKey = value;
        onDirty?.Invoke();        
      }
    }

    public DialogueCharacterData(int defaultPortrait, string defaultName, string defaultDialogue, UnityAction onDirty)
    {
      this.onDirty = onDirty;
      portrait = defaultPortrait;
      nameKey = defaultName;
      dialogueKey = defaultDialogue;
      onDirty?.Invoke();
    }

    public void SetOnDirty(UnityAction onDirty)
      => this.onDirty = onDirty;
  }
}