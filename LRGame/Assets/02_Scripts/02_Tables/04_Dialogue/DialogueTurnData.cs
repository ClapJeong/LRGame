using System.Collections.Generic;

namespace LR.Table.Dialogue
{
  public class DialogueTurnData
  {
    public string subName;

    public List<DialogueCondition> conditions = new();
    public int background;

    public DialogueCharacterData left;
    public DialogueCharacterData doctor;
    public DialogueCharacterData right;
    public DialogueCharacterData narrator;
  }
}