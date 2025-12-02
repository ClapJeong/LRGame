using Cysharp.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Threading;
using UnityEngine;

public class GameDataService : IGameDataService
{
  private readonly string GameDataPath;
  private GameData gameData;

  private int selectedChapter;
  private int selectedStage;

  public GameDataService()
  {
    GameDataPath = Application.persistentDataPath + "/GameData.json";
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

  public void SetClearData(int chapter, int stage)
  {
    var chapterData = GetChapterData(chapter);

    if (chapterData == null)
    {
      chapterData = new GameData.ChapterStageData
      {
        chapter = chapter
      };
      gameData.chaterStageDatas.Add(chapterData);
    }

    chapterData.stage = stage;
  }

  public bool IsEnableStage(int chapter, int stage)
  {
    var chapterData = GetChapterData(chapter);

    return chapterData.stage >= stage;
  }

  public bool IsEnableChapter(int chapter)
  {
    var chapterData = GetChapterData(chapter);
    
    return chapterData != null;
  }

  public GameData.ChapterStageData GetTopClearData()
  {
    if (gameData != null)
    {
      var topData = gameData.chaterStageDatas.OrderByDescending(data => data.chapter).FirstOrDefault();
      topData ??= new GameData.ChapterStageData();

      return topData;
    }
    else
      return new GameData.ChapterStageData();
  }

  private GameData.ChapterStageData GetChapterData(int chapter)
    => gameData
          .chaterStageDatas
          .FirstOrDefault(set => set.chapter == chapter);

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

  #region Debugging
  public void Debugging_RaiseClearData()
  {
    var topData = GetTopClearData();
    if (topData.stage >= 3)
      topData.stage++;
    else
      SetClearData(topData.chapter, topData.stage + 1);

    SaveDataAsync().Forget();
  }

  public void Debugging_LowerClearData()
  {
    var topData = GetTopClearData();
    if (topData.stage == 0)
      gameData.chaterStageDatas.Remove(topData);
    else
      topData.stage--;

    SaveDataAsync().Forget();
  }
  #endregion
}