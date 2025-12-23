using LR.Table.Dialogue;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
  [System.Serializable]
  public class ChapterStageData
  {
    public int chapter;
    public int stage;
  }

  [System.Serializable]
  public class ConditionData
  {
    public string key;
    public int left;
    public int right;

    public ConditionData(string key, int left, int right)
    {
      this.key = key;
      this.left = left;
      this.right = right;
    }

    public bool IsSame(string key, int left,int right)
      => this.key == key && this.left == left && this.right == right;
  }

  public List<ChapterStageData> chaterStageDatas = new();

  public List<ConditionData> dialogueConditions = new();
}
