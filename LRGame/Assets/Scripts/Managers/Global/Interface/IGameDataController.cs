using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

public interface IGameDataController
{
  public UniTask SaveAsync(CancellationToken token);

  public UniTask LoadAsync(CancellationToken token);

  public int GetClearStage();

  public void SetClearStage(int stage);
}
