using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using LR.Stage;
using LR.Stage.StageDataContainer;

public interface IStageObjectSetupService<T>
{
  public UniTask<List<T>> SetupAsync(StageDataContainer stageDataContainer, bool isEnableImmediately = false);

  public void Release();

  public UniTask AwaitUntilSetupCompleteAsync();
}
