using Cysharp.Threading.Tasks;
using System.Threading;

public interface IGameDataService
{
  public int StageDataCount { get; }

  public UniTask SaveDataAsync(CancellationToken token = default);

  public UniTask LoadDataAsync(CancellationToken token = default);

  public void SetClearData(int chapter, int stage);

  public GameData.ChapterStageData GetTopClearData();

  public void SetSelectedStage(int chapter, int stage);

  public void GetSelectedStage(out int chapter, out int stage);

  public bool IsStageExist(int chapter, int stage);

  public void SetDialogueCondition(string key, int left, int right);

  public bool IsContainsCondition(string key, int left, int right);

  public bool IsClearStage(int chapter, int stage);
}
