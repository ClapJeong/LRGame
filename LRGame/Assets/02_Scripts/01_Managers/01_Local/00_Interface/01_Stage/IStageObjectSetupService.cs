using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using LR.Stage;

public interface IStageObjectSetupService<T>
{
  public UniTask<List<T>> SetupAsync(object data, bool isEnableImmediately = false);

  public void Release();

  public UniTask AwaitUntilSetupCompleteAsync();
}
