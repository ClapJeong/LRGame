using LR.Table.Dialogue;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
  [System.Serializable]
  public class ClearData
  {
    public int chapter;
    public int stage;
    public bool left;
    public bool right;

    public ClearData(int chapter, int stage, bool left, bool right)
    {
      this.chapter = chapter;
      this.stage = stage;
      this.left = left;
      this.right = right;
    }

    public int ParseIndex()
      => Mathf.Max(0, (chapter - 1)) * 4 + stage;
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

  public List<ClearData> clearDatas = new();

  public List<ConditionData> dialogueConditions = new();
}
