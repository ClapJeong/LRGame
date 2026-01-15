using Cysharp.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using UnityEngine;

public class GameDataService : IGameDataService
{
  private readonly string GameDataPath;
  private GameData gameData;

  public int StageDataCount { get; protected set; }

  private int selectedChapter;
  private int selectedStage;

  public GameDataService(IResourceManager resourceManager)
  {
    GameDataPath = Application.persistentDataPath + "/GameData.json";

    CacheStageCount(resourceManager).Forget();
  }

  public async UniTask SaveDataAsync(CancellationToken token = default)
  {
    if (gameData == null)
      gameData = new GameData();

    var json = JsonUtility.ToJson(gameData);
    await File.WriteAllTextAsync(GameDataPath, json, token);
  }

  public async UniTask LoadDataAsync(CancellationToken token = default)
  {
    if (File.Exists(GameDataPath) == false)
    {
      gameData = new GameData();
    }
    else
    {
      var text = await File.ReadAllTextAsync(GameDataPath, token);
      gameData = JsonUtility.FromJson<GameData>(text);
    }
  }

  public void SetClearData(int chapter, int stage, bool left, bool right)
  {
    var chapterData = GetClearData(chapter, stage);
    if (chapterData == null)
    {
      chapterData = new GameData.ClearData(chapter, stage, left, right);
      gameData.clearDatas.Add(chapterData);
    }
    else
    {
      chapterData.left = chapterData.left || left;
      chapterData.right = chapterData.right || right;
    }      
  }

  public void GetScoreData(int chapter, int stage, out bool left, out bool right)
  {
    if (gameData != null)
    {
      var targetData = GetClearData(chapter, stage);
      if (targetData != null)
      {
        left = targetData.left;
        right = targetData.right;
        return;
      }
    }

    left = false;
    right = false;
  }

  public GameData.ClearData GetTopClearData()
  {
    if (gameData != null)
    {
      var topData = gameData
        .clearDatas
        .OrderByDescending(data => data.chapter * 4 + data.stage).FirstOrDefault();
      topData ??= new GameData.ClearData(0,0,false,false);

      return topData;
    }
    else
      return new GameData.ClearData(0,0,false,false);
  }

  private GameData.ClearData GetClearData(int chapter, int stage)
    => gameData
          .clearDatas
          .FirstOrDefault(set => set.chapter == chapter && set.stage == stage);

  public void SetSelectedStage(int chapter, int stage)
  {    
    selectedChapter = chapter;
    selectedStage = stage;
  }

  public void GetSelectedStage(out int chapter, out int stage)
  {
    chapter = selectedChapter;
    stage = selectedStage;
  }

  public bool IsStageExist(int chapter, int stage)
    => (chapter * 4 + stage) <= StageDataCount;

  public bool IsClearStage(int chapter, int stage)
    => GetClearData(chapter, stage) != null;

  private async UniTask CacheStageCount(IResourceManager resourceManager)
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var stageLabel = table.Label.Stage;

    var stages = await resourceManager.LoadAssetsAsync(stageLabel);
    StageDataCount = stages.Count;
  }

  public void SetDialogueCondition(string key, int left, int right)
  {
    var existCondition = gameData.dialogueConditions.FirstOrDefault(data => data.key == key);
    if(existCondition == null)
    {
      var newCondition = new GameData.ConditionData(key, left, right);
      gameData.dialogueConditions.Add(newCondition);
    }
    else
    {
      existCondition.left = left; 
      existCondition.right = right; 
    }
  }

  public bool IsContainsCondition(string key, int left, int right)
  {
    var targetCondition = gameData.dialogueConditions.FirstOrDefault(data => data.IsSame(key, left, right));
    return targetCondition != null;
  }

  public bool IsVeryFirst()
  {
    var topClearData = GetTopClearData();
    return topClearData.chapter == 0 && topClearData.stage == 0;
  }


  #region Debugging
  public void Debugging_RaiseClearData()
  {
    var topData = GetTopClearData();
    if (topData.stage >= 3)
      topData.stage++;
    else
      SetClearData(topData.chapter, topData.stage + 1, true,true);

    SaveDataAsync().Forget();
  }

  public void Debugging_LowerClearData()
  {
    var topData = GetTopClearData();
    if (topData.stage == 0)
      gameData.clearDatas.Remove(topData);
    else
      topData.stage--;

    SaveDataAsync().Forget();
  }

  public string Debugging_GetAllConditions()
  {
    var stb = new StringBuilder();
    for(int i = 0; i < gameData.dialogueConditions.Count; i++)
    {
      var condition = gameData.dialogueConditions[i];
      stb.Append($"{condition.key}: {condition.left}/{condition.right}");
      if (i < gameData.dialogueConditions.Count - 1)
        stb.Append("\n");
    }
    return stb.ToString();
  }

  public void Debugging_ClearAllDialogueConditions()
  {
    gameData.dialogueConditions.Clear();

    SaveDataAsync().Forget();
  }
  #endregion
}