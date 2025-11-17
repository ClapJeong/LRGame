using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

public interface IGameDataController
{
  public UniTask SaveDataAsync(CancellationToken token = default);

  public UniTask LoadDataAsync(CancellationToken token = default);

  public int GetClearStage();

  public void SetClearStage(int stage);
}
