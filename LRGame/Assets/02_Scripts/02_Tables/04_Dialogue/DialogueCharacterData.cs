
using UnityEngine;
using UnityEngine.Events;

namespace LR.Table.Dialogue
{
  public class DialogueCharacterData
  {
    private readonly UnityAction onDirty;
    public DialogueCharacterData(UnityAction onDirty)
      => this.onDirty = onDirty;

    [SerializeField] private int portrait;
    [SerializeField] private int portraitChangeType;
    [SerializeField] private int portraitAnimationType;
    [SerializeField] private int portraitAlphaType;
    [SerializeField] private string nameKey;
    [SerializeField] private string descriptionKey;

    public int Portrait 
    {  
      get => this.portrait;
      set 
      {
        if (portrait == value)
          return;

        onDirty?.Invoke();
        portrait = value;
      }}
    public int PortraitChangelType
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

        onDirty?.Invoke();
        portraitAnimationType = value;
      }
    }
    public int PortraitAlphaType
    {
      get => this.portraitAlphaType;
      set
      {
        if (portraitAlphaType == value)
          return;

        onDirty?.Invoke();
        portraitAlphaType = value;
      }
    }
    public string NameKey
    {
      get => this.nameKey;
      set
      {
        if (nameKey == value)
          return;

        onDirty?.Invoke();
        nameKey = value;
      }
    }
    public string DescriptionKey
    {
      get => this.descriptionKey;
      set
      {
        if (descriptionKey == value)
          return;

        onDirty?.Invoke();
        descriptionKey = value;
      }
    }
  }
}