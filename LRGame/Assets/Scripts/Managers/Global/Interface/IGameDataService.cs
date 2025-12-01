using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

public interface IGameDataService
{
  public UniTask SaveDataAsync(CancellationToken token = default);

  public UniTask LoadDataAsync(CancellationToken token = default);

  public void SetClearData(int chapter, int stage);

  public bool IsEnableStage(int chapter, int stage);

  public bool IsEnableChapter(int chapter);

  public void SetCurrentStageData(int chapter, int stage);

  public GameData.ChapterStageData GetTopClearData();
}
