using Cysharp.Threading.Tasks;
using System.Threading;

public interface IGameDataService
{
  public UniTask SaveDataAsync(CancellationToken token = default);

  public UniTask LoadDataAsync(CancellationToken token = default);

  public void SetClearData(int chapter, int stage);

  public bool IsEnableStage(int chapter, int stage);

  public bool IsEnableChapter(int chapter);

  public GameData.ChapterStageData GetTopClearData();

  public void SetSelectedStage(int chapter, int stage);

  public void GetSelectedStage(out int chapter, out int stage);

  public bool IsStageExist(int chapter, int stage);
}
