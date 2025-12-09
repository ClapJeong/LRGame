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

  public List<ChapterStageData> chaterStageDatas = new();
}
