using Cysharp.Threading.Tasks;
using UnityEngine;

public interface IStageObjectSetupService<T>
{
  public UniTask SetupAsync();

  public void Release();
}
